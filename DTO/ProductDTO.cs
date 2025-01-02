namespace IMS_Api.DTO
{
    public class ProductDTO
    {
        public string Producttitle { get; set; }
        public string Productdescription { get; set; }
        public IFormFile Image { get; set; }
        public string Price { get; set; }
        public string Productavailability { get; set; }
    }
}
