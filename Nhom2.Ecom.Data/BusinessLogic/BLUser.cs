using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nhom2.Ecom.Data.BusinessLogic
{
    public class BLUser
    {
        public static bool Exists(string userName)
        {
            using (Database.DatabaseContext db = new Database.DatabaseContext())
            {
                return db.Users.Any(x => x.UserName.ToLower() == userName.ToLower());
            }
        }
    }
}
