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
    public partial class frmProductDetail : DevExpress.XtraEditors.XtraForm
    {
        public frmProductDetail()
        {
            InitializeComponent();
        }

        private void frmProductDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'saleLaptopSystemDataSet9.ProductDetails' table. You can move, or remove it, as needed.
            this.productDetailsTableAdapter.Fill(this.saleLaptopSystemDataSet9.ProductDetails);

        }
    }
}