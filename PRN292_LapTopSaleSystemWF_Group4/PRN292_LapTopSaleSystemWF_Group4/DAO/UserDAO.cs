using PRN292_LapTopSaleSystemWF_Group4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN292_LapTopSaleSystemWF_Group4.DAO
{
    public class UserDAO
    {
        User user = new User();

        public User login(String email, String password)
        {
            PRN292_LapTopSaleSystem_Group4Entities db = new PRN292_LapTopSaleSystem_Group4Entities();
            var users = db.Users.Where(u => u.email == email && u.password == password);
            foreach (User u in users)
            {
                return u;
            }
            return null;
        }
    }
}
