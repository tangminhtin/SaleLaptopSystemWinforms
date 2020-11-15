﻿using System;
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
    public partial class ProductView : UserControl
    {

        SaleLaptopSystemEntities db = new SaleLaptopSystemEntities();
        int id = -1;
        Product product;
        public ProductView()
        {
            InitializeComponent();
            load();
        }

        public void load()
        {
            var list = from product in db.Products
                       join brand in db.Brands on
                       product.BrandID equals brand.ID
                       join category in db.Categories on
                       product.CategoryID equals category.ID
                       select new
                       {
                           ID = product.ID,
                           Name = product.Name,
                           Price = product.Price,
                           Discount = product.Discount,
                           Discription = product.Description,
                           Features = product.Features,
                           Active = product.Active,
                           Brand = brand.Name,
                           Category = category.Name,
                           ProductDetail = product.ProductDetailID
                       };

            dtProduct.DataSource = list.ToList();
            dtProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtProduct.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            String text = txtSearch.Text.Trim();
            if (text == "")
            {
                load();
            }
            var list = from product in db.Products
                       join brand in db.Brands on
                       product.BrandID equals brand.ID
                       join category in db.Categories on
                       product.CategoryID equals category.ID
                       where product.Name.Contains(text)
                       select new
                       {
                           ID = product.ID,
                           Name = product.Name,
                           Price = product.Price,
                           Discount = product.Discount,
                           Discription = product.Description,
                           Features = product.Features,
                           Active = product.Active,
                           Brand = brand.Name,
                           Category = category.Name,
                           ProductDetail = product.ProductDetailID

                       };
            dtProduct.DataSource = list.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new ProductInsAndUp(true, null).Visible = true;
            this.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.id < 0)
            {
                MessageBox.Show("Please choice product to update");
            }
            else
            {
                new ProductInsAndUp(false, this.product).Visible = true;
                this.Visible = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.id < 0)
            {
                MessageBox.Show("Please choice product to delete");
            }
            else
            {
                db.Products.Remove(this.product);
                db.SaveChanges();
                load();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            load();
        }

        private void cbbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtProduct_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.id = Convert.ToInt32(dtProduct.Rows[dtProduct.CurrentCell.RowIndex].Cells[0].Value);
            this.product = db.Products.FirstOrDefault(c => c.ID == this.id);
        }
    }
}