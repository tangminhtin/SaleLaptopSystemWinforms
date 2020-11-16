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
    public partial class ProductInsAndUp : DevExpress.XtraEditors.XtraForm
    {
        Product product;
        bool isIsert;
        bool isClick = false;
        int idDetail = 0;
        SaleLaptopSystemEntities db = new SaleLaptopSystemEntities();
        
        public ProductInsAndUp(bool isInsert, Product product)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            btnView.Visible = false;

            this.product = product;
            this.isIsert = isInsert;
            getValue();

            if (isIsert)
            {
                title.Text = "Insert";
                btnView.Visible = false;
                clear();
            }
            else
            {
                clear();
                btnView.Visible = true;
                title.Text = "Update";
                txtName.Text = product.Name;
                txtDescription.Text = product.Description;
                txtFeatures.Text = product.Features;
                txtPrice.Text = product.Price.ToString();
                txtDiscount.Text = product.Discount.ToString();
                cbActive.Checked = product.Active == true ? true : false;
            }
        }

        public void setisClick(bool isClick)
        {
            this.isClick = isClick;
        }

        public void setIdDetail(int idDetail)
        {
            this.idDetail = idDetail;
        }

        public void getValue()
        {
            cbbBrand.DataSource = db.Brands.ToList();
            cbbBrand.DisplayMember = "Name";
            cbbBrand.ValueMember = "ID";

           cbbCategory.DataSource = db.Categories.ToList();
            cbbCategory.DisplayMember = "Name";
            cbbCategory.ValueMember = "ID";
        }

        public void clear()
        {
            txtName.Text = "";
            txtDescription.Text = "";
            txtFeatures.Text = "";
            txtPrice.Text = "0";
            txtDiscount.Text = "0";
            cbActive.Checked = false;
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new ProductDetailInsAndUp(true, null, this).Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String name = txtName.Text.Trim();
            String description = txtDescription.Text.Trim();
            String features = txtFeatures.Text.Trim();
            String price = txtPrice.Text.Trim();
            String discount = txtDiscount.Text.Trim();


            if (name == "" || description == "" || features == "" || txtPrice.Text == "" || txtDiscount.Text == "")
                MessageBox.Show("Please input textfield");

            else
            {
                int brandid = Convert.ToInt32(cbbBrand.SelectedValue);
                int cateId = Convert.ToInt32(cbbCategory.SelectedValue);

                if(isClick == false)
                {
                    MessageBox.Show("Please add product detail");
                }
                else
                {
                    //int result = this.idDetail;
                    if (isIsert)
                    {
                        db.Products.Add(new Product(name,
                            Convert.ToDouble(price), Convert.ToDouble(discount), description, features, cbActive.Checked == true ?
                            true : false, brandid, cateId, this.idDetail));
                    db.SaveChanges();
                    }
                    else
                    {
                        int id = Convert.ToInt32(this.product.ID);
                        Product EProduct = db.Products.FirstOrDefault(c => c.ID == id);
                        EProduct.Name = txtName.Text;
                        EProduct.Price = Convert.ToDouble(txtPrice.Text);
                        EProduct.Discount = Convert.ToDouble(txtDiscount.Text);
                        EProduct.Description = txtDescription.Text;
                        EProduct.Features = txtFeatures.Text;
                        EProduct.Active = cbActive.Checked == true ? true : false;
                        EProduct.BrandID = Convert.ToInt32(cbbBrand.SelectedValue);
                        EProduct.CategoryID = Convert.ToInt32(cbbCategory.SelectedValue);
                        EProduct.ProductDetailID = this.idDetail;
                        db.SaveChanges();
                    }
                    ProductView form = new ProductView();
                    form.Visible = true;
                    form.load();
                    this.Visible = false;
                }              
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}