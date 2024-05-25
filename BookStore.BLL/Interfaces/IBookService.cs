using BookStore.BLL.Enum;
using BookStore.BLL.Models;
using BookStore.BLL.Models.DTO;

namespace BookStore.BLL.Interfaces
{
    public interface IBookService
    {
        List<BookDTO> GetAllBooks(BaseResponseErrorModel responseErrorModel);
        List<BookDTO> GetBestSellerBooks(BaseResponseErrorModel responseErrorModel);
        List<BookDTO> GetBooksByCategoryUrl(string categoryUrl, BaseResponseErrorModel responseErrorModel);
        BookDTO GetBookDetailByUrl(string bookUrl, BaseResponseErrorModel responseErrorModel);
        BookDTO GetBookDetailByBookId(Guid bookId, BaseResponseErrorModel responseErrorModel);
    }
}
