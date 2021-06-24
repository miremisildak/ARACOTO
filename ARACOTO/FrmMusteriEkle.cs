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
    public partial class FrmMusteriEkle : DevExpress.XtraEditors.XtraForm
    {

        //SqlConnection baglanti;
        //SqlCommand komut;
        //SqlDataAdapter da;

        public FrmMusteriEkle()
        {
            InitializeComponent();
        }

        //void MusteriGetir()
        //{
        //    using (Model1 db=new Model1())
        //    {
        //        var must = db.AO_MUSTERILER.ToList();                
        //gridControl1.DataSource = db.AO_MUSTERILER.ToList();
        //    }
        //    //baglanti = new SqlConnection("server=.; Initial Catalog =AracOto; Integrated Security = SSPI; ");
        //    //baglanti.Open();
        //    //da = new SqlDataAdapter("Select *from AO_MUSTERILER ",baglanti);
        //    //DataTable tablo = new DataTable();
        //    //da.Fill(tablo);
        //    ////dataGridView1.DataSource = tablo;
        //    //baglanti.Close();
        //}

        Model1 db = new Model1();

        void listele()
        {
           
            gridControl1.DataSource = db.AO_MUSTERILER.ToList(); 
        }
       

    
        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void FrmMusteriEkle_Load(object sender, EventArgs e)
        {
            //using (Model1 db = new Model1())
            //{
            //  var must = db.AO_MUSTERILER.ToList();
            //  gridControl1.DataSource = db.AO_MUSTERILER.ToList();
            //}
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            AO_MUSTERILER ekle = new AO_MUSTERILER();
            ekle.Name = txtisim.Text;
            ekle.KimlikNo = txtTC.Text;
            ekle.TelefonNo = txttel.Text;
            ekle.Sehir = txtsehir.Text;
            db.AO_MUSTERILER.Add(ekle);
            db.SaveChanges();
            XtraMessageBox.Show("Kayıt gerçekleştirildi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtId.Text);
            var deger = db.AO_MUSTERILER.Find(x);
            db.AO_MUSTERILER.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("Kayıt Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            listele();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("id").ToString();
            txtisim.Text = gridView1.GetFocusedRowCellValue("Name").ToString();
            txtTC.Text = gridView1.GetFocusedRowCellValue("KimlikNo").ToString();
            txttel.Text = gridView1.GetFocusedRowCellValue("TelefonNo").ToString();
            txtsehir.Text = gridView1.GetFocusedRowCellValue("Sehir").ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtId.Text);
            var deger = db.AO_MUSTERILER.Find(x);
            deger.Name = txtisim.Text;
            deger.KimlikNo = txtTC.Text;
            deger.TelefonNo = txttel.Text;
            deger.Sehir = txtsehir.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Kayıt Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            listele();
        }

 
    }
}
