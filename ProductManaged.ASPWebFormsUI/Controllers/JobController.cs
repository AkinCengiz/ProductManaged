using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using ProductManaged.Business.Concrete;
using ProductManaged.Business.FluentValidation;
using ProductManaged.DataAccess.Concrete.EntityFramework;
using ProductManaged.Entities.Concrete;

namespace ProductManaged.ASPWebFormsUI.Controllers
{
    public class JobController : Controller
    {
        private JobManager jobManager = new JobManager(new EfJobDal());
        public IActionResult Index()
        {
            var jobs = jobManager.TGetList();
            return View(jobs);
        }

        [HttpGet]
        public IActionResult AddJob()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddJob(Job job)
        {
            JobValidator jobValidator = new JobValidator();
            ValidationResult validationResult = jobValidator.Validate(job);
            if (validationResult.IsValid)
            {
                jobManager.TAdd(job);
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
        public IActionResult DeleteJob(int id)
        {
            Job job = jobManager.TGetById(id);
            return View(job);
        }

        [HttpPost]
        public IActionResult DeleteJob(Job job)
        {
            jobManager.TDelete(job);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateJob(int id)
        {
            Job job = jobManager.TGetById(id);
            return View(job);
        }

        [HttpPost]
        public IActionResult UpdateJob(Job job)
        {
            jobManager.TUpdate(job);
            return RedirectToAction("Index");
        }
    }
}
