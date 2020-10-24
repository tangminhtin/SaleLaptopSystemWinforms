namespace PRN292_LapTopSaleSystemWF_Group4.View
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.cbPass = new System.Windows.Forms.CheckBox();
            this.lblRegister = new System.Windows.Forms.Label();
            this.linkRegis = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.imageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.imageSlider1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(270, 170, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(209, 467);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(209, 467);
            this.Root.TextVisible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblEmail.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblEmail.Location = new System.Drawing.Point(215, 168);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(92, 34);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblPass.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblPass.Location = new System.Drawing.Point(215, 223);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(150, 34);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Password";
            // 
            // cbPass
            // 
            this.cbPass.AutoSize = true;
            this.cbPass.Location = new System.Drawing.Point(456, 272);
            this.cbPass.Name = "cbPass";
            this.cbPass.Size = new System.Drawing.Size(126, 21);
            this.cbPass.TabIndex = 5;
            this.cbPass.Text = "Show Password";
            this.cbPass.UseVisualStyleBackColor = true;
            this.cbPass.CheckedChanged += new System.EventHandler(this.cbPass_CheckedChanged);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Location = new System.Drawing.Point(228, 404);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(217, 17);
            this.lblRegister.TabIndex = 6;
            this.lblRegister.Text = "If you don\'t have account. Please ";
            // 
            // linkRegis
            // 
            this.linkRegis.AutoSize = true;
            this.linkRegis.LinkColor = System.Drawing.Color.Fuchsia;
            this.linkRegis.Location = new System.Drawing.Point(438, 404);
            this.linkRegis.Name = "linkRegis";
            this.linkRegis.Size = new System.Drawing.Size(80, 17);
            this.linkRegis.TabIndex = 7;
            this.linkRegis.TabStop = true;
            this.linkRegis.Text = "Registration";
            this.linkRegis.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegis_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogin.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogin.Location = new System.Drawing.Point(325, 313);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 45);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(317, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 48);
            this.label1.TabIndex = 9;
            this.label1.Text = "LOGIN";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(372, 234);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(210, 23);
            this.txtPass.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(372, 179);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(210, 23);
            this.txtEmail.TabIndex = 11;
            // 
            // imageSlider1
            // 
            this.imageSlider1.CurrentImageIndex = 0;
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images"))));
            this.imageSlider1.Location = new System.Drawing.Point(12, 12);
            this.imageSlider1.Name = "imageSlider1";
            this.imageSlider1.Size = new System.Drawing.Size(185, 443);
            this.imageSlider1.StyleController = this.layoutControl1;
            this.imageSlider1.TabIndex = 4;
            this.imageSlider1.Text = "imageSlider1";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.imageSlider1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(189, 447);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmLogin
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 467);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.linkRegis);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.cbPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.CheckBox cbPass;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.LinkLabel linkRegis;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtEmail;
    }
}