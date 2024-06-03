using AutoMapper;
using BookStore.BLL.Constant;
using BookStore.BLL.Enum;
using BookStore.BLL.Interfaces;
using BookStore.BLL.Models;
using BookStore.BLL.Models.DTO;
using BookStore.BLL.Models.Request;
using BookStore.DAL;
using BookStore.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.BLL.Services
{
    public class BookService : IBookService
    {
        private readonly BookStoreContext _context;
        private readonly ICategoryService _categoryService;
        private readonly ICommonService _commonService;
        private readonly IMapper _mapper;

        public BookService(
            BookStoreContext context,
            ICategoryService categoryService,
            ICommonService commonService,
            IMapper mapper)
        {
            _context = context;
            _categoryService = categoryService;
            _commonService = commonService;
            _mapper = mapper;
        }

        /// <summary>
        /// Get All Books From the Database
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<BookDTO> GetAllBooks(BaseResponseErrorModel responseErrorModel)
        {
            List<BookDTO> listBooksDTO = new();
            try
            {
                var listBooks = _context.Book
                    .AsNoTracking()
                    .Include(x => x.ListCategories)
                    .ToList();
                listBooksDTO = _mapper.Map<List<BookDTO>>(listBooks);
                _commonService.GetFinalPrice(listBooksDTO);

            }
            catch (Exception ex)
            {
                responseErrorModel.SetErrorModel(ResponseError.ErrorGetAllBook, ex.Message);
            }
            return listBooksDTO != null && listBooksDTO.Count != 0 ? listBooksDTO : [];
        }

        public List<BookDTO> GetBestSellerBooks(BaseResponseErrorModel responseErrorModel)
        {
            List<BookDTO> listBooksDTO = [];
            try
            {
                var listBooks = _context.Book
                    .AsNoTracking()
                    .OrderByDescending(book => book.QuantitySold)
                    .Take(CommonConstant.NumberOfBookHomePage)
                    .ToList();
                listBooksDTO = _mapper.Map<List<BookDTO>>(listBooks);
            }
            catch (Exception ex)
            {
                responseErrorModel.SetErrorModel(ResponseError.ErrorGetBestSellerBook, ex.Message);
            }
            return listBooksDTO != null && listBooksDTO.Count != 0 ? listBooksDTO : [];
        }

        public List<BookDTO> GetBooksByCategoryUrl(string categoryUrl, BaseResponseErrorModel responseErrorModel)
        {
            List<BookDTO> listBooksDTO = [];
            try
            {
                var category = _categoryService.GetCategoryDetailByUrl(categoryUrl, responseErrorModel);
                if (category == null) listBooksDTO = null;
                else
                {
                    var listBooks = _context.BookCategory
                        .Where(bookCate => bookCate.CategoryId == category.CategoryId)
                        .Join(_context.Book, bookCate => bookCate.BookId, book => book.BookId, (bookCate, book) => book)
                        .Include(book => book.ListCategories)
                        .ToList();

                    listBooksDTO = _mapper.Map<List<BookDTO>>(listBooks);
                    _commonService.GetFinalPrice(listBooksDTO);
                }
            }
            catch (Exception ex)
            {
                responseErrorModel.SetErrorModel(ResponseError.ErrorGetBookByCategoryUrl, ex.Message);
            }
            return listBooksDTO != null && listBooksDTO.Count != 0 ? listBooksDTO : [];
        }

        public BookDTO GetBookDetailByUrl(string bookUrl, BaseResponseErrorModel responseErrorModel)
        {
            BookDTO bookDTO = new();
            try
            {
                var bookDetail = _context.Book
                    .AsNoTracking()
                    .FirstOrDefault(x => x.Url.Equals(bookUrl));
                if (bookDetail != null)
                {
                    bookDTO = _mapper.Map<BookDTO>(bookDetail);
                }
                else
                {
                    responseErrorModel.SetErrorModel(ResponseError.CouldNotFindBookByUrl);
                };
            }
            catch (Exception ex)
            {
                responseErrorModel.SetErrorModel(ResponseError.ErrorGetBookDetailByUrl, ex.Message);
            }
            return bookDTO;
        }

        public BookDTO GetBookDetailByBookId(Guid bookId, BaseResponseErrorModel responseErrorModel)
        {
            BookDTO bookDTO = new();
            try
            {
                var bookDetail = _context.Book
                    .AsNoTracking()
                    .Include(x => x.ListCategories)
                    .FirstOrDefault(x => x.BookId.Equals(bookId));
                if (bookDetail != null)
                {
                    bookDTO = _mapper.Map<BookDTO>(bookDetail);
                }
                else
                {
                    responseErrorModel.SetErrorModel(ResponseError.CouldNotFindBookByUrl);
                };
            }
            catch (Exception ex)
            {
                responseErrorModel.SetErrorModel(ResponseError.ErrorGetBookDetailByUrl, ex.Message);
            }
            return bookDTO;
        }

        public List<BookDTO> UpdateBookDetail(RequestModelUpdateBook requestModel, BaseResponseErrorModel responseErrorModel)
        {
            //VALIDATE REQUEST
            try
            {
                var cate = _context.Book.Where(x => x.Url.Equals(requestModel.Url) && !x.BookId.Equals(requestModel.BookId)).FirstOrDefault();
                if (cate != null)
                {
                    responseErrorModel.SetErrorModel(ResponseError.ErrorInAddBookExistedUrl, "");
                }
                else
                {
                    _context.Book.Where(x => x.BookId.Equals(requestModel.BookId))
                        .ExecuteUpdate(cate => cate
                            .SetProperty(b => b.Title, requestModel.Title)
                            .SetProperty(b => b.Author, requestModel.Author)
                            .SetProperty(b => b.Description, requestModel.Description)
                            .SetProperty(b => b.Url, requestModel.Url)
                            .SetProperty(b => b.ImageUrl, requestModel.ImageUrl)
                            .SetProperty(b => b.QuantityInStock, requestModel.QuantityInStock)
                            .SetProperty(b => b.OriginalPrice, requestModel.OriginalPrice)
                            .SetProperty(b => b.DiscountPrice, requestModel.DiscountPrice)
                            .SetProperty(b => b.IsDiscountPercent, requestModel.IsDiscountPercent)
                            .SetProperty(b => b.IsActive, requestModel.IsActive)
                            .SetProperty(b => b.ModifiedBy, requestModel.ModifiedBy)
                            .SetProperty(b => b.DateLastModified, DateTime.Now)
                        );
                    _context.BookCategory.Where(x => x.BookId.Equals(requestModel.BookId)).ExecuteDelete();
                    foreach(var categoryActiveId in requestModel.ListCategoryIds)
                    {
                        BookCategory bookCategory = new()
                        {
                            CategoryId = categoryActiveId,
                            BookId = requestModel.BookId,
                        };
                        _context.BookCategory.Add(bookCategory);
                    }
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                responseErrorModel.SetErrorModel(ResponseError.ErrorInAddCategory, ex.Message);
            }
            return GetAllBooks(responseErrorModel);
        }

        public List<BookDTO> AddNewBook(RequestModelAddNewBook requestModel, BaseResponseErrorModel responseErrorModel)
        {
            //VALIDATE REQUEST
            try
            {
                var cate = _context.Book.Where(x => x.Url.Equals(requestModel.Url)).FirstOrDefault();
                if (cate != null)
                {
                    responseErrorModel.SetErrorModel(ResponseError.ErrorInAddBookExistedUrl, "");
                }
                else
                {
                    Book book = new()
                    {
                        BookId = Guid.NewGuid(),
                        Title = requestModel.Title,
                        Author = requestModel.Author,
                        Description = requestModel.Description,
                        Url = requestModel.Url,
                        ImageUrl = requestModel.ImageUrl,
                        QuantityInStock = requestModel.QuantityInStock,
                        OriginalPrice = requestModel.OriginalPrice,
                        DiscountPrice = requestModel.DiscountPrice,
                        IsDiscountPercent = requestModel.IsDiscountPercent,
                        CreatedBy = requestModel.CreatedBy,
                        DateCreated = DateTime.Now,
                        IsActive = requestModel.IsActive
                    };
                    _context.Book.Add(book);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                responseErrorModel.SetErrorModel(ResponseError.ErrorInAddCategory, ex.Message);
            }
            return GetAllBooks(responseErrorModel);
        }

        public List<BookDTO> DeleteBook(Guid bookId, BaseResponseErrorModel responseErrorModel)
        {
            List<BookDTO> listBookDTO = [];
            try
            {
                _context.Book.Where(x => x.BookId.Equals(bookId)).ExecuteDelete();
            }
            catch (Exception ex)
            {
                responseErrorModel.SetErrorModel(ResponseError.ErrorInDeleteCategoryById, ex.Message);
            }

            listBookDTO = GetAllBooks(responseErrorModel);

            return listBookDTO ?? [];
        }
    }
}
