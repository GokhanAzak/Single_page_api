namespace ApiProjectKampi.WebApi.Controllers.Entities
{
    public class Product
    {
        public int ProductID { get; set; } // Doğru Primary Key tanımlandı
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; } // C# isimlendirme kurallarına uygun hale getirildi
        public string ImageUrl { get; set; }
    }
}
