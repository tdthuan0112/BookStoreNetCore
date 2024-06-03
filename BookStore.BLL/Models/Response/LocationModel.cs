namespace BookStore.BLL.Models.Response
{
    public class LocationModel
    {
        public string Id { get; set; }
        public string Value { get; set; }
    }

    public class ResponseApiMultiLocations {
        public int Error { get; set; }
        public string Error_Text { get; set; }
        public string Data_Name { get; set; }
        public List<Location> Data { get; set; }
    }

    public class Location
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Name_En { get; set; }
        public string Full_Name { get; set; }
        public string Full_Name_En { get; set; }
        public string Latitude { get; set; }
        public string Longtitude { get; set; }
        public int Tinh { get; set; }
        public int Quan { get; set; }
        public int Phuong { get; set; }
    }

    public class ResponseApiLocation
    {
        public int Error { get; set; }
        public string Error_Text { get; set; }
        public Location Data { get; set; }
    }
}
