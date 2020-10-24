using PRN292_LapTopSaleSystemWF_Group4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN292_LapTopSaleSystemWF_Group4.DAO
{
    class BrandDAO
    {
        SaleLaptopSystemEntities db = new SaleLaptopSystemEntities();

        public Boolean addBrand(String name, String image, Boolean active)
        {
            try
            {
                Brand brand = new Brand
                {
                    Name = name,
                    Image = image,
                    Active = active
                };

                db.Brands.Add(brand);
                db.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public Boolean update(int id, String name, String image, Boolean active)
        {
            try
            {
                /*Brand brand = new Brand
                {
                    Name = name,
                    Image = image,
                    Active = true
                };*/

                var brands = db.Brands.Where(a => a.ID == id);

                foreach(var brand in brands)
                {
                    brand.Name = name;
                    brand.Image = image;
                    brand.Active = active;

                    db.Brands.Add(brand);
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
