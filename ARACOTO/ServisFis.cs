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
using System.Data.SqlClient;

namespace ARACOTO
{
    public partial class ServisFis : DevExpress.XtraEditors.XtraForm
    {
        public ServisFis()
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
            da = new SqlDataAdapter("Select * From GetFis", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds);
            gridliste.DataSource = ds.Tables[0];
            con.Close();
        }

        private void ServisFis_Load(object sender, EventArgs e)
        {
            listele();

            var tipler = db.AO_ARACTIP.ToList();
            lookUpEdit1.Properties.ValueMember = "id";
            lookUpEdit1.Properties.DisplayMember = "Name";
            lookUpEdit1.Properties.DataSource = tipler;

            var kayit = db.AO_ARACKAYIT.ToList();
            lookUpEdit2.Properties.ValueMember = "id"; 
            lookUpEdit2.Properties.DisplayMember = "plaka";
            lookUpEdit2.Properties.DataSource = kayit;

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            AO_SERVISFIS ekle = new AO_SERVISFIS();
            ekle.FisNo = txtisim.Text;
            ekle.AracGetiren = txtgetiren.Text;
            ekle.Tarih = (DateTime)dateEdit1.EditValue;
            ekle.Aractip_id = (int)lookUpEdit1.EditValue;
            ekle.AracKayıt_id = (int)lookUpEdit2.EditValue;
            db.AO_SERVISFIS.Add(ekle);
            db.SaveChanges();
            XtraMessageBox.Show("Kayıt gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
    }
}