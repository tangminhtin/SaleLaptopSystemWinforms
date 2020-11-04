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

namespace PRN292_LapTopSaleSystemWF_Group4.View
{
    public partial class Test : DevExpress.XtraEditors.XtraForm
    {
        public Test()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            UserLoad user = new UserLoad();
            panel1.Controls.Add(user);
            user.BringToFront();
            user.Size = new Size(992, 558);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductLoad product = new ProductLoad();
            panel1.Controls.Add(product);
            product.Size = new Size(992, 558);
            product.BringToFront(); 
        }

        private void btnProductDetail_Click(object sender, EventArgs e)
        {
            ProductDetailsLoad productdetail = new ProductDetailsLoad();
            panel1.Controls.Add(productdetail);
            productdetail.Size = new Size(992, 558);
            productdetail.BringToFront();
        }

        private void btnBrands_Click(object sender, EventArgs e)
        {
            BrandLoad brand = new BrandLoad();
            panel1.Controls.Add(brand);
            brand.BringToFront();
            brand.Size = new Size(992, 558);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            CategoriesLoad categories = new CategoriesLoad();
            panel1.Controls.Add(categories);
            categories.BringToFront();
            categories.Size = new Size(992, 558);
        }
    }
}