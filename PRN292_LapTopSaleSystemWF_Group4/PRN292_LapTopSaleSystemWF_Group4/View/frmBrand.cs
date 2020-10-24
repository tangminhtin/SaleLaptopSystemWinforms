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
using DevExpress.LookAndFeel;
using PRN292_LapTopSaleSystemWF_Group4.Model;
using PRN292_LapTopSaleSystemWF_Group4.DAO;

namespace PRN292_LapTopSaleSystemWF_Group4.View
{
    public partial class frmBrand : DevExpress.XtraEditors.XtraForm
    {
        BrandDAO brandDAO = new BrandDAO();
        SaleLaptopSystemEntities db = new SaleLaptopSystemEntities();
        Boolean isAdd = false;
        Boolean isUpdate = false;
        Boolean isDelete = false;
        public frmBrand()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void frmBrand_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'saleLaptopSystemDataSet.Brands' table. You can move, or remove it, as needed.
            this.brandsTableAdapter.Fill(this.saleLaptopSystemDataSet.Brands);
            brandsBindingSource.DataSource = db.Brands.ToList();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isAdd = true;
            brandsBindingSource.AddNew();
            txtName.Focus();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Boolean active = false;
            if (cbActive.Checked)
            {
                active = true;
            }
            else
            {
                active = false;
            }
            if (isAdd)
            {
                brandDAO.addBrand(txtName.Text.Trim(), txtImage.Text.Trim(), active);
                isAdd = false;
            }
            if (isUpdate)
            {
                int id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString());
                brandDAO.update(id, txtName.Text.Trim(), txtImage.Text.Trim(), active);
            }

        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isUpdate = true;
        }
    }
}