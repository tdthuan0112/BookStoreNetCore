using BookStore.BLL.Models;
using BookStore.BLL.Models.DTO;
using BookStore.BLL.Models.Request;

namespace BookStore.BLL.Interfaces
{
    public interface IBookService
    {
        List<BookDTO> GetAllBooks(BaseResponseErrorModel responseErrorModel);
        List<BookDTO> GetBestSellerBooks(BaseResponseErrorModel responseErrorModel);
        List<BookDTO> GetBooksByCategoryUrl(string categoryUrl, BaseResponseErrorModel responseErrorModel);
        BookDTO GetBookDetailByUrl(string bookUrl, BaseResponseErrorModel responseErrorModel);
        BookDTO GetBookDetailByBookId(Guid bookId, BaseResponseErrorModel responseErrorModel);
        List<BookDTO> UpdateBookDetail(RequestModelUpdateBook requestModel, BaseResponseErrorModel responseErrorModel);
        List<BookDTO> AddNewBook(RequestModelAddNewBook requestModel, BaseResponseErrorModel responseErrorModel);
        List<BookDTO> DeleteBook(Guid bookId, BaseResponseErrorModel responseErrorModel);
    }
}
