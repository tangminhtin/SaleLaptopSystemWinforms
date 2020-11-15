using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PRN292_LapTopSaleSystemWF_Group4.Model;

namespace PRN292_LapTopSaleSystemWF_Group4.View
{
    public partial class ProductDetailInsAndUp : DevExpress.XtraEditors.XtraForm
    {
        ProductDetail detail;
        bool isIsert;
        ProductDetailLoad form;
        SaleLaptopSystemEntities db = new SaleLaptopSystemEntities();
        public ProductDetailInsAndUp(bool isIsert, ProductDetail detail, ProductDetailLoad form)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            this.detail = detail;
            this.isIsert = true;
            this.form = form;

            if (isIsert)
            {
                title.Text = "Insert Product detail";
                clear();
            }
            else
            {
                title.Text = "Update brand";
                txtProcess.Text = detail.Processor;
                txtRAM.Text = detail.RAM;
                txtScreen.Text = detail.Screen;
                txtStorage.Text = detail.Storage;
                txtGraphic.Text = detail.Graphic;
                txtSize.Text = detail.Size;
                txtOS.Text = detail.OS;
                txtVideo.Text = detail.Video;
                txtConnection.Text = detail.Connection;
                txtKeyboard.Text = detail.Keyboard;
                txtBattery.Text = detail.Battery;
            }
        }

        public void clear()
        {
            txtProcess.Text = "";
            txtRAM.Text = "";
            txtScreen.Text = "";
            txtStorage.Text = "";
            txtGraphic.Text = "";
            txtSize.Text = "";
            txtOS.Text = "";
            txtVideo.Text = "";
            txtConnection.Text = "";
            txtBattery.Text = "";
            txtKeyboard.Text = "";
        }

        public ProductDetail getProductDetail()
        {
            String processor = txtProcess.Text.Trim();
            String RAM = txtRAM.Text.Trim();
            String screen = txtScreen.Text.Trim();
            String storage = txtStorage.Text.Trim();
            String graphic = txtGraphic.Text.Trim();
            String size = txtSize.Text.Trim();
            String os = txtOS.Text.Trim();
            String video = txtVideo.Text.Trim();
            String connection = txtConnection.Text.Trim();
            String battery = txtBattery.Text.Trim();
            String keyboard = txtKeyboard.Text.Trim();

            if (processor == "" || RAM == "" || screen == "" || storage == "" || graphic == "" || size == "" || os == "" || video == "" || connection == "" || battery == "" || keyboard == "")
                MessageBox.Show("Please input textfield");
            else
            {
                return new ProductDetail(processor, RAM, screen, storage, graphic, size, os, video, connection, keyboard, battery);
            }
            return null;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            form.Visible = true;
            this.Visible = false;
            form.load();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (getProductDetail() != null)
            {
                if (isIsert)
                {
                    db.ProductDetails.Add(getProductDetail());
                    db.SaveChanges();
                }
                else
                {
                    int id = Convert.ToInt32(this.detail.ID);
                    ProductDetail productDetail = db.ProductDetails.FirstOrDefault(b => b.ID == id);
                    
                    db.SaveChanges();//van con update loi
                }
                form.Visible = true;
                this.Visible = false;
                form.load();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}