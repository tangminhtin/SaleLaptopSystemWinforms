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
    public partial class CateInsAndUp : DevExpress.XtraEditors.XtraForm
    {
        Category category;
        bool isIsert;
        SaleLaptopSystemEntities db = new SaleLaptopSystemEntities();
        public CateInsAndUp(bool isIsert, Category category)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            this.category = category;
            this.isIsert = isIsert;

            if (isIsert)
            {
                lbltitle.Text = "Insert";
                clear();
            }
            else
            {
                lbltitle.Text = "Update";
                txtName.Text = category.Name;
                cbbActive.Checked = category.Active == true ? true : false;
            }
        }

        public void clear()
        {
            txtName.Text = "";
            cbbActive.Checked = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String name = txtName.Text.Trim();

            if (name == "")
                MessageBox.Show("Please input textfield");

            else
            {
                if (isIsert)
                {
                    db.Categories.Add(new Category(name, cbbActive.Checked == true ? true : false));
                    db.SaveChanges();
                }
                else
                {
                    int id = Convert.ToInt32(this.category.ID);
                    Category ECate = db.Categories.FirstOrDefault(c => c.ID == id);
                    ECate.Name = txtName.Text;//update them thang moi
                    ECate.Active = cbbActive.Checked == true ? true : false;
                    db.SaveChanges();
                }
                BrandLoad form = new BrandLoad();
                form.Visible = true;
                form.load();
                this.Visible = false;
            }
                         
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BrandLoad form = new BrandLoad();
            form.Visible = true;
            form.load();
            this.Visible = false;
        }
    }
}