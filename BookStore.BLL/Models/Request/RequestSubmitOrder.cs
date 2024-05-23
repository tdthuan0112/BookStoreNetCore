namespace BookStore.BLL.Models.Request
{
    public class RequestSubmitOrder
    {
        public Guid UserId { get; set; }
        public string UserNote { get; set; }
        public string Address { get; set; }
        public string District { get; set; }
        public string Ward {  get; set; }
        public int ShippingMethod { get; set; }
        public int PaymentMethod { get; set; }
    }
}
