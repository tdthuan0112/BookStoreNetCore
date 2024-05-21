using AutoMapper;
using BookStore.BLL.Enum;
using BookStore.BLL.Interfaces;
using BookStore.BLL.Models;
using BookStore.BLL.Models.DTO;
using BookStore.BLL.Models.Request;
using BookStore.DAL;
using BookStore.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.BLL.Services
{
    public class CartService : ICartService
    {
        private readonly BookStoreContext _context;
        private readonly IMapper _mapper;
        public CartService(BookStoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public CartDTO GetCart(Guid userId, BaseResponseErrorModel responseErrorModel)
        {
            CartDTO cartDTO = new();
            try
            {
                var listCartItemDTO = _context.CartItem
                    .AsNoTracking()
                    .Where(x => x.UserId == userId)
                    .Join(_context.Book,
                        cartItem => cartItem.BookId,
                        book => book.BookId,
                        (cartItem, book) => new CartItemDTO
                        {
                            BookId = book.BookId,
                            Title = book.Title,
                            Author = book.Author,
                            Url = book.Url,
                            ImageUrl = book.ImageUrl,
                            QuantityInStock = book.QuantityInStock,
                            OriginalPrice = book.OriginalPrice,
                            DiscountPrice = book.DiscountPrice,
                            IsDiscountPercent = book.IsDiscountPercent,
                            IsActive = book.IsActive,
                            Quantity = cartItem.Quantity,
                        })
                    .ToList();
                cartDTO = new CartDTO
                {
                    UserId = userId,
                    CartItems = listCartItemDTO
                };
            }
            catch (Exception ex)
            {
                responseErrorModel.SetErrorModel(ResponseError.ErrorGetCart, ex.Message);
            }
            return cartDTO ?? new CartDTO();
        }

        public CartDTO AddToCart(RequestModelAddToCart requestModel, BaseResponseErrorModel responseErrorModel)
        {
            //TODO VALIDATE REQUEST ???
            CartItem cartItem = _mapper.Map<CartItem>(requestModel);
            CartDTO cartDTO = new();
            if (cartItem != null)
            {
                try
                {
                    var findingItem = _context.CartItem
                        .FirstOrDefault(x => x.UserId == cartItem.UserId && x.BookId == cartItem.BookId);
                    if (findingItem != null)
                    {
                        findingItem.Quantity += cartItem.Quantity;

                    }
                    else
                    {
                        _context.Add(cartItem);
                    }
                    _context.SaveChanges();

                }
                catch (Exception ex)
                {
                    responseErrorModel.SetErrorModel(ResponseError.ErrorAddToCartCart, ex.Message);
                }
                cartDTO = GetCart(requestModel.UserId, responseErrorModel);
            }

            // TODO
            // else 
            return cartDTO ?? new CartDTO();
        }

        public CartDTO UpdateCart(RequestModelAddToCart requestModel, BaseResponseErrorModel responseErrorModel)
        {
            //TODO VALIDATE REQUEST ???
            CartItem cartItem = _mapper.Map<CartItem>(requestModel);
            CartDTO cartDTO = new();
            if (cartItem != null)
            {
                try
                {
                    var findingItem = _context.CartItem
                        .FirstOrDefault(x => x.UserId == cartItem.UserId && x.BookId == cartItem.BookId);
                    if (findingItem != null)
                    {
                        findingItem.Quantity = cartItem.Quantity;
                    }
                    else
                    {
                        _context.CartItem.Add(cartItem);
                    }
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    responseErrorModel.SetErrorModel(ResponseError.ErrorInUpdateCart, ex.Message);
                }
                cartDTO = GetCart(requestModel.UserId, responseErrorModel);
            }

            // TODO
            // else 
            return cartDTO ?? new CartDTO();
        }

        public CartDTO DeleteCart(RequestModelCart requestModel, BaseResponseErrorModel responseErrorModel)
        {
            //TODO VALIDATE REQUEST ???
            CartItem cartItem = _mapper.Map<CartItem>(requestModel);
            CartDTO cartDTO = new();
            if (cartItem != null)
            {
                try
                {
                    var findingItem = _context.CartItem
                        .FirstOrDefault(x => x.UserId == cartItem.UserId && x.BookId == cartItem.BookId);
                    if (findingItem != null)
                    {
                        _context.CartItem.Remove(findingItem);
                    }
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    responseErrorModel.SetErrorModel(ResponseError.ErrorInUpdateCart, ex.Message);
                }
                cartDTO = GetCart(requestModel.UserId, responseErrorModel);
            }

            // TODO
            // else 
            return cartDTO ?? new CartDTO();
        }
    }
}
