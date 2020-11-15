﻿using System;
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
    public partial class BrandInsAndUp : DevExpress.XtraEditors.XtraForm
    {
        Brand brand;
        bool isIsert;
        BrandLoad form;
        SaleLaptopSystemEntities db = new SaleLaptopSystemEntities();
        public BrandInsAndUp(bool isIsert, Brand brand, BrandLoad form)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            this.brand = brand;
            this.isIsert = true;
            this.form = form;

            if (isIsert)
            {
                lbltitle.Text = "Insert brand";
                clear();
            }
            else
            {
                lbltitle.Text = "Update brand";
                txtName.Text = brand.Name;
                txtImage.Text = brand.Image;
                cbbActive.Checked = brand.Active == true ? true : false;
            }
        }

        public void clear()
        {
            txtName.Text = "";
            txtImage.Text = "";
            cbbActive.Checked = false;
        }

        public Brand getBrand()
        {
            String name = txtName.Text.Trim();
            String image = txtImage.Text.Trim();
            if (name == "" || image == "")
                MessageBox.Show("Please input textfield");
            else
            {
                return new Brand(name, "..\\SaleLaptopSystem\\SaleLaptopSystem\\SaleLaptopSystem\\img\\Brands_img\\" + image, cbbActive.Checked);
            }
            return null;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (getBrand() != null)
            {
                if (isIsert)
                {
                    db.Brands.Add(getBrand());
                    db.SaveChanges();
                }
                else
                {
                    int id = Convert.ToInt32(this.brand.ID);
                    Brand EBrand = db.Brands.FirstOrDefault(b => b.ID == id);
                    EBrand.Name = getBrand().Name;
                    EBrand.Image = getBrand().Image;
                    db.SaveChanges();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            form.Visible = true;
            this.Visible = false;
            form.load();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            txtImage.Text = openFileDialog.SafeFileName;
        }
    }
}