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
    public partial class frmProduct : DevExpress.XtraEditors.XtraForm
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'saleLaptopSystemDataSet8.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.saleLaptopSystemDataSet8.Products);

        }

        private void btnProductDetail_Click(object sender, EventArgs e)
        {
            frmProductDetail frm = new frmProductDetail();
            frm.Show();

        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }


        public void load()
        {
            using(var brands = new frmProductDetail())
            {
                var brand = 
            }
        }
    }
}