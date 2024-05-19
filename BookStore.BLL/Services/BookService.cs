using AutoMapper;
using BookStore.BLL.Constant;
using BookStore.BLL.Enum;
using BookStore.BLL.Interfaces;
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
        public List<BookDTO> GetAllBooks(ref ResponseError responseError)
        {
            List<BookDTO> listBooksDTO;
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
                responseError = ResponseError.ErrorGetAllBook;
                throw new Exception(message: $"Error in get all books - ${ex.Message}");
            }
            return listBooksDTO != null && listBooksDTO.Count != 0 ? listBooksDTO : [];
        }

        public async Task<List<BookDTO>> GetBestSellerBooks()
        {
            List<BookDTO> listBooksDTO;
            try
            {
                var listBooks = await _context.Book
                    .AsNoTracking()
                    .OrderByDescending(book => book.QuantitySold)
                    .Take(ConstantCommon.NumberOfBookHomePage)
                    .ToListAsync();
                listBooksDTO = _mapper.Map<List<BookDTO>>(listBooks);
            }
            catch (Exception ex)
            {
                throw new Exception(message: $"Error in get best seller books - ${ex.Message}");
            }
            return listBooksDTO != null && listBooksDTO.Count != 0 ? listBooksDTO : [];
        }

        public async Task<List<BookDTO>> GetBooksByCategoryUrl(string categoryUrl)
        {
            List<BookDTO> listBooksDTO;
            try
            {
                var category = await _categoryService.FindCategoryByUrl(categoryUrl);
                if (category == null) listBooksDTO = null;
                else
                {
                    var listBooks = await _context.BookCategory
                        .Where(bookCate => bookCate.CategoryId == category.CategoryId)
                        .Join(_context.Book, bookCate => bookCate.BookId, book => book.BookId, (bookCate, book) => book)
                        .Include(book => book.ListCategories)
                        .ToListAsync();

                    listBooksDTO = _mapper.Map<List<BookDTO>>(listBooks);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(message: $"Error in get books by category URL: ${categoryUrl}- ${ex.Message}");
            }
            return listBooksDTO != null && listBooksDTO.Count != 0 ? listBooksDTO : [];
        }

        public BookDTO GetBookDetailByUrl(string bookUrl)
        {
            BookDTO bookDTO;
            try
            {
                var bookDetail = _context.Book
                    .AsNoTracking()
                    .FirstOrDefault(x => x.Url.Equals(bookUrl));
                if (bookDetail != null)
                {
                    bookDTO = _mapper.Map<BookDTO>(bookDetail);
                }
                else bookDTO = new();
            }
            catch (Exception ex)
            {
                throw new Exception(message: $"Error in get books by bookUrl: ${bookUrl} - ${ex.Message}");
            }
            return bookDTO;
        }
    }
}
