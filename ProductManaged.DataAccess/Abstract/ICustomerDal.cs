using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManaged.Entities.Concrete;

namespace ProductManaged.DataAccess.Abstract
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {
        List<Customer> GetCustomerListWithJob();
    }
}
