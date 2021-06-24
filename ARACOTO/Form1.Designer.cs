namespace ARACOTO
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnStokKaydi = new DevExpress.XtraBars.BarButtonItem();
            this.galleryDropDown1 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.galleryDropDown2 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.galleryDropDown3 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.galleryDropDown4 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnStokKaydi,
            this.barButtonItem3,
            this.barButtonItem5,
            this.barButtonItem9,
            this.barButtonItem10});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(847, 146);
            // 
            // btnStokKaydi
            // 
            this.btnStokKaydi.ActAsDropDown = true;
            this.btnStokKaydi.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.btnStokKaydi.Caption = "Stok Kaydı";
            this.btnStokKaydi.DropDownControl = this.galleryDropDown1;
            this.btnStokKaydi.Id = 1;
            this.btnStokKaydi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStokKaydi.ImageOptions.Image")));
            this.btnStokKaydi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnStokKaydi.ImageOptions.LargeImage")));
            this.btnStokKaydi.Name = "btnStokKaydi";
            this.btnStokKaydi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStokKaydi_ItemClick);
            // 
            // galleryDropDown1
            // 
            this.galleryDropDown1.Name = "galleryDropDown1";
            this.galleryDropDown1.Ribbon = this.ribbonControl1;
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.ActAsDropDown = true;
            this.barButtonItem3.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem3.Caption = "Müşteri Kaydı";
            this.barButtonItem3.DropDownControl = this.galleryDropDown2;
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // galleryDropDown2
            // 
            this.galleryDropDown2.Name = "galleryDropDown2";
            this.galleryDropDown2.Ribbon = this.ribbonControl1;
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.ActAsDropDown = true;
            this.barButtonItem5.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem5.Caption = "Malzeme Kaydı";
            this.barButtonItem5.DropDownControl = this.galleryDropDown3;
            this.barButtonItem5.Id = 3;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // galleryDropDown3
            // 
            this.galleryDropDown3.Name = "galleryDropDown3";
            this.galleryDropDown3.Ribbon = this.ribbonControl1;
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.ActAsDropDown = true;
            this.barButtonItem9.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem9.Caption = "Servis Kaydı";
            this.barButtonItem9.DropDownControl = this.galleryDropDown4;
            this.barButtonItem9.Id = 4;
            this.barButtonItem9.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.ImageOptions.Image")));
            this.barButtonItem9.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.ImageOptions.LargeImage")));
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem9_ItemClick);
            // 
            // galleryDropDown4
            // 
            this.galleryDropDown4.Name = "galleryDropDown4";
            this.galleryDropDown4.Ribbon = this.ribbonControl1;
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Araç Kayıt";
            this.barButtonItem10.Id = 5;
            this.barButtonItem10.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.ImageOptions.Image")));
            this.barButtonItem10.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.ImageOptions.LargeImage")));
            this.barButtonItem10.Name = "barButtonItem10";
            this.barButtonItem10.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem10_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Ana Sayfa";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnStokKaydi);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem10);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem9);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Stok Kaydı";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Stok Kaydı";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Müşteri Kaydı";
            this.barButtonItem4.Id = 2;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.ActAsDropDown = true;
            this.barButtonItem6.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem6.Caption = "Malzeme Kaydı";
            this.barButtonItem6.DropDownControl = this.galleryDropDown3;
            this.barButtonItem6.Id = 3;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.ActAsDropDown = true;
            this.barButtonItem7.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem7.Caption = "Malzeme Kaydı";
            this.barButtonItem7.DropDownControl = this.galleryDropDown3;
            this.barButtonItem7.Id = 3;
            this.barButtonItem7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.Image")));
            this.barButtonItem7.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.LargeImage")));
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.ActAsDropDown = true;
            this.barButtonItem8.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem8.Caption = "Malzeme Kaydı";
            this.barButtonItem8.DropDownControl = this.galleryDropDown3;
            this.barButtonItem8.Id = 3;
            this.barButtonItem8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.Image")));
            this.barButtonItem8.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.LargeImage")));
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // Form1
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 499);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnStokKaydi;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown1;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown2;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}

