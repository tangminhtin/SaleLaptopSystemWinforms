using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRN292_LapTopSaleSystemWF_Group4.Model;
using PRN292_LapTopSaleSystemWF_Group4.DAO;
using DevExpress.XtraEditors;

namespace PRN292_LapTopSaleSystemWF_Group4.View
{
    public partial class ProductLoad : UserControl
    {
        SaleLaptopSystemEntities db = new SaleLaptopSystemEntities();
        productDAO produc = new productDAO();
        bool isAdd = false;
        public ProductLoad()
        {
            InitializeComponent();
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            productsBindingSource1.DataSource = db.Products.ToList();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            productsBindingSource1.AddNew();
            isAdd = true;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtID.Text = txtName.Text = txtPrice.Text = txtDescount.Text = txtDescripttion.Text = txtFeatures.Text = ckActive.Text = txtBrandID.Text = txtCategoryID.Text = txtProductDetailID.Text = "";
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isAdd)
            {
                string name = txtName.Text.Trim();
                double price = Convert.ToDouble(txtPrice.Text.Trim());
                double discount = Convert.ToDouble(txtDescount.Text.Trim());
                string description = txtDescripttion.Text.Trim();
                string feature = txtFeatures.Text.Trim();
                int activeint = ckActive.Checked ? 1 : 0;
                Boolean active = activeint == 1 ? true : false;
                int brandId = Convert.ToInt32(txtBrandID.Text.Trim());
                int categoryId = Convert.ToInt32(txtCategoryID.Text.Trim());
                int productDetailId = Convert.ToInt32(txtProductDetailID.Text.Trim());
                if (produc.addProduct(name, price, discount, description, feature, active, brandId, categoryId, productDetailId))
                {
                    productsBindingSource1.DataSource = db.Products.ToList();
                    MessageBox.Show("Add sucess");
                }
                else
                {
                    MessageBox.Show("loi");
                }
                isAdd = false;
            }
            else
            {
                int id = Convert.ToInt32(txtID.Text.Trim());
                string name = txtName.Text.Trim();
                double price = Convert.ToDouble(txtPrice.Text.Trim());
                double discount = Convert.ToDouble(txtDescount.Text.Trim());
                string description = txtDescripttion.Text.Trim();
                string feature = txtFeatures.Text.Trim();
                int activeint = ckActive.Checked ? 1 : 0;
                Boolean active = activeint == 1 ? true : false;
                int brandId = Convert.ToInt32(txtBrandID.Text.Trim());
                int categoryId = Convert.ToInt32(txtCategoryID.Text.Trim());
                int productDetailId = Convert.ToInt32(txtProductDetailID.Text.Trim());
                if (produc.updateProduct(id, name, price, discount, description, feature, active, brandId, categoryId, productDetailId))
                {
                    productsBindingSource1.DataSource = db.Products.ToList();
                    MessageBox.Show("Update success");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Do you want to delete", "Infor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtID.Text.Trim());
                if (produc.deleteProduct(id))
                {
                    XtraMessageBox.Show("Delete Success");
                    productsBindingSource1.DataSource = db.Products.ToList();
                }
                else
                {
                    XtraMessageBox.Show("Can not delete");
                }
            }
        }
    }
}
