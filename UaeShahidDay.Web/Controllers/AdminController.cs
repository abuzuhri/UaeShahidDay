using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UaeShahidDay.Service.UnitOfWork;

namespace UaeShahidDay.Web.Controllers
{
    public class AdminController : Controller
    {
        SetupUnitOfWork setupService = new SetupUnitOfWork();

        // GET: Admin
        public ActionResult Index()
        {
            var list = setupService.getShahidList();

            return View(list);
        }

        public ActionResult Add()
        {
            return View();
        }


        public ActionResult Delete(long ID)
        {
            setupService.DeleteShahid(ID);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult AddEditSave(string Name)
        {
            bool result = true;
            try
            {
                if (Request.Files.Count > 0)
                {
                    var file = Request.Files[0];

                    if (file != null && file.ContentLength > 0)
                    {
                        
                        var fileName = Path.GetFileName(file.FileName);
                        var path = Path.Combine(Server.MapPath("~/Images/"), fileName);
                        file.SaveAs(path);
                        setupService.AddShahid(Name, fileName);
                    }
                }


            }
            catch (Exception ex)
            {
                result = false;
            }

            return View("Add");

        }

    }
}