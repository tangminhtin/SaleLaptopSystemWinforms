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
using PRN292_LapTopSaleSystemWF_Group4.DAO;

namespace PRN292_LapTopSaleSystemWF_Group4.View
{
    public partial class frmCategory : DevExpress.XtraEditors.XtraForm 
    {
        CategoryDAO categoryDao = new CategoryDAO();
        SaleLaptopSystemEntities db = new SaleLaptopSystemEntities();
        bool isAdd = false;
        bool isDelete = false;
        bool isUpdate = true;
        public frmCategory()
        {
            InitializeComponent();
            categoriesBindingSource1.DataSource = db.Categories.ToList();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            categoriesBindingSource1.AddNew();
            isAdd = false;
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Do you want to delete", "Infor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtId.Text.Trim());
                if (categoryDao.delete(id))
                {
                    XtraMessageBox.Show(" delete clmm");
                    categoriesBindingSource1.DataSource = db.Categories.ToList();
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
                int activeint = ckCheck.Checked ? 1 : 0;
                Boolean active = activeint == 1 ? true : false;
                if (categoryDao.addCategory(name,active))
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
                int activeint = ckCheck.Checked ? 1 : 0;
                Boolean active = activeint == 1 ? true : false;
                if (categoryDao.update(id, name, active))
                {
                    categoriesBindingSource1.DataSource = db.Categories.ToList();
                }
                else
                {
                    MessageBox.Show("loi");
                }
                isUpdate = false;
            }

        }
    }
}