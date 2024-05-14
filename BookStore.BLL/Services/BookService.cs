using BookStore.BLL.Interfaces;
using BookStore.DAL;

namespace BookStore.BLL.Services
{
    public class BookService : IBookService
    {
        private readonly BookStoreContext _context;
        public BookService(BookStoreContext context) {
            _context = context;
        }

        //public async Task<List<>>
    }
}
