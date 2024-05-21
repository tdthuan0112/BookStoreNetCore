using BookStore.BLL.Enum;
using BookStore.BLL.Models;
using BookStore.BLL.Models.DTO;
using BookStore.BLL.Models.Request;

namespace BookStore.BLL.Interfaces
{
    public interface ICartService
    {
        CartDTO GetCart(Guid userId, BaseResponseErrorModel responseErrorModel);
        CartDTO AddToCart(RequestModelAddToCart requestModel, BaseResponseErrorModel responseErrorModel);
        CartDTO UpdateCart(RequestModelAddToCart requestModel, BaseResponseErrorModel responseErrorModel);
        CartDTO DeleteCart(RequestModelCart requestModel, BaseResponseErrorModel responseErrorModel);
    }
}
