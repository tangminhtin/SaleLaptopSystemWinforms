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
using DevExpress.XtraLayout.Customization;
using PRN292_LapTopSaleSystemWF_Group4.Model;
using PRN292_LapTopSaleSystemWF_Group4.DAO;

namespace PRN292_LapTopSaleSystemWF_Group4.View
{
  
    public partial class FrmCategory : DevExpress.XtraEditors.XtraForm
    {
        CategoryDAO categoryDao = new CategoryDAO();
        SaleLaptopSystemEntities db = new SaleLaptopSystemEntities();
        public FrmCategory()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'saleLaptopSystemDataSet3.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter1.Fill(this.saleLaptopSystemDataSet3.Categories);
        }
    }
}