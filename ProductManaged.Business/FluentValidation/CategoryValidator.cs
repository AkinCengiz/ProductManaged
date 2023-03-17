using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using ProductManaged.Entities.Concrete;

namespace ProductManaged.Business.FluentValidation
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.CategoryName).NotEmpty().WithMessage("Kategori alanı boş geçilemez...");
            RuleFor(c => c.CategoryName).MinimumLength(3).WithMessage("Kategori alanı 3 en az üç karakterden oluşmalıdır...");
        }
    }
}
