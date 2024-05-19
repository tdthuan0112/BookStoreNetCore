using BookStore.BLL.Enum;
using BookStore.BLL.Models.DTO;
using BookStore.BLL.Models.Request;

namespace BookStore.BLL.Interfaces
{
    public interface ICartService
    {
        CartDTO GetCart(Guid userId, ref ResponseError responseError);
        CartDTO AddToCart(RequestModelAddToCart requestModel, ref ResponseError responseError);
        CartDTO UpdateCart(RequestModelAddToCart requestModel, ref ResponseError responseError);
        CartDTO DeleteCart(RequestModelCart requestModel, ref ResponseError responseError);
    }
}
