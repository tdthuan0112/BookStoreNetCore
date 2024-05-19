namespace BookStore.BLL.Models.DTO
{
    public class CartDTO
    {
        public Guid UserId { get; set; }
        public ICollection<CartItemDTO> CartItems { get; set; }
    }
}
