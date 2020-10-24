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
            SaleLaptopSystemEntities db = new SaleLaptopSystemEntities();
            var users = db.Users.Where(u => u.Email == email && u.Password == password);
            foreach (User u in users)
            {
                return u;
            }
            return null;
        }

        public void registration(String email, String password, String fullname, String address, String phone, String role, String image)
        {

        }
    }
}
