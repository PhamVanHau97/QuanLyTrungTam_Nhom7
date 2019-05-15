using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Model.Freamwork;
using System.Web.Security;
namespace Model
{
    public class UserModel
    {
        QLTTEntities db = new QLTTEntities();
        public UserModel()
        {
           
        }

        public bool Login(string user, string password)
        {
            var res = db.Users.SingleOrDefault(x => x.UserName == user);
            if(res!=null)
            {
                if (res.PassWord == password)
                {
                    Session[]
                    return true;
                }
                    
            }
            return false;
        }
    }
}
