using AutoMapper;
using BookStore.BLL.Constant;
using BookStore.BLL.Interfaces;
using BookStore.BLL.Models.DTO;
using BookStore.DAL;
using Microsoft.EntityFrameworkCore;

namespace BookStore.BLL.Services
{
    public class BookService : IBookService
    {
        private readonly BookStoreContext _context;
        private readonly IMapper _mapper;

        public BookService(BookStoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <summary>
        /// Get All Books From the Database
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<List<BookDTO>> GetAllBooks()
        {
            List<BookDTO> listBooksDTO;
            try
            {
                var listBooks = await _context.Book
                    .AsNoTracking()
                    .Include(x => x.ListCategories)
                    .ToListAsync();
                listBooksDTO = _mapper.Map<List<BookDTO>>(listBooks);

            }
            catch (Exception ex)
            {
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
                throw new Exception(message: $"Error in get all books - ${ex.Message}");
            }
            return listBooksDTO != null && listBooksDTO.Count != 0 ? listBooksDTO : [];
        }
    }
}
