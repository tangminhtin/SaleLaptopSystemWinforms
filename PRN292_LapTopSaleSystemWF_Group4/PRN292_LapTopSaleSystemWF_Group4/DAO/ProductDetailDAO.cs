using PRN292_LapTopSaleSystemWF_Group4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN292_LapTopSaleSystemWF_Group4.DAO
{
    class ProductDetailDAO
    {
        SaleLaptopSystemEntities db = new SaleLaptopSystemEntities();

        public Boolean add(String processor, String RAM, String screen, String storage, String graphic, String size, String os, String video, String connection, String keyboard, String battery)
        {
            try
            {
                ProductDetail detail = new ProductDetail
                {
                    Processor = processor,
                    RAM = RAM,
                    Screen = screen,
                    Storage = storage,
                    Graphic = graphic,
                    Size = size,
                    OS = os,
                    Video = video,
                    Connection = connection,
                    Keyboard = keyboard,
                    Battery = battery
                };
                db.ProductDetails.Add(detail);
                db.SaveChanges();
                return true;
            }catch(Exception e)
            {
                return false;
            }
        }

        public Boolean update(int id, String processor, String RAM, String screen, String storage, String graphic, String size, String os, String video, String connection, String keyboard, String battery)
        {
            try
            {
                ProductDetail detail = (ProductDetail)db.ProductDetails.Where(p => p.ID == id);
                detail = new ProductDetail
                {
                    Processor = processor,
                    RAM = RAM,
                    Screen = screen,
                    Storage = storage,
                    Graphic = graphic,
                    Size = size,
                    OS = os,
                    Video = video,
                    Connection = connection,
                    Keyboard = keyboard,
                    Battery = battery
                };
                db.ProductDetails.Add(detail);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public Boolean delete(int id)
        {
            try
            {
                ProductDetail detail = (ProductDetail)db.ProductDetails.Where(p => p.ID == id);
                db.ProductDetails.Remove(detail);
                db.SaveChanges();
                return true;
            }catch(Exception e)
            {
                return false;
            }
            
        }
    }
}
