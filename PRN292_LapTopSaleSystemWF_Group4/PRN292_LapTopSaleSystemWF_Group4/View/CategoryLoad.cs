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
    public partial class CategoryLoad : UserControl
    {
        SaleLaptopSystemEntities db = new SaleLaptopSystemEntities();
        int id = -1;
        Category category;
        public CategoryLoad()
        {
            InitializeComponent();
            load();

            
        }

        public void load()
        {
            var list = from category in db.Categories
                       orderby category.Name ascending
                       select new
                       {
                           ID = category.ID,
                           Name = category.Name,
                           Active = category.Active
                       };
            dtTableCate.DataSource = list.ToList();
            dtTableCate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtTableCate.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new CateInsAndUp(true, null).Visible = true;
            this.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.id < 0)
            {
                MessageBox.Show("Please choice brand to update");
            }
            else
            {
                new CateInsAndUp(false, this.category).Visible = true;
                this.Visible = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.id < 0)
            {
                MessageBox.Show("Please choice brand to delete");
            }
            else
            {
                db.Categories.Remove(this.category);
                db.SaveChanges();
                load();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            String text = txtSearch.Text.Trim();
            if (text == "")
            {
                load();
            }
            var list = from category in db.Categories where category.Name.Contains(text) select new
            {
                ID = category.ID,
                Name = category.Name,
                Active = category.Active
            };
            dtTableCate.DataSource = list.ToList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            load();
        }

        private void cbbActive_CheckedChanged(object sender, EventArgs e)
        {
            var list = from category in db.Categories
                       orderby category.Name ascending
                       select new
                       {
                           ID = category.ID,
                           Name = category.Name,
                           Active = category.Active
                       };
            if (cbbActive.Checked)
            {
                dtTableCate.DataSource = list.Where(x => x.Active == true).ToList();
            }
            else
            {
                dtTableCate.DataSource = list.Where(x => x.Active == false).ToList();
            }
        }

        private void dtTableCate_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.id = Convert.ToInt32(dtTableCate.Rows[dtTableCate.CurrentCell.RowIndex].Cells[0].Value);
            this.category = db.Categories.FirstOrDefault(c => c.ID == this.id);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dtTableCate.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dtTableCate.Columns.Count + 1; i++)
                {
                    excelApp.Cells[1, i] = dtTableCate.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dtTableCate.Rows.Count; i++)
                {
                    for (int j = 0; j < dtTableCate.Columns.Count; j++)
                    {
                        excelApp.Cells[i + 2, j + 1] = dtTableCate.Rows[i].Cells[j].Value.ToString();
                    }
                }
                excelApp.Columns.AutoFit();
                excelApp.Visible = true;
            }
        }
    }
}
