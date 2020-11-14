using PRN292_LapTopSaleSystemWF_Group4.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PRN292_LapTopSaleSystemWF_Group4.DAO
{
    class BrandDAO
    {
        SaleLaptopSystemEntities db = new SaleLaptopSystemEntities();

        public Boolean addBrand(String name, String image, Boolean active)
        {
            try
            {
                Brand brand = new Brand(name,image,active);
                db.Brands.Add(brand);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public Boolean update(int id, String name, String image, Boolean active)
        {
            try
            {
                Brand brand = db.Brands.FirstOrDefault(a => a.ID == id);
                brand.Name = name;
                brand.Image = image;
                brand.Active = active;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public Boolean Delete(int id)
        {
            bool check = false;
            var brands = db.Brands.Where(a => a.ID == id);
            foreach (var brand in brands)
            {
                if (brand.ID==id)
                {
                    db.Brands.Remove(brand);
                    check = true;
                }
            }
            db.SaveChanges();

            return check;
        }

    }
}
