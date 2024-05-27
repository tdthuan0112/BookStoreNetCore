namespace BookStore.BLL.Models.Request
{
    public class RequestModelCategory
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public int Quantity { get; set; }
        public bool IsActive { get; set; }
    }

    public class RequestModelAddCategory : RequestModelCategory
    {
        public Guid CreatedBy { get; set; }
    }

    public class RequestModelUpdateCategory : RequestModelCategory
    {
        public Guid CategoryId { get; set; }
        public Guid ModifiedBy { get; set; }
    }
}
