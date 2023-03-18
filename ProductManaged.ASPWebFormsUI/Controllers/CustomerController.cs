using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProductManaged.Business.Concrete;
using ProductManaged.Business.FluentValidation;
using ProductManaged.DataAccess.Concrete.EntityFramework;
using ProductManaged.Entities.Concrete;

namespace ProductManaged.ASPWebFormsUI.Controllers
{
    public class CustomerController : Controller
    {
        private CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        private JobManager jobManager = new JobManager(new EfJobDal());
        public IActionResult Index()
        {
            var customers = customerManager.GetCustomersListWithJob();
            return View(customers);
        }

        [HttpGet]
        public IActionResult AddCustomer()
        {
            List<SelectListItem> customerJobs = (from j in jobManager.TGetList()
                select new SelectListItem
                {
                    Text = j.JobName,
                    Value = j.JobId.ToString()
                }).ToList();
            ViewBag.v = customerJobs;
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            CustomerValidator customerValidator = new CustomerValidator();
            ValidationResult validationResult = customerValidator.Validate(customer);
            if (validationResult.IsValid)
            {
                customerManager.TAdd(customer);
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
        public IActionResult DeleteCustomer(int id)
        {
            Customer customer = customerManager.TGetById(id);
            return View(customer);
        }

        [HttpPost]
        public IActionResult DeleteCustomer(Customer customer)
        {
            customerManager.TDelete(customer);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCustomer(int id)
        {
            List<SelectListItem> customerJobs = (from j in jobManager.TGetList()
                select new SelectListItem
                {
                    Text = j.JobName,
                    Value = j.JobId.ToString()
                }).ToList();
            ViewBag.v = customerJobs;
            Customer customer = customerManager.TGetById(id);
            return View(customer);
        }

        [HttpPost]
        public IActionResult UpdateCustomer(Customer customer)
        {
            customerManager.TUpdate(customer);
            return RedirectToAction("Index");
        }
    }
}
