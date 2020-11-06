namespace BankMonitor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbtnSignIn = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnSignOut = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnAdmin = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnBackup = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.bbtnRestore = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnRedo = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnpnStaff = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ucStaff = new BankMonitor.views.UCStaff();
            this.ucCustomer = new BankMonitor.views.UCCustomer();
            this.ucExchange = new BankMonitor.views.UCExchange();
            this.ucTransfer = new BankMonitor.views.UCTransfer();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.bbtnSignIn,
            this.bbtnChangePassword,
            this.bbtnSignOut,
            this.bbtnAdmin,
            this.bbtnBackup,
            this.skinRibbonGalleryBarItem1,
            this.bbtnRestore,
            this.bbtnSave,
            this.bbtnUndo,
            this.bbtnRedo,
            this.bbtnpnStaff,
            this.bbtnCustomer,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 17;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbonControl1.Size = new System.Drawing.Size(1220, 158);
            // 
            // bbtnSignIn
            // 
            this.bbtnSignIn.Caption = "Đăng nhập";
            this.bbtnSignIn.Id = 1;
            this.bbtnSignIn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtnSignIn.ImageOptions.LargeImage")));
            this.bbtnSignIn.Name = "bbtnSignIn";
            // 
            // bbtnChangePassword
            // 
            this.bbtnChangePassword.Caption = "Đổi mật khẩu";
            this.bbtnChangePassword.Id = 2;
            this.bbtnChangePassword.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtnChangePassword.ImageOptions.Image")));
            this.bbtnChangePassword.Name = "bbtnChangePassword";
            // 
            // bbtnSignOut
            // 
            this.bbtnSignOut.Caption = "Đăng xuất";
            this.bbtnSignOut.Id = 3;
            this.bbtnSignOut.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtnSignOut.ImageOptions.Image")));
            this.bbtnSignOut.Name = "bbtnSignOut";
            // 
            // bbtnAdmin
            // 
            this.bbtnAdmin.Caption = "Phân quyền";
            this.bbtnAdmin.Id = 4;
            this.bbtnAdmin.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtnAdmin.ImageOptions.LargeImage")));
            this.bbtnAdmin.Name = "bbtnAdmin";
            // 
            // bbtnBackup
            // 
            this.bbtnBackup.Caption = "Sao lưu dữ liệu";
            this.bbtnBackup.Id = 5;
            this.bbtnBackup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtnBackup.ImageOptions.Image")));
            this.bbtnBackup.Name = "bbtnBackup";
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 6;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // bbtnRestore
            // 
            this.bbtnRestore.Caption = "Phụ hồi dữ liệu";
            this.bbtnRestore.Id = 7;
            this.bbtnRestore.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtnRestore.ImageOptions.Image")));
            this.bbtnRestore.Name = "bbtnRestore";
            // 
            // bbtnSave
            // 
            this.bbtnSave.Caption = "Lưu";
            this.bbtnSave.Id = 8;
            this.bbtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtnSave.ImageOptions.Image")));
            this.bbtnSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtnSave.ImageOptions.LargeImage")));
            this.bbtnSave.Name = "bbtnSave";
            // 
            // bbtnUndo
            // 
            this.bbtnUndo.Caption = "Undo";
            this.bbtnUndo.Id = 9;
            this.bbtnUndo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtnUndo.ImageOptions.Image")));
            this.bbtnUndo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtnUndo.ImageOptions.LargeImage")));
            this.bbtnUndo.Name = "bbtnUndo";
            // 
            // bbtnRedo
            // 
            this.bbtnRedo.Caption = "Redo";
            this.bbtnRedo.Id = 10;
            this.bbtnRedo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtnRedo.ImageOptions.Image")));
            this.bbtnRedo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtnRedo.ImageOptions.LargeImage")));
            this.bbtnRedo.Name = "bbtnRedo";
            // 
            // bbtnpnStaff
            // 
            this.bbtnpnStaff.Caption = "Nhân viên";
            this.bbtnpnStaff.Id = 11;
            this.bbtnpnStaff.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtnpnStaff.ImageOptions.Image")));
            this.bbtnpnStaff.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtnpnStaff.ImageOptions.LargeImage")));
            this.bbtnpnStaff.Name = "bbtnpnStaff";
            this.bbtnpnStaff.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnpnStaff_ItemClick);
            // 
            // bbtnCustomer
            // 
            this.bbtnCustomer.Caption = "Khách hàng";
            this.bbtnCustomer.Id = 12;
            this.bbtnCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtnCustomer.ImageOptions.Image")));
            this.bbtnCustomer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtnCustomer.ImageOptions.LargeImage")));
            this.bbtnCustomer.Name = "bbtnCustomer";
            this.bbtnCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnCustomer_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Gởi tiền/Rút tiền";
            this.barButtonItem1.Id = 13;
            this.barButtonItem1.ImageOptions.LargeImage = global::BankMonitor.Properties.Resources._48807_7_exchange_png_file_hd;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 14;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 15;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Chuyển tiền";
            this.barButtonItem4.Id = 16;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtnSignIn);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtnChangePassword);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtnSignOut);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtnAdmin);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Bảo mật";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.bbtnBackup);
            this.ribbonPageGroup4.ItemLinks.Add(this.bbtnRestore);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Hệ thống";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup6});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Quản lý";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbtnSave);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbtnUndo);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbtnRedo);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Thao tác";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.bbtnpnStaff);
            this.ribbonPageGroup6.ItemLinks.Add(this.bbtnCustomer);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Quản lý";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup7});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Giao dịch";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ucStaff
            // 
            this.ucStaff.AutoSize = true;
            this.ucStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucStaff.Location = new System.Drawing.Point(0, 158);
            this.ucStaff.Name = "ucStaff";
            this.ucStaff.Size = new System.Drawing.Size(1220, 475);
            this.ucStaff.TabIndex = 3;
            this.ucStaff.Visible = false;
            // 
            // ucCustomer
            // 
            this.ucCustomer.AutoSize = true;
            this.ucCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ucCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCustomer.Location = new System.Drawing.Point(0, 158);
            this.ucCustomer.Name = "ucCustomer";
            this.ucCustomer.Size = new System.Drawing.Size(1220, 475);
            this.ucCustomer.TabIndex = 5;
            this.ucCustomer.Visible = false;
            this.ucCustomer.Load += new System.EventHandler(this.ucCustomer_Load);
            // 
            // ucExchange
            // 
            this.ucExchange.Location = new System.Drawing.Point(-13, 175);
            this.ucExchange.Name = "ucExchange";
            this.ucExchange.Size = new System.Drawing.Size(1233, 374);
            this.ucExchange.TabIndex = 7;
            this.ucExchange.Visible = false;
            // 
            // ucTransfer
            // 
            this.ucTransfer.Location = new System.Drawing.Point(0, 175);
            this.ucTransfer.Name = "ucTransfer";
            this.ucTransfer.Size = new System.Drawing.Size(1217, 437);
            this.ucTransfer.TabIndex = 9;
            this.ucTransfer.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 633);
            this.Controls.Add(this.ucTransfer);
            this.Controls.Add(this.ucExchange);
            this.Controls.Add(this.ucCustomer);
            this.Controls.Add(this.ucStaff);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbtnSignIn;
        private DevExpress.XtraBars.BarButtonItem bbtnChangePassword;
        private DevExpress.XtraBars.BarButtonItem bbtnSignOut;
        private DevExpress.XtraBars.BarButtonItem bbtnAdmin;
        private DevExpress.XtraBars.BarButtonItem bbtnBackup;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.BarButtonItem bbtnRestore;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem bbtnSave;
        private DevExpress.XtraBars.BarButtonItem bbtnUndo;
        private DevExpress.XtraBars.BarButtonItem bbtnRedo;
        private DevExpress.XtraBars.BarButtonItem bbtnpnStaff;
        private DevExpress.XtraBars.BarButtonItem bbtnCustomer;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private views.UCStaff ucStaff;
        private views.UCCustomer ucCustomer;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private views.UCExchange ucExchange;
        private views.UCTransfer ucTransfer;
    }
}

