using BookStore.BLL.Models.DTO;

namespace BookStore.BLL.Interfaces
{
    public interface IBookService
    {
        Task<List<BookDTO>> GetAllBooks();
        Task<List<BookDTO>> GetBestSellerBooks();
    }
}
