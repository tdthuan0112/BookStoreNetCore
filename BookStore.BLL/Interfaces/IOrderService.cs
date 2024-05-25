using BookStore.BLL.Models;
using BookStore.BLL.Models.DTO;
using BookStore.BLL.Models.Request;

namespace BookStore.BLL.Interfaces
{
    public interface IOrderService
    {
        SubmitOrderModelResponse SubmitOrder(RequestSubmitOrder request, BaseResponseErrorModel baseResponseErrorModel);
        List<OrderDTO> GetAllUserOrders(Guid userId, BaseResponseErrorModel baseResponseErrorModel);
        OrderDTO GetOrderDetailByOrderId(Guid orderId, BaseResponseErrorModel baseResponseErrorModel);
        List<OrderDTO> GetAllOrders(BaseResponseErrorModel baseResponseErrorModel);
    }
}
