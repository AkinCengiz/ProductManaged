using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using ProductManaged.Entities.Concrete;

namespace ProductManaged.Business.FluentValidation
{
    public class JobValidator : AbstractValidator<Job>
    {
        public JobValidator()
        {
            RuleFor(j => j.JobName).NotEmpty().WithMessage("Meslek adı geçersiz...");
            RuleFor(j => j.JobName).MinimumLength(3).WithMessage("Meslek adı en az 3 karakterden oluşmalıdır...");
        }
    }
}
