using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyTrungTam.Models;

namespace QuanLyTrungTam.Areas.Admin.Controllers
{
    public class SubjectController : Controller
    {
        QLTTEntitiesAdmin model = new QLTTEntitiesAdmin();
        // GET: Admin/Subject
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
            var data = model.Subjects.Where(x => x.IsDelete == false).ToList();
            return Json(new { data, JsonRequestBehavior.AllowGet });
        }

        [HttpPost]
        public ActionResult Add(Subject subject)
        {
            bool result = false;
            var item = model.Branches.SingleOrDefault(x => x.Name == subject.Name);
            if (item == null)
            {
                subject.IsDelete = false;
                subject.CreateTime = DateTime.Now;
                model.Subjects.Add(subject);
                int k = model.SaveChanges();
                if (k == 1)
                    result = true;
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}