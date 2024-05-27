namespace BookStore.BLL.Models.Request
{
    public class RequestModelBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public int QuantityInStock { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal DiscountPrice { get; set; }
        public bool IsDiscountPercent { get; set; }
        public bool IsActive { get; set; }
        public List<Guid> ListCategoryIds { get; set; }
    }

    public class RequestModelUpdateBook : RequestModelBook
    {
        public Guid ModifiedBy { get; set; }
        public Guid BookId { get; set; }
    }

    public class RequestModelAddNewBook : RequestModelBook
    {
        public Guid CreatedBy { get; set; }
    }
}
