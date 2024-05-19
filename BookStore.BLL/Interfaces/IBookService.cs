using BookStore.BLL.Enum;
using BookStore.BLL.Models.DTO;

namespace BookStore.BLL.Interfaces
{
    public interface IBookService
    {
        List<BookDTO> GetAllBooks(ref ResponseError response);
        Task<List<BookDTO>> GetBestSellerBooks();
        Task<List<BookDTO>> GetBooksByCategoryUrl(string categoryUrl);
        BookDTO GetBookDetailByUrl(string bookUrl);
    }
}
