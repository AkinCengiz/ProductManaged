using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using ProductManaged.Entities.Concrete;

namespace ProductManaged.Business.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Ürün ismi boş geçilemez...");
            RuleFor(p => p.ProductName).MinimumLength(3).WithMessage("Ürün ismi 3 karakterden az olamaz...");
            RuleFor(p => p.Stock).NotEmpty().WithMessage("Stok bilgisi boş geçilemez...");
            RuleFor(p => p.Stock).GreaterThanOrEqualTo(0).WithMessage("Stok miktarı negatif değer alamaz...");
            RuleFor(p => p.Price).NotEmpty().WithMessage("Birim fiyat boş geçilemez...");
            RuleFor(p => p.Price).GreaterThanOrEqualTo(0).WithMessage("Birim fiyat negatif değer alamaz...");
        }
    }
}
