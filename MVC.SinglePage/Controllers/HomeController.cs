using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.SinglePage.Data;

namespace MVC.SinglePage.Controllers
{
    public class HomeController : Controller
    {
        TrainingProductViewModel vm = new TrainingProductViewModel();

        public ActionResult Index()
        {
            vm.HandleRequest();

            return View(vm);
        }

        [HttpPost]
        public ActionResult Index(TrainingProductViewModel vm)
        {
            vm.IsValid = ModelState.IsValid;
            vm.HandleRequest();
            if (vm.IsValid)
            {
                ModelState.Clear();
            }
            else
            {
                foreach (KeyValuePair<string, string> item in vm.ValidationErrors)
                {
                    ModelState.AddModelError(item.Key, item.Value);
                }
            }
            
            return View(vm);
        }

    }
}