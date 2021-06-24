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
using System.Data.SqlClient;
using System.Data.Common;

namespace ARACOTO
{
    public partial class FrmMalzemeEkle : DevExpress.XtraEditors.XtraForm
    {
        public FrmMalzemeEkle()
        {
            InitializeComponent();
        }

        Model1 db = new Model1();

        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand com = new SqlCommand();
        DataSet ds = new DataSet();


        void listele()
        {
            con = new SqlConnection(@"Server =MI; Database = AracOto; Trusted_Connection = True;");
            da = new SqlDataAdapter("Select * From GetMalzeme", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds);
            gridliste.DataSource = ds.Tables[0];
            con.Close();
            //string sqlConn = "server=lochalhost; database=AracOto;trusted_connection=true;";
            //SqlConnection conn = new SqlConnection(sqlConn);
            //string cmdText = $@"select *from GetMalzeme";
            //SqlCommand cmd = new SqlCommand(cmdText, conn);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //gridliste.DataSource = dt;
            //Model1 context = new Model1();
            //Conn.Open();
            //string SQLListe = string.Format($@"Select *From GetMalzeme");
            //SqlCommand cmd = new SqlCommand(SQLListe, context.Conn);
            //DataTable dst = new DataTable();
            //SqlDataAdapter dat = new SqlDataAdapter(cmd);
            //dat.Fill(dst);
            //gridliste.DataSource = SQLListe;
            //EfMalzemeKayit arac = new EfMalzemeKayit();
            //List<MalzemeKayitDto> liste = arac.MalzemeList();
            //gridliste.DataSource = liste;           
        }

        private void FrmMalzemeEkle_Load(object sender, EventArgs e)
        {

            listele();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("id").ToString();
            txtisim.Text = gridView1.GetFocusedRowCellValue("Name").ToString();
            txtmalkod.Text = gridView1.GetFocusedRowCellValue("Kod").ToString();
            txtmalbarkod.Text = gridView1.GetFocusedRowCellValue("Barkod").ToString();
            txtmalbirim.Text = gridView1.GetFocusedRowCellValue("Birim").ToString();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            AO_MALZEME ekle = new AO_MALZEME();
            ekle.Name = txtisim.Text;
            ekle.Kod = txtmalkod.Text;
            ekle.Barkod = txtmalbarkod.Text;
            ekle.Birim = txtmalbirim.Text;
            db.AO_MALZEME.Add(ekle);
            db.SaveChanges();
            XtraMessageBox.Show("Kayıt gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtId.Text);
            var deger = db.AO_MALZEME.Find(x);
            db.AO_MALZEME.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("Kayıt Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtId.Text);
            var deger = db.AO_MALZEME.Find(x);
            deger.Name = txtisim.Text;
            deger.Kod = txtmalkod.Text;
            deger.Barkod = txtmalbarkod.Text;
            deger.Birim = txtmalbirim.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Kayıt Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            listele();
        }

    }
}
