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
    public partial class CateInsAndUp : DevExpress.XtraEditors.XtraForm
    {
        Category category;
        bool isIsert;
        CategoryLoad form;
        SaleLaptopSystemEntities db = new SaleLaptopSystemEntities();
        public CateInsAndUp(bool isIsert, Category category, CategoryLoad form)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            this.category = category;
            this.isIsert = true;
            this.form = form;

            if (isIsert)
            {
                lbltitle.Text = "Insert category";
                clear();
            }
            else
            {
                lbltitle.Text = "Update category";
                txtName.Text = category.Name;
                cbbActive.Checked = category.Active == true ? true : false;
            }
        }

        public void clear()
        {
            txtName.Text = "";
            cbbActive.Checked = false;
        }

        public Category getCate()
        {
            String name = txtName.Text.Trim();
            if (name == "")
                MessageBox.Show("Please input textfield");
                
            else
            {
                return new Category(name, cbbActive.Checked);
            }
            return null;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (getCate() != null)
            {
                if (isIsert)
                {
                    db.Categories.Add(getCate());
                    db.SaveChanges();
                }
                else
                {
                    int id = Convert.ToInt32(this.category.ID);
                    Category ECate = db.Categories.FirstOrDefault(c => c.ID == id);
                    ECate.Name = txtName.Text;//update them thang moi
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
    }
}