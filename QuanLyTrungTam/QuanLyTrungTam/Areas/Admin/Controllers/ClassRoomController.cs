using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyTrungTam.Models;

namespace QuanLyTrungTam.Areas.Admin.Controllers
{
    public class ClassRoomController : Controller
    {
        QLTTEntitiesAdmin model = new QLTTEntitiesAdmin();
        // GET: Admin/ClassRoom
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
            var data = model.Rooms.Where(x => x.IsDelete == false).ToList();
            return Json(new { data, JsonRequestBehavior.AllowGet });
        }

        [HttpPost]
        public ActionResult Add(Room room)
        {
            bool result = false;
            var item = model.Rooms.SingleOrDefault(x => x.Name == room.Name);
            if (item == null)
            {
                room.IsDelete = false;
                room.CreateTime = DateTime.Now;
                model.Rooms.Add(room);
                int k = model.SaveChanges();
                if (k == 1)
                    result = true;
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}