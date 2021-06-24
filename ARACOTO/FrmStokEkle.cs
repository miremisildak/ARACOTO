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
using System.Data.SqlClient;
using ARACOTO.Models;

namespace ARACOTO
{
    public partial class FrmStokEkle : DevExpress.XtraEditors.XtraForm
    {
        public FrmStokEkle()
        {
            InitializeComponent();
        }

        Model1 db = new Model1();

        void listele()
        {
            var degerler = from x in db.AO_STOK
                           select new
                           {
                               x.id,
                               x.malzeme_id,
                               x.miktar,
                               x.Durum
                           };
            gridControl1.DataSource = db.AO_STOK.Where(x=>x.Durum == true).ToList();
        }


        private void FrmStokEkle_Load(object sender, EventArgs e)
        {
            var stoklar = db.AO_MALZEME.ToList();

            lookUpEdit1.Properties.ValueMember = "id";
            lookUpEdit1.Properties.DisplayMember = "Name";
            lookUpEdit1.Properties.DataSource = stoklar;
        }


        private void btnListele_Click_1(object sender, EventArgs e)
        {
            listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            AO_STOK stok = new AO_STOK();
             
            stok.miktar = Convert.ToDecimal(textEdit1.Text);
            stok.malzeme_id =(int)lookUpEdit1.EditValue; 
            db.AO_STOK.Add(stok);
            db.SaveChanges();
            XtraMessageBox.Show("Kayıt gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var x = int.Parse(txtmalzeme.Text);
            var deger = db.AO_STOK.Find(x);
            deger.Durum = false;
            db.SaveChanges();
            XtraMessageBox.Show("Kayıt silindi,silinen stoklar tablosundan silinen stokların listesine ulaşabilirsiniz.",
            "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }


        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            AO_STOK stok = gridView1.GetFocusedRow() as AO_STOK;
            lookUpEdit1.EditValue =stok.malzeme_id;
            txtmalzeme.Text = stok.id.ToString();
            txtmalzemeno.Text = stok.malzeme_id.ToString();
            textEdit1.Text =Convert.ToDecimal( stok.miktar).ToString("n2");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {         
            AO_STOK stok = gridView1.GetFocusedRow() as AO_STOK;

            stok.miktar = Convert.ToDecimal(textEdit1.Text);
            stok.malzeme_id = (int)lookUpEdit1.EditValue;

            db.Entry(stok).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            XtraMessageBox.Show("Kayıt gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtmalzeme.Text = gridView1.GetFocusedRowCellValue("id").ToString();
            txtmalzemeno.Text = gridView1.GetFocusedRowCellValue("malzeme_id").ToString();
            lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("malzeme_id").ToString();
            textEdit1.Text = gridView1.GetFocusedRowCellValue("miktar").ToString();

        }

    }
}
