using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManaged.Business.Abstract;
using ProductManaged.DataAccess.Abstract;
using ProductManaged.Entities.Concrete;

namespace ProductManaged.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void TAdd(Customer entity)
        {
            _customerDal.Add(entity);
        }

        public void TUpdate(Customer entity)
        {
            _customerDal.Update(entity);
        }

        public void TDelete(Customer entity)
        {
            _customerDal.Delete(entity);
        }

        public List<Customer> TGetList()
        {
            return _customerDal.GetAll();
        }

        public Customer TGetById(int id)
        {
            return _customerDal.GetAll().Where(c => c.CustomerId == id).SingleOrDefault();
        }
    }
}
