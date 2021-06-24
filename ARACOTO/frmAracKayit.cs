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
using ARACOTO.Models;
using ARACOTO.DataAccess;
using ARACOTO.Models.Dto_s;
using System.Linq.Expressions;
using System.Data.SqlClient;

namespace ARACOTO
{
    public partial class frmAracKayit : DevExpress.XtraEditors.XtraForm
    {
        public frmAracKayit()
        {
            InitializeComponent();
        }


        Model1 db = new Model1();
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand com = new SqlCommand();
        DataSet ds = new DataSet();

        void listeletip()
        {
            gridControl1.DataSource = db.AO_ARACTIP.ToList();
        }

        void listele()
        {
            con = new SqlConnection(@"Server =MI; Database = AracOto; Trusted_Connection = True;");
            da = new SqlDataAdapter("Select * From GetArac", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds);
            gridliste.DataSource = ds.Tables[0];
            con.Close();
        }

            private void frmAracKayit_Load(object sender, EventArgs e)
        {
            var stoklar = db.AO_MUSTERILER.ToList();

            lookUpEdit1.Properties.ValueMember = "id";
            lookUpEdit1.Properties.DisplayMember = "Name";
            lookUpEdit1.Properties.DataSource = stoklar;

            var stok = db.AO_ARACTIP.ToList();
            lookUpEdit2.Properties.ValueMember = "id";
            lookUpEdit2.Properties.DataSource = "Name";
            lookUpEdit2.Properties.DataSource = stok;
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //txttip.Text = gridView1.GetFocusedRowCellValue("aractip_id").ToString();
            //txtmusterino.Text = gridView1.GetFocusedRowCellValue("musteri_id").ToString();
            txtkayitno.Text = gridView1.GetFocusedRowCellValue("id").ToString();
            txtplaka.Text = gridView1.GetFocusedRowCellValue("plaka").ToString();
            txtnot.Text = gridView1.GetFocusedRowCellValue("notlar").ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            AO_ARACTIP ekle = new AO_ARACTIP();
            ekle.Name = txttipekle.Text;
            db.AO_ARACTIP.Add(ekle);
            db.SaveChanges();
            XtraMessageBox.Show("Kayıt gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txttipid.Text);
            var deger = db.AO_ARACTIP.Find(x);
            db.AO_ARACTIP.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("Kayıt Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            listele();
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txttipid.Text = gridView2.GetFocusedRowCellValue("id").ToString();
            txttipekle.Text = gridView2.GetFocusedRowCellValue("Name").ToString();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            listeletip();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txttipid.Text);
            var deger = db.AO_ARACTIP.Find(x);
            deger.Name = txttipekle.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Kayıt Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            listeletip();
        }

        private void btnaracekle_Click(object sender, EventArgs e)
        {
            AO_ARACKAYIT ekle = new AO_ARACKAYIT();
            ekle.plaka = txtplaka.Text;
            ekle.notlar = txtnot.Text;
            ekle.musteri_id = (int)lookUpEdit1.EditValue;
            db.AO_ARACKAYIT.Add(ekle);
            db.SaveChanges();
            XtraMessageBox.Show("Kayıt gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnaracsil_Click(object sender, EventArgs e)
        {
            var x = int.Parse(txtkayitno.Text);
            var deger = db.AO_ARACKAYIT.Find(x);
            deger.Durum = false;
            db.SaveChanges();
            XtraMessageBox.Show("Kayıt silindi,silinen stoklar tablosundan silinen stokların listesine ulaşabilirsiniz.",
            "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnkayitguncelle_Click(object sender, EventArgs e)
        {
            AO_ARACKAYIT kayit = gridView1.GetFocusedRow() as AO_ARACKAYIT;
            //kayit.musteri_id = (int)lookUpEdit1.EditValue;
            //kayit.aractip_id = (int)lookUpEdit2.EditValue;
            kayit.plaka = txtplaka.Text;
            kayit.notlar = txtnot.Text;
            db.Entry(kayit).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            XtraMessageBox.Show("Kayıt gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }


    }
}