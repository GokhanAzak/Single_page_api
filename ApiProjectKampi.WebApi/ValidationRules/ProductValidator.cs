using ApiProjectKampi.WebApi.Controllers.Entities;
using FluentValidation;
namespace ApiProjectKampi.WebApi.ValidationRules
{
    public class ProductValidator: AbstractValidator<Product>
    {


        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("ürün adı boş geçilmez");
            RuleFor(x => x.ProductName).MinimumLength(2).WithMessage("ürün adı 2 karektedern uzun olmalı ");
            RuleFor(x => x.ProductName).MaximumLength(50).WithMessage("ürün adı 50 karektedern az olmalı ");


            RuleFor(x=>x.Price).NotEmpty().WithMessage("fiyat boş geçilmez").GreaterThan(0).WithMessage("ürün fiyati negatif olamaz").LessThan(0);

            RuleFor(x => x.ProductDescription).NotEmpty().WithMessage("ürün açıklaması bos olamaz");
        }
    }
}
