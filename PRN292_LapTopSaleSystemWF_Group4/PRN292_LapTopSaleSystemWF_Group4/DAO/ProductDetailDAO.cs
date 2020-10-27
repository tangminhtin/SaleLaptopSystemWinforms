using PRN292_LapTopSaleSystemWF_Group4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
                ProductDetail detail = new ProductDetail(processor, RAM, screen, storage, graphic, size, os, video, connection, keyboard, battery);
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
                ProductDetail detail = (from d in db.ProductDetails
                                        where d.ID == id
                                        select d).First();
                detail.Processor = processor;
                detail.RAM = RAM;
                detail.Screen = screen;
                detail.Storage = storage;
                detail.Graphic = graphic;
                detail.Size = size;
                detail.OS = os;
                detail.Video = video;
                detail.Connection = connection;
                detail.Keyboard = keyboard;
                detail.Battery = battery;

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
                ProductDetail detail = db.ProductDetails.FirstOrDefault(p => p.ID == id);
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
