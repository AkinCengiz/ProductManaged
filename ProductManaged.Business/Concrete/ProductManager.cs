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
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void TAdd(Product entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Product entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> TGetList()
        {
            throw new NotImplementedException();
        }

        public Product TGetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
