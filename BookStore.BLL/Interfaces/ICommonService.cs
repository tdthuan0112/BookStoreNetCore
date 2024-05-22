using BookStore.BLL.Models.DTO;

namespace BookStore.BLL.Interfaces
{
    public interface ICommonService
    {
        void GetFinalPrice(List<BookDTO> listBooks);
        void CalculateFinalAndTotalPrice(CartDTO cartItemDTOs);
    }
}
