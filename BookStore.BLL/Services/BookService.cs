using AutoMapper;
using BookStore.BLL.Constant;
using BookStore.BLL.Enum;
using BookStore.BLL.Interfaces;
using BookStore.BLL.Models;
using BookStore.BLL.Models.DTO;
using BookStore.DAL;
using Microsoft.EntityFrameworkCore;

namespace BookStore.BLL.Services
{
    public class BookService : IBookService
    {
        private readonly BookStoreContext _context;
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public BookService(
            BookStoreContext context,
            ICategoryService categoryService,
            IMapper mapper)
        {
            _context = context;
            _categoryService = categoryService;
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
                    .Take(ConstantCommon.NumberOfBookHomePage)
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
                var category = _categoryService.FindCategoryByUrl(categoryUrl, responseErrorModel);
                if (category == null) listBooksDTO = null;
                else
                {
                    var listBooks = _context.BookCategory
                        .Where(bookCate => bookCate.CategoryId == category.CategoryId)
                        .Join(_context.Book, bookCate => bookCate.BookId, book => book.BookId, (bookCate, book) => book)
                        .Include(book => book.ListCategories)
                        .ToList();

                    listBooksDTO = _mapper.Map<List<BookDTO>>(listBooks);
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
    }
}
