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
using DevExpress.LookAndFeel;
using PRN292_LapTopSaleSystemWF_Group4.Model;
using PRN292_LapTopSaleSystemWF_Group4.DAO;

namespace PRN292_LapTopSaleSystemWF_Group4.View
{
    public partial class frmBrand : DevExpress.XtraEditors.XtraForm
    {
        BrandDAO brandDAO = new BrandDAO();
        SaleLaptopSystemEntities db = new SaleLaptopSystemEntities();
        Boolean isAdd = false;
        public frmBrand()
        {
            InitializeComponent();
            this.CenterToScreen();
            brandsBindingSource1.DataSource = db.Brands.ToList();
        }
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            brandsBindingSource1.AddNew();
            isAdd = true;
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Do you want to delete", "Infor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtId.Text.Trim());
                if (brandDAO.Delete(id))
                {
                    XtraMessageBox.Show("Delete successful");
                    brandsBindingSource1.DataSource = db.Brands.ToList();
                }
                else
                {
                    XtraMessageBox.Show("Can not delete");
                }
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isAdd)
            {
                String name = txtName.Text.Trim();
                String image = txtImage.Text.Trim();
                int activeint = ckCheck.Checked ? 1 : 0;
                Boolean active = activeint == 1 ? true : false;
                if (brandDAO.addBrand(name, image, active))
                {
                    brandsBindingSource1.DataSource = db.Brands.ToList();
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
                String image = txtImage.Text.Trim();
                int activeint = ckCheck.Checked ? 1 : 0;
                Boolean active = activeint == 1 ? true : false;
                if (brandDAO.update(id, name, image, active))
                {
                    brandsBindingSource1.DataSource = db.Brands.ToList();
                }
                else
                {
                    MessageBox.Show("loi");
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            brandsBindingSource1.DataSource = brandDAO.search(txtSearch.Text.Trim());
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            brandsBindingSource1.DataSource = db.Brands.ToList();
        }
    }
}