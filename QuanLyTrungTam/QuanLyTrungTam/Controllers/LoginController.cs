using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyTrungTam.Models;

namespace QuanLyTrungTam.Controllers
{
    public class LoginController : Controller
    {
        QLTTEntitiesAdmin model = new QLTTEntitiesAdmin();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Login(User user)
        {
            int result = 0;
            var item = model.Users.SingleOrDefault(x => x.UserName == user.UserName && x.PassWord==user.PassWord);
            if(item !=null)
            {
                
                    Session["UserName"] = item.UserName;
                    var ex = model.MemberInformations.SingleOrDefault(x => x.ID == item.IDTT);
                var role = model.Roles.SingleOrDefault(x => x.ID == ex.IDRole);
                if(role.GiangVien==true)
                    Session["ID"] = item.IDTT;
                if (role.HocVien==true)
                {
                    Session["ID"] = item.IDTT;
                    result = 1;
                }
                else
                    result = 2;

            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
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

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
