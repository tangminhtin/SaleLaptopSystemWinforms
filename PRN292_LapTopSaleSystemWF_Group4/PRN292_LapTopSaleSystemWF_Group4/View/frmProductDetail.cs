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
    public partial class frmProductDetail : DevExpress.XtraEditors.XtraForm
    {
        Boolean isAdd = false;
        SaleLaptopSystemEntities db = new SaleLaptopSystemEntities();
        ProductDetailDAO pdDAO = new ProductDetailDAO();
        public frmProductDetail()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void frmProductDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'saleLaptopSystemDataSet9.ProductDetails' table. You can move, or remove it, as needed.
            this.productDetailsTableAdapter.Fill(db.ProductDetails);
            productDetailsBindingSource.DataSource = db.ProductDetails.ToList();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            productDetailsBindingSource.AddNew();
            isAdd = true;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String processor = txtProcessor.Text.Trim();
            String RAM = txtRAM.Text.Trim();
            String screen = txtScreen.Text.Trim();
            String storage = txtStorage.Text.Trim();
            String graphic = txtGraphic.Text.Trim();
            String video = txtVideo.Text.Trim();
            String os = txtOS.Text.Trim();
            String size = txtSize.Text.Trim();
            String connection = txtConnection.Text.Trim();
            String keyboard = txtKeyboard.Text.Trim();
            String battery = txtBettery.Text.Trim();
            int id = Convert.ToInt32(txtID.Text.Trim());
                if (isAdd)
                {
                    if (processor == "" || RAM == "" || screen == "" || storage == "" || graphic == "" || video == "" || keyboard == "" || battery == "")
                    {
                        MessageBox.Show("Please full the fill");
                    }
                    else
                    {
                        if (pdDAO.add(processor, RAM, screen, storage, graphic, size, os, video, connection, keyboard, battery))
                        {
                            XtraMessageBox.Show("Add successful");
                            isAdd = false;
                        }
                        else
                        {
                            XtraMessageBox.Show("Add fail");
                        }
                    }

                }
                else
                {
                if (pdDAO.update(id, processor, RAM, screen, storage, graphic, size, os, video, connection, keyboard, battery))
                {
                    XtraMessageBox.Show("Update successful");
                    productDetailsBindingSource.DataSource = db.ProductDetails.ToList();
                }
                else
                {
                    XtraMessageBox.Show("update fail");
                }
            }
            
            

        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Do you want to delete", "Infor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtID.Text.Trim());
                if (pdDAO.delete(id))
                {
                    XtraMessageBox.Show("Delete successful");
                    productDetailsBindingSource.DataSource = db.ProductDetails.ToList();
                }
                else
                {
                    XtraMessageBox.Show("Delete fail");
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}