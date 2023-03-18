using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductManaged.DataAccess.Abstract;
using ProductManaged.DataAccess.Repositories;
using ProductManaged.Entities.Concrete;

namespace ProductManaged.DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : GenericRepository<Customer,DbEntityContext>,ICustomerDal
    {
        public List<Customer> GetCustomerListWithJob()
        {
            using (DbEntityContext context = new DbEntityContext())
            {
                return context.Customers.Include(c => c.Job).ToList();
            }
        }
    }
}
