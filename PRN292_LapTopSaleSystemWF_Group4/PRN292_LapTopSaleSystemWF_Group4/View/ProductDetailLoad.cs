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
    public partial class ProductDetailLoad : UserControl
    {
        SaleLaptopSystemEntities db = new SaleLaptopSystemEntities();
        ProductDetailDAO productDetail = new ProductDetailDAO();
        bool isAdd =false;
        public ProductDetailLoad()
        {
            InitializeComponent();
        }

        private void ProductDetailLoad_Load(object sender, EventArgs e)
        {
            productDetailsBindingSource.DataSource = db.ProductDetails.ToList();
        }

      

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Do you want to delete", "Infor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtId.Text.Trim());
                if (productDetail.delete(id))
                {
                    XtraMessageBox.Show("Delete successful");
                    productDetailsBindingSource.DataSource = db.ProductDetails.ToList();
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
                string processer = txtProcessor.Text.Trim();
                string ram = txtRam.Text.Trim();
                string screen = txtScreen.Text.Trim();
                string storage = txtStorage.Text.Trim();
                string graphic = txtGraphic.Text.Trim();
                string size = txtSize.Text.Trim();
                string os = txtOs.Text.Trim();
                string video = txtVideo.Text.Trim();
                string connection = txtConnection.Text.Trim();
                string keyBoard = txtKeyBoard.Text.Trim();
                string battery = txtBattery.Text.Trim();
                if (productDetail.add(processer, ram, screen, storage, graphic, size, os, video, connection, keyBoard, battery))
                {
                    productDetailsBindingSource.DataSource = db.ProductDetails.ToList();
                    MessageBox.Show("Add sucess");
                }
                else
                {
                    MessageBox.Show("Erorr");
                }
                isAdd = false;
            }
            else
            {
                int id = Convert.ToInt32(txtId.Text.Trim());
                string processer = txtProcessor.Text.Trim();
                string ram = txtRam.Text.Trim();
                string screen = txtScreen.Text.Trim();
                string storage = txtStorage.Text.Trim();
                string graphic = txtGraphic.Text.Trim();
                string size = txtSize.Text.Trim();
                string os = txtOs.Text.Trim();
                string video = txtVideo.Text.Trim();
                string connection = txtConnection.Text.Trim();
                string keyBoard = txtKeyBoard.Text.Trim();
                string battery = txtBattery.Text.Trim();
                if (productDetail.update(id, processer, ram, screen, storage, graphic, size, os, video, connection, keyBoard, battery))
                {
                    productDetailsBindingSource.DataSource = db.ProductDetails.ToList();
                    MessageBox.Show("Update sucess");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            productDetailsBindingSource.AddNew();
            isAdd = true;
        }
    }
}
