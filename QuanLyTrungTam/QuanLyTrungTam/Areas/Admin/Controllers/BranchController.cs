using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyTrungTam.Models;

namespace QuanLyTrungTam.Areas.Admin.Controllers
{
    public class BranchController : Controller
    {
        QLTTEntitiesAdmin model = new QLTTEntitiesAdmin();
        // GET: Admin/Branch
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetAll()
        {
            var data = model.Branches.Where(x => x.IsDelete == false).ToList();
            return Json(new { data, JsonRequestBehavior.AllowGet });
        }

        [HttpPost]
        public ActionResult Add(Branch branch)
        {
            bool result = false;
            var item = model.Branches.SingleOrDefault(x => x.Name == branch.Name);
            if (item == null)
            {
                branch.IsDelete = false;
                branch.CreateTime = DateTime.Now;
                model.Branches.Add(branch);
                int k = model.SaveChanges();
                if (k == 1)
                    result = true;
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}