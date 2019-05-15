using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyTrungTam.Models;
namespace QuanLyTrungTam.Areas.Admin.Controllers
{
    public class ExamController : Controller
    {

        QLTTEntitiesAdmin model = new QLTTEntitiesAdmin();
        // GET: Admin/Exam
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
            var data = model.Exams.Where(x => x.IsDelete == false).ToList();
            return Json(new { data, JsonRequestBehavior.AllowGet });
        }

        [HttpPost]
        public ActionResult Add(Exam exam)
        {
            bool result = false;
                exam.IsDelete = false;
                exam.CreateTime = DateTime.Now;
                model.Exams.Add(exam);
                int k = model.SaveChanges();
                if (k == 1)
                    result = true;
            
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Delete(int? id)
        {
            bool result = false;
            var item = model.Exams.SingleOrDefault(x => x.ID == id);
            if (item != null)
            {
                item.IsDelete = true;
                int k = model.SaveChanges();
                if (k == 1)
                    result = true;
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}