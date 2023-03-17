using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using ProductManaged.Entities.Concrete;

namespace ProductManaged.Business.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.CustomerName).NotEmpty().WithMessage("Müşteri adı alanı boş geçilemez...");
            RuleFor(c => c.CustomerName).MinimumLength(6).WithMessage("Müşteri adı 6 karakter az olamaz...");
            RuleFor(c => c.CustomerCity).NotEmpty().WithMessage("Şehir adı alanı boş geçilemez...");
            RuleFor(c => c.CustomerCity).MinimumLength(3).WithMessage("Şehir adı 3 karakterden az olamaz...");
            RuleFor(c => c.JobId).NotEmpty().WithMessage("Meslek alanı boş geçilemez...");
            RuleFor(c => c.JobId).GreaterThan(0).WithMessage("Geçerli bir meslek giriniz...");
        }
    }
}
