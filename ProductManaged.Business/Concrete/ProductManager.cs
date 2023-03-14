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
            _productDal.Add(entity);
        }

        public void TUpdate(Product entity)
        {
            _productDal.Update(entity);
        }

        public void TDelete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public List<Product> TGetList()
        {
            return _productDal.GetAll();
        }

        public Product TGetById(int id)
        {
            return _productDal.GetAll().Where(p => p.ProductId == id).SingleOrDefault();
        }
    }
}
