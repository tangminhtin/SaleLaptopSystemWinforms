namespace PRN292_LapTopSaleSystemWF_Group4.View
{
    partial class FrmCategory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategory));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.txtAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.tableAdapterManager1 = new PRN292_LapTopSaleSystemWF_Group4.SaleLaptopSystemDataSet1TableAdapters.TableAdapterManager();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.categoriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.saleLaptopSystemDataSet3 = new PRN292_LapTopSaleSystemWF_Group4.SaleLaptopSystemDataSet3();
            this.ckActive = new System.Windows.Forms.CheckBox();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleLaptopSystemDataSet2 = new PRN292_LapTopSaleSystemWF_Group4.SaleLaptopSystemDataSet2();
            this.saleLaptopSystemDataSet1 = new PRN292_LapTopSaleSystemWF_Group4.SaleLaptopSystemDataSet1();
            this.saleLaptopSystemDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new PRN292_LapTopSaleSystemWF_Group4.SaleLaptopSystemDataSet2TableAdapters.CategoriesTableAdapter();
            this.categoriesTableAdapter1 = new PRN292_LapTopSaleSystemWF_Group4.SaleLaptopSystemDataSet3TableAdapters.CategoriesTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleLaptopSystemDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleLaptopSystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleLaptopSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleLaptopSystemDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.txtAdd,
            this.barButtonItem2,
            this.barButtonItem3,
            this.btnUpdate,
            this.btnDelete,
            this.btnSave});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.txtAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUpdate),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSave)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // txtAdd
            // 
            this.txtAdd.Caption = "Add";
            this.txtAdd.Id = 0;
            this.txtAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtAdd.ImageOptions.Image")));
            this.txtAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("txtAdd.ImageOptions.LargeImage")));
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Caption = "Update";
            this.btnUpdate.Id = 3;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.LargeImage")));
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Delete";
            this.btnDelete.Id = 4;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.LargeImage")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Save";
            this.btnSave.Id = 5;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.LargeImage")));
            this.btnSave.Name = "btnSave";
            this.btnSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1285, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 496);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1285, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 466);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1285, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 466);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BrandsTableAdapter = null;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = PRN292_LapTopSaleSystemWF_Group4.SaleLaptopSystemDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dataGridView2);
            this.layoutControl1.Controls.Add(this.dataGridView1);
            this.layoutControl1.Controls.Add(this.ckActive);
            this.layoutControl1.Controls.Add(this.textEdit2);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 30);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1285, 466);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.categoriesBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(123, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(517, 338);
            this.dataGridView1.TabIndex = 9;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "Active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "Active";
            this.activeDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.Width = 125;
            // 
            // categoriesBindingSource1
            // 
            this.categoriesBindingSource1.DataMember = "Categories";
            this.categoriesBindingSource1.DataSource = this.saleLaptopSystemDataSet3;
            // 
            // saleLaptopSystemDataSet3
            // 
            this.saleLaptopSystemDataSet3.DataSetName = "SaleLaptopSystemDataSet3";
            this.saleLaptopSystemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ckActive
            // 
            this.ckActive.Location = new System.Drawing.Point(12, 38);
            this.ckActive.Name = "ckActive";
            this.ckActive.Size = new System.Drawing.Size(1261, 25);
            this.ckActive.TabIndex = 8;
            this.ckActive.Text = "Active";
            this.ckActive.UseVisualStyleBackColor = true;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(123, 12);
            this.textEdit2.MenuManager = this.barManager1;
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(1150, 22);
            this.textEdit2.StyleController = this.layoutControl1;
            this.textEdit2.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem1,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1285, 466);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(632, 55);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(633, 342);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textEdit2;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1265, 26);
            this.layoutControlItem2.Text = "Name";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(108, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ckActive;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1265, 29);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dataGridView1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 55);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(632, 342);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(108, 16);
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.saleLaptopSystemDataSet2;
            // 
            // saleLaptopSystemDataSet2
            // 
            this.saleLaptopSystemDataSet2.DataSetName = "SaleLaptopSystemDataSet2";
            this.saleLaptopSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saleLaptopSystemDataSet1
            // 
            this.saleLaptopSystemDataSet1.DataSetName = "SaleLaptopSystemDataSet1";
            this.saleLaptopSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saleLaptopSystemDataSet1BindingSource
            // 
            this.saleLaptopSystemDataSet1BindingSource.DataSource = this.saleLaptopSystemDataSet1;
            this.saleLaptopSystemDataSet1BindingSource.Position = 0;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // categoriesTableAdapter1
            // 
            this.categoriesTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(123, 409);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1150, 45);
            this.dataGridView2.TabIndex = 10;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dataGridView2;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 397);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(1265, 49);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(108, 16);
            // 
            // FrmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 496);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmCategory";
            this.Text = "FrmCategory";
            this.Load += new System.EventHandler(this.FrmCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleLaptopSystemDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleLaptopSystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleLaptopSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleLaptopSystemDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem txtAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private SaleLaptopSystemDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource saleLaptopSystemDataSet1BindingSource;
        private SaleLaptopSystemDataSet1 saleLaptopSystemDataSet1;
        private SaleLaptopSystemDataSet2 saleLaptopSystemDataSet2;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private SaleLaptopSystemDataSet2TableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.CheckBox ckActive;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private SaleLaptopSystemDataSet3 saleLaptopSystemDataSet3;
        private System.Windows.Forms.BindingSource categoriesBindingSource1;
        private SaleLaptopSystemDataSet3TableAdapters.CategoriesTableAdapter categoriesTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}