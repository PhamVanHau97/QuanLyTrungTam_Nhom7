using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyTrungTam.Models;
using QuanLyTrungTam.Areas.Admin.Models;

namespace QuanLyTrungTam.Areas.Admin.Controllers
{
    public class RoleController : Controller
    {
        // GET: Admin/Role
        QLTTEntitiesAdmin model = new QLTTEntitiesAdmin();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult GetAll()
        {
            List<RoleList> data = new List<RoleList>();
            var data1 = model.Roles.Where(x => x.IsDelete == false).ToList();
            foreach(Role k in data1)
            {
                RoleList role = new RoleList();
                role.ID = k.ID;
                role.Name = k.Name;
                string r = "Học Viên";
                if (k.GiangVien == true)
                    r = "GiangVien";
                else if (k.GiamDoc==true)
                    r = "GiamDoc";
                else if (k.Admin ==true)
                    r = "Admin";
                else if (k.KeToan == true)
                    r = "KeToan";
                role.Role = r;
                data.Add(role);
            }
            return Json(new { data, JsonRequestBehavior.AllowGet });
        }
    }
}