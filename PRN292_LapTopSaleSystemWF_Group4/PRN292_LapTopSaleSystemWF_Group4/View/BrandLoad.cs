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
    public partial class BrandLoad : UserControl
    {
        SaleLaptopSystemEntities db = new SaleLaptopSystemEntities();
        int id = -1;
        Brand brand;
        public BrandLoad()
        {
            InitializeComponent();
            load();     
        }

        public void load()
        {
/*            if (radioaz.Checked)
            {*/
                var list = from brand in db.Brands
                           orderby brand.Name ascending
                           select new
                           {
                               ID = brand.ID,
                               Name = brand.Name,
                               Image = brand.Image,
                               Active = brand.Active
                           };
            //}
            
            dtTableBrand.DataSource = list.ToList();
            dtTableBrand.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtTableBrand.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new BrandInsAndUp(true, null, this).Visible = true;
            this.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(this.id < 0)
            {
                MessageBox.Show("Please choice brand to update");
            }
            else
            {
                new BrandInsAndUp(false, this.brand, this).Visible = true;
                this.Visible = false;
            }
        }

        private void dtTableBrand_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.id = Convert.ToInt32(dtTableBrand.Rows[dtTableBrand.CurrentCell.RowIndex].Cells[0].Value);
            this.brand = db.Brands.FirstOrDefault(b => b.ID == this.id);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.id < 0)
            {
                MessageBox.Show("Please choice brand to delete");
            }
            else
            {
                db.Brands.Remove(this.brand);
                db.SaveChanges();
                load();
            }           
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            String text = txtSearch.Text.Trim();
            if(text == "")
            {
                load();
            }
            var list = from brand in db.Brands where brand.Name.Contains(text) select brand;
            dtTableBrand.DataSource = list.ToList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            load();
        }

        private void radioaz_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioza_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbbActive_CheckedChanged(object sender, EventArgs e)
        {
            if (cbbActive.Checked)
            {
                dtTableBrand.DataSource = db.Brands.Where(x => x.Active == true).ToList();
            }
            else
            {
                dtTableBrand.DataSource = db.Brands.Where(x => x.Active == false).ToList();
            }
        }
    }
}
