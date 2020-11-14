﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using PRN292_LapTopSaleSystemWF_Group4.Model;
using PRN292_LapTopSaleSystemWF_Group4.DAO;
using DevExpress.XtraEditors;

namespace PRN292_LapTopSaleSystemWF_Group4.View
{
    public partial class CategoriesLoad : UserControl
    {
        SaleLaptopSystemEntities db = new SaleLaptopSystemEntities();
        CategoryDAO categoryDao = new CategoryDAO();  
        bool isAdd = false;
        public CategoriesLoad()
        {
            InitializeComponent();
            categoriesBindingSource1.DataSource = db.Categories.ToList();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            categoriesBindingSource1.AddNew();
            isAdd = true;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Do you want to delete", "Infor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtId.Text.Trim());
                if (categoryDao.delete(id))
                {
                    XtraMessageBox.Show("Delete Success");
                    categoriesBindingSource1.DataSource = db.Categories.ToList();
                }
                else
                {
                    XtraMessageBox.Show("Can not delete");
                }
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isAdd)
            {
                String name = txtName.Text.Trim();
                int activeint = cbCheck.Checked ? 1 : 0;
                Boolean active = activeint == 1 ? true : false;
                if (categoryDao.addCategory(name, active))
                {
                    categoriesBindingSource1.DataSource = db.Categories.ToList();
                }
                else
                {
                    MessageBox.Show("loi");
                }
                isAdd = false;
            }

            else
            {
                int id = Convert.ToInt32(txtId.Text.Trim());
                String name = txtName.Text.Trim();
                int activeint = cbCheck.Checked ? 1 : 0;
                Boolean active = activeint == 1 ? true : false;
                if (categoryDao.update(id, name, active))
                {
                    categoriesBindingSource1.DataSource = db.Categories.ToList();
                }
                else
                {
                    MessageBox.Show("loi");
                }
            }

        }
    }
}
