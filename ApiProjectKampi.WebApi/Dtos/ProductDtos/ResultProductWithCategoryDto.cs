using ApiProjectKampi.WebApi.Controllers.Entities;

namespace ApiProjectKampi.WebApi.Dtos.ProductDtos
{
    public class ResultProductWithCategoryDto
    {
        public int ProductID { get; set; } // Doğru Primary Key tanımlandı
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; } // C# isimlendirme kurallarına uygun hale getirildi
        public string ImageUrl { get; set; }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
       


    }
}
