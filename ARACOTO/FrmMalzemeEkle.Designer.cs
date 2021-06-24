namespace ARACOTO
{
    partial class FrmMalzemeEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMalzemeEkle));
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.txtmalzemeno = new DevExpress.XtraEditors.LabelControl();
            this.txtmalbirim = new DevExpress.XtraEditors.TextEdit();
            this.txtmalbarkod = new DevExpress.XtraEditors.TextEdit();
            this.txtmalkod = new DevExpress.XtraEditors.TextEdit();
            this.txtisim = new DevExpress.XtraEditors.TextEdit();
            this.txtbirim = new DevExpress.XtraEditors.LabelControl();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnListele = new DevExpress.XtraEditors.SimpleButton();
            this.txtkod = new DevExpress.XtraEditors.LabelControl();
            this.txtbarkod = new DevExpress.XtraEditors.LabelControl();
            this.txtad = new DevExpress.XtraEditors.LabelControl();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridliste = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmalbirim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmalbarkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmalkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtisim.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridliste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(822, 96);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(72, 29);
            this.btnGuncelle.TabIndex = 16;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(122, 31);
            this.txtId.Name = "txtId";
            this.txtId.Properties.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(127, 20);
            this.txtId.TabIndex = 9;
            // 
            // txtmalzemeno
            // 
            this.txtmalzemeno.Location = new System.Drawing.Point(4, 38);
            this.txtmalzemeno.Name = "txtmalzemeno";
            this.txtmalzemeno.Size = new System.Drawing.Size(92, 13);
            this.txtmalzemeno.TabIndex = 8;
            this.txtmalzemeno.Text = "Malzeme Numarası:";
            // 
            // txtmalbirim
            // 
            this.txtmalbirim.Location = new System.Drawing.Point(632, 31);
            this.txtmalbirim.Name = "txtmalbirim";
            this.txtmalbirim.Size = new System.Drawing.Size(127, 20);
            this.txtmalbirim.TabIndex = 7;
            // 
            // txtmalbarkod
            // 
            this.txtmalbarkod.Location = new System.Drawing.Point(404, 35);
            this.txtmalbarkod.Name = "txtmalbarkod";
            this.txtmalbarkod.Size = new System.Drawing.Size(127, 20);
            this.txtmalbarkod.TabIndex = 6;
            // 
            // txtmalkod
            // 
            this.txtmalkod.Location = new System.Drawing.Point(404, 96);
            this.txtmalkod.Name = "txtmalkod";
            this.txtmalkod.Size = new System.Drawing.Size(127, 20);
            this.txtmalkod.TabIndex = 5;
            // 
            // txtisim
            // 
            this.txtisim.Location = new System.Drawing.Point(122, 92);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(127, 20);
            this.txtisim.TabIndex = 4;
            // 
            // txtbirim
            // 
            this.txtbirim.Location = new System.Drawing.Point(582, 38);
            this.txtbirim.Name = "txtbirim";
            this.txtbirim.Size = new System.Drawing.Size(28, 13);
            this.txtbirim.TabIndex = 2;
            this.txtbirim.Text = "Birimi:";
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.Image")));
            this.btnEkle.Location = new System.Drawing.Point(822, 57);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(72, 33);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnListele
            // 
            this.btnListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnListele.ImageOptions.Image")));
            this.btnListele.Location = new System.Drawing.Point(822, 131);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(72, 34);
            this.btnListele.TabIndex = 13;
            this.btnListele.Text = "Listele";
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // txtkod
            // 
            this.txtkod.Location = new System.Drawing.Point(297, 99);
            this.txtkod.Name = "txtkod";
            this.txtkod.Size = new System.Drawing.Size(71, 13);
            this.txtkod.TabIndex = 3;
            this.txtkod.Text = "Malzeme kodu:";
            // 
            // txtbarkod
            // 
            this.txtbarkod.Location = new System.Drawing.Point(297, 38);
            this.txtbarkod.Name = "txtbarkod";
            this.txtbarkod.Size = new System.Drawing.Size(87, 13);
            this.txtbarkod.TabIndex = 2;
            this.txtbarkod.Text = "Malzeme Barkodu:";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(6, 95);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(63, 13);
            this.txtad.TabIndex = 0;
            this.txtad.Text = "Malzeme Adı:";
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(822, 19);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(72, 31);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.txtmalzemeno);
            this.groupBox1.Controls.Add(this.txtmalbirim);
            this.groupBox1.Controls.Add(this.txtmalbarkod);
            this.groupBox1.Controls.Add(this.txtmalkod);
            this.groupBox1.Controls.Add(this.txtisim);
            this.groupBox1.Controls.Add(this.txtbirim);
            this.groupBox1.Controls.Add(this.txtkod);
            this.groupBox1.Controls.Add(this.txtbarkod);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Location = new System.Drawing.Point(5, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 147);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Malzeme Bilgileri";
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.gridliste);
            this.panelControl2.Location = new System.Drawing.Point(8, 185);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(915, 276);
            this.panelControl2.TabIndex = 17;
            // 
            // gridliste
            // 
            this.gridliste.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridliste.Location = new System.Drawing.Point(5, 5);
            this.gridliste.MainView = this.gridView1;
            this.gridliste.Name = "gridliste";
            this.gridliste.Size = new System.Drawing.Size(906, 271);
            this.gridliste.TabIndex = 12;
            this.gridliste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridliste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Controls.Add(this.btnSil);
            this.panelControl1.Controls.Add(this.btnListele);
            this.panelControl1.Controls.Add(this.btnEkle);
            this.panelControl1.Controls.Add(this.btnGuncelle);
            this.panelControl1.Location = new System.Drawing.Point(8, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(911, 176);
            this.panelControl1.TabIndex = 18;
            // 
            // FrmMalzemeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 464);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Name = "FrmMalzemeEkle";
            this.Text = "FrmMalzemeEkle";
            this.Load += new System.EventHandler(this.FrmMalzemeEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmalbirim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmalbarkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmalkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtisim.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridliste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl txtmalzemeno;
        private DevExpress.XtraEditors.TextEdit txtmalbirim;
        private DevExpress.XtraEditors.TextEdit txtmalbarkod;
        private DevExpress.XtraEditors.TextEdit txtmalkod;
        private DevExpress.XtraEditors.TextEdit txtisim;
        private DevExpress.XtraEditors.LabelControl txtbirim;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnListele;
        private DevExpress.XtraEditors.LabelControl txtkod;
        private DevExpress.XtraEditors.LabelControl txtbarkod;
        private DevExpress.XtraEditors.LabelControl txtad;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridliste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}