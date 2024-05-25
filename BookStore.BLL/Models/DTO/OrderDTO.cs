namespace BookStore.BLL.Models.DTO
{
    public class OrderDTO
    {
        public Guid OrderId { get; set; }
        public Guid UserId { get; set; }
        public string Title { get; set; }
        public int OrderNumber { get; set; }
        public decimal TotalPrice { get; set; }
        public string OrderStatus { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime DateLastModified { get; set; }
        public bool IsActive { get; set; }
        public List<OrderItemDTO> ListOrderItems { get; set; }
    }

    public class SubmitOrderModelResponse()
    {
        public Guid OrderId { get; set; }
        public string RedirectUrl { get; set; }

    }
}
