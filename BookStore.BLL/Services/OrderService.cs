using BookStore.BLL.Enum;
using BookStore.BLL.Extensions;
using BookStore.BLL.Interfaces;
using BookStore.BLL.Models;
using BookStore.BLL.Models.DTO;
using BookStore.BLL.Models.Request;
using BookStore.DAL;
using BookStore.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.BLL.Services
{
    public class OrderService : IOrderService
    {
        private readonly BookStoreContext _context;
        private readonly ICartService _cartService;

        public OrderService(BookStoreContext context, ICartService cartService)
        {
            _context = context;
            _cartService = cartService;
        }

        public List<OrderDTO> GetAllUserOrders(Guid userId, BaseResponseErrorModel baseResponseErrorModel)
        {
            List<OrderDTO> listOrderDTOs = new();
            try
            {
                var listOrders = _context.Order
                    .AsNoTracking()
                    .Where(x => x.UserId.Equals(userId))
                    .Include(x => x.ListOrderItems)
                    .ToList();
                if (listOrders != null && listOrders.Count != 0)
                {
                    foreach (var order in listOrders)
                    {
                        OrderDTO orderDTO = new()
                        {
                            OrderId  = order.OrderId,
                            UserId = userId,
                            Title = String.Join(", ", order.ListOrderItems.Select(x => x.Title).ToList()),
                            OrderNumber = order.OrderNumber,
                            TotalPrice = order.TotalPrice,
                            OrderStatus = order.OrderStatus,
                            CreatedBy = order.CreatedBy,
                            DateCreated = order.DateCreated,
                            ModifiedBy = order.ModifiedBy,
                            DateLastModified = order.DateLastModified,
                            IsActive = order.IsActive,
                        };
                        listOrderDTOs.Add(orderDTO);
                    }
                }
            }
            catch (Exception ex)
            {
                baseResponseErrorModel.SetErrorModel(ResponseError.ErrorInGetAllUserOrders, ex.Message);
            }
            return listOrderDTOs != null && listOrderDTOs.Count != 0 ? listOrderDTOs : [];
        }

        public SubmitOrderModelResponse SubmitOrder(RequestSubmitOrder request, BaseResponseErrorModel baseResponseErrorModel)
        {
            //TODO VALIDATE REQUEST ...
            SubmitOrderModelResponse response = new();
            try
            {
                var cart = _cartService.GetCart(request.UserId, baseResponseErrorModel);
                //RECHECK PRICE ....
                if (!baseResponseErrorModel.HasError() && cart != null && cart.UserId != Guid.Empty && cart.CartItems.Count != 0 && cart.TotalPriceCart > 0)
                {
                    Guid orderId = Guid.NewGuid();
                    List<OrderItem> listOrderItems = [];
                    foreach (var item in cart.CartItems)
                    {
                        OrderItem orderItem = new()
                        {
                            OrderItemId = Guid.NewGuid(),
                            BookId = item.BookId,
                            Title = item.Title,
                            OrderId = orderId,
                            OriginalPrice = item.OriginalPrice,
                            DiscountPrice = item.DiscountPrice,
                            IsDiscountPercent = item.IsDiscountPercent,
                            FinalPrice = item.FinalPrice,
                            TotalPrice = item.TotalPrice,
                            Quantity = item.Quantity,
                        };
                        listOrderItems.Add(orderItem);
                    }
                    Order order = new()
                    {
                        OrderId = orderId,
                        UserId = request.UserId,
                        OrderNumber = Guid.NewGuid().GetHashCode(),
                        UserNote = request.UserNote,
                        TotalPrice = cart.TotalPriceCart,
                        Address = request.Address,
                        District = request.District,
                        Ward = request.Ward,
                        OrderStatus = OrderStatus.Normal.ToDescription(),
                        CreatedBy = request.UserId,
                        DateCreated = DateTime.UtcNow,
                        IsActive = true,
                    };


                    _context.Order.Add(order);
                    _context.OrderItem.AddRange(listOrderItems);
                    _context.SaveChanges();

                    _context.CartItem.Where(c => c.UserId.Equals(request.UserId)).ExecuteDelete();

                    response.OrderId = orderId;
                    response.RedirectUrl = $"/order-success/{orderId}";
                }
            }
            catch (Exception ex)
            {
                baseResponseErrorModel.SetErrorModel(ResponseError.FailedToSubmitOrder, ex.Message);
            }
            return response;
        }

        public OrderDTO GetOrderDetailByOrderId(Guid orderId, BaseResponseErrorModel baseResponseErrorModel)
        {
            OrderDTO orderDTO = new();
            try
            {
                var order = _context.Order
                    .AsNoTracking()
                    .Where(x => x.OrderId.Equals(orderId))
                    .Include(x => x.ListOrderItems)
                    .Single();
                if (order != null)
                {
                    orderDTO = new()
                    {
                        OrderId = order.OrderId,
                        UserId = order.UserId,
                        Title = String.Join(", ", order.ListOrderItems.Select(x => x.Title).ToList()),
                        OrderNumber = order.OrderNumber,
                        TotalPrice = order.TotalPrice,
                        OrderStatus = order.OrderStatus,
                        CreatedBy = order.CreatedBy,
                        DateCreated = order.DateCreated,
                        ModifiedBy = order.ModifiedBy,
                        DateLastModified = order.DateLastModified,
                        IsActive = order.IsActive,
                    };
                }
            }
            catch (Exception ex)
            {
                baseResponseErrorModel.SetErrorModel(ResponseError.FailedToGetOrderDetailByOrderId, ex.Message);
            }
            return orderDTO;
        }
    }
}
