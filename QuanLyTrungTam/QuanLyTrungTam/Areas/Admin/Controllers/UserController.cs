using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyTrungTam.Models;

namespace QuanLyTrungTam.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        QLTTEntitiesAdmin model = new QLTTEntitiesAdmin();
        // GET: Admin/User
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetAll()
        {
            var data = model.Users.Where(x=>x.IsDelete==false).ToList();
            return Json(new { data, JsonRequestBehavior.AllowGet });
        }
        // GET: Admin/User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/User/Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(User user)
        {
            bool result = false;
            var item = model.Users.SingleOrDefault(x => x.UserName == user.UserName );
            if (item == null)
            {
                user.IsDelete = false;
                user.CreateTime = DateTime.Now;
                model.Users.Add(user);
                int k=model.SaveChanges();
                if(k==1)
                    result = true;
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        // POST: Admin/User/Create

        // GET: Admin/User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        
        [HttpPost]
        public ActionResult Delete(int? id)
        {
            bool result = false;
            var item = model.Users.SingleOrDefault(x => x.ID ==id);
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
