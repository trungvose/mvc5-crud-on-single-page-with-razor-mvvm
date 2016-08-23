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
            vm.HandleRequest();
            ModelState.Clear();

            return View(vm);
        }

    }
}