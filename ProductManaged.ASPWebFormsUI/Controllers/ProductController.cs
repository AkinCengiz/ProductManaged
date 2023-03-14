using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using ProductManaged.Business.Concrete;
using ProductManaged.Business.FluentValidation;
using ProductManaged.DataAccess.Concrete.EntityFramework;
using ProductManaged.Entities.Concrete;

namespace ProductManaged.ASPWebFormsUI.Controllers
{
    public class ProductController : Controller
    {
        private ProductManager productManager = new ProductManager(new EfProductDal());
        public IActionResult Index()
        {
            var products = productManager.TGetList();
            return View(products);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            ProductValidator productValidator = new ProductValidator();
            ValidationResult validationResult = productValidator.Validate(product);
            if (validationResult.IsValid)
            {
                productManager.TAdd(product);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult DeleteProduct(int id)
        {
            Product product = productManager.TGetById(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult DeleteProduct(Product product)
        {
            productManager.TDelete(product);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            Product product = productManager.TGetById(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            productManager.TUpdate(product);
            return RedirectToAction("Index");
        }
        
    }
}
