namespace BookStore.BLL.Models.Request
{
    public class RequestModelCart
    {
        public Guid UserId { get; set; }
        public Guid BookId { get; set; }
    }


    public class RequestModelAddToCart : RequestModelCart
    {
        public int Quantity { get; set; }
    }
}
