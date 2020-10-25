using PRN292_LapTopSaleSystemWF_Group4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN292_LapTopSaleSystemWF_Group4.DAO
{
    class CategoryDAO
    {

        SaleLaptopSystemEntities db = new SaleLaptopSystemEntities();

        public Boolean addCategory(String name, Boolean active)
        {
            try
            {
                Category category = new Category(name,active);
                db.Categories.Add(category);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public Boolean update(int id, String name, Boolean active)
        {
            try
            {
                var categorys = db.Categories.Where(a => a.ID == id);

                foreach (var category in categorys)
                {
                    category.Name = name;
                    category.Active = active;
                    db.Categories.Add(category);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
