namespace BookStore.BLL.Models.DTO
{
    public class CartItemDTO
    {
        public Guid BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public int QuantityInStock { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal DiscountPrice { get; set; }
        public bool IsDiscountPercent { get; set; }
        /// <summary>
        /// Unit Price after apply discount
        /// </summary>
        public decimal FinalPrice { get; set; }
        /// <summary>
        /// Total price = FinalPrice * Quantity
        /// </summary>
        public decimal TotalPrice { get; set; }
        public bool IsActive { get; set; }
        public int Quantity { get; set; }
    }
}
