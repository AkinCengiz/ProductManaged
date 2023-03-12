using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManaged.DataAccess.Abstract;
using ProductManaged.DataAccess.Repositories;
using ProductManaged.Entities.Concrete;

namespace ProductManaged.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : GenericRepository<Product,DbEntityContext>,IProductDal
    {
    }
}
