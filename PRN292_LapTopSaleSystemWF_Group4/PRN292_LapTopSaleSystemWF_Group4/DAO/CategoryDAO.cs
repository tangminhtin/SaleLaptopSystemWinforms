using PRN292_LapTopSaleSystemWF_Group4.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PRN292_LapTopSaleSystemWF_Group4.DAO
{
    class CategoryDAO
    {

        SaleLaptopSystemEntities db = new SaleLaptopSystemEntities();

        
        public Boolean addCategory(string name, bool active)
        {
            try
            {
                Category category = new Category(name, active);
                db.Categories.Add(category);
                db.SaveChanges();
                return true;
            }catch(Exception e)
            {
                return false;
            } 
        } 
        public Boolean update(int id, string name, Boolean active)
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
        public Boolean delete(int id)
        {
            bool check = false;
            var categories = db.Categories.Where(a => a.ID == id);
            foreach(var category in categories)
            {
                if(category.ID == id)
                {
                    db.Categories.Remove(category);
                    check = true;
                }
            }
            db.SaveChanges();
            return check;
        }
    }
}
