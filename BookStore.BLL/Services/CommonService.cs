using BookStore.BLL.Interfaces;
using BookStore.BLL.Models.DTO;

namespace BookStore.BLL.Services
{
    public class CommonService : ICommonService
    {
        public void GetFinalPrice(List<BookDTO> listBooks)
        {
            foreach (var book in listBooks)
            {
                if (book != null)
                {
                    if (book.DiscountPrice > 0)
                    {
                        {
                            decimal finalPrice;
                            if (book.IsDiscountPercent)
                            {
                                finalPrice = book.OriginalPrice - (book.OriginalPrice * book.DiscountPrice / 100);
                            }
                            else
                            {
                                finalPrice = book.OriginalPrice - book.DiscountPrice;
                            }
                            book.FinalPrice = Math.Round(finalPrice, 2);
                        }
                    }
                    else
                    {
                        book.FinalPrice = book.OriginalPrice;
                    }
                }
            }
        }
        public void CalculateFinalAndTotalPrice(CartDTO cartDTO)
        {
            var cartItemDTOs = cartDTO.CartItems;

            foreach (var cart in cartItemDTOs)
            {
                if (cart != null)
                {
                    if (cart.DiscountPrice > 0)
                    {
                        decimal finalPrice;
                        if (cart.IsDiscountPercent)
                        {
                            finalPrice = cart.OriginalPrice - (cart.OriginalPrice * cart.DiscountPrice / 100);
                        }
                        else
                        {
                            finalPrice = cart.OriginalPrice - cart.DiscountPrice;
                        }
                        cart.FinalPrice = Math.Round(finalPrice, 2);
                    }
                    else
                    {
                        cart.FinalPrice = cart.OriginalPrice;
                    }
                    cart.TotalPrice = cart.FinalPrice * cart.Quantity;
                }
            }
            cartDTO.TotalPriceCart = Math.Round(cartDTO.CartItems.Sum(x => x.TotalPrice),2);
        }
    }
}
