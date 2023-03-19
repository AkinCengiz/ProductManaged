using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using ProductManaged.Entities.Abstract;

namespace ProductManaged.Entities.Concrete
{
    public class AppRole : IdentityRole<int>
    {
    }
}
