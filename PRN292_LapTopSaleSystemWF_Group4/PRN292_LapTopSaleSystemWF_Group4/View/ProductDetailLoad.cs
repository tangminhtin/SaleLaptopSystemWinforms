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

namespace PRN292_LapTopSaleSystemWF_Group4.View
{
    public partial class ProductDetailLoad : UserControl
    {
        SaleLaptopSystemEntities db = new SaleLaptopSystemEntities();
        int id = -1;
        ProductDetail productDetail;
        public ProductDetailLoad()
        {
            InitializeComponent();
            
        }

        public void load()
        {
            /*            if (radioaz.Checked)
                        {*/
            var list = from productDetail in db.ProductDetails
                       select new
                       {
                           ID = productDetail.ID,
                           Processor = productDetail.Processor,
                           RAM = productDetail.RAM,
                           Screen = productDetail.Screen,
                           Storage = productDetail.Storage,
                           Graphic = productDetail.Graphic,
                           Size = productDetail.Size,
                           OS = productDetail.OS,
                           Video = productDetail.Video,
                           Connection = productDetail.Connection,
                           KeyBoard = productDetail.Keyboard,
                           Battery = productDetail.Battery
                       };
            //}

            dtTableProductDetail.DataSource = list.ToList();
            dtTableProductDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtTableProductDetail.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
