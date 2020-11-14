using DevExpress.Data.ODataLinq.Helpers;
using PRN292_LapTopSaleSystemWF_Group4.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN292_LapTopSaleSystemWF_Group4.DAO
{
    class productDAO
    {
        SaleLaptopSystemEntities db = new SaleLaptopSystemEntities();

        public bool addProduct(string name, double price, double discount, string description, string features, bool active, int brandId, int categoryId, int productId)
        {
            try
            {
                Product product = new Product(name, price, discount, description, features, active, brandId, categoryId, productId);
                db.Products.Add(product);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public Boolean deleteProduct(int id)
        {
            bool check = false;
            var products = db.Products.Where(a => a.ID == id);
            foreach (var product in products)
            {

                if (product.ID == id)
                {
                    db.Products.Remove(product);
                    check = true;
                }
            }
            db.SaveChanges();
            return check;
        }

        public bool updateProduct(int id, string name, double price, double discount, string description, string features, bool active, int brandId, int categoryId, int productId)
        {
            try
            {
                Product product = db.Products.FirstOrDefault(a => a.ID == id);
                product.Name = name;
                product.Price = price;
                product.Discount = discount;
                product.Description = description;
                product.Features = features;
                product.Active = active;
                product.BrandID = brandId;
                product.CategoryID = categoryId;
                product.ProductDetailID = productId;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}

