using System;
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
    public partial class BrandLoad : UserControl
    {
        SaleLaptopSystemEntities db = new SaleLaptopSystemEntities();
        BrandDAO brandDAO = new BrandDAO();
        Boolean isAdd = false;
        public BrandLoad()
        {
            InitializeComponent();
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

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isAdd)
            {
                String name = txtName.Text.Trim();
                String image = txtImage.Text.Trim();
                int activeint = cbCheck.Checked ? 1 : 0;
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
                int activeint = cbCheck.Checked ? 1 : 0;
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
    }
}
