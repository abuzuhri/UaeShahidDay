using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UaeShahidDay.Service.UnitOfWork;

namespace UaeShahidDay.Web.Controllers
{
    public class HomeController : Controller
    {
        SetupUnitOfWork setupService = new SetupUnitOfWork();

        public ActionResult Index()
        {
            var list = setupService.getShahidList();

            return View(list);
        }
        
    }
}