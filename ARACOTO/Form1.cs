using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ARACOTO
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnStokKaydi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmStokEkle kontrol = Application.OpenForms["FrmStokEkle"] as FrmStokEkle;
            if (kontrol != null) { kontrol.Focus(); }
            else
            {
                FrmStokEkle stokEkle = new FrmStokEkle();

                stokEkle.MdiParent = this;

                stokEkle.Show();
            }

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmMusteriEkle kontrol = Application.OpenForms["FrmMusteriEkle"] as FrmMusteriEkle;
            if (kontrol != null) { kontrol.Focus(); }
            else
            {
                FrmMusteriEkle musteriEkle = new FrmMusteriEkle();

                musteriEkle.MdiParent = this;

                musteriEkle.Show();
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmMalzemeEkle kontrol = Application.OpenForms["FrmMalzemeEkle"] as FrmMalzemeEkle;
            if (kontrol != null) { kontrol.Focus(); }
            else
            {
                FrmMalzemeEkle malzemeEkle = new FrmMalzemeEkle();

                malzemeEkle.MdiParent = this;

                malzemeEkle.Show();
            }
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            ServisFis kontrol = Application.OpenForms["ServisFis"] as ServisFis;
            if (kontrol != null) { kontrol.Focus(); }
            else
            {
                ServisFis servisfis = new ServisFis();
                servisfis.MdiParent = this;
                servisfis.Show();
            }
           
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAracKayit kontrol = Application.OpenForms["frmAracKayit"] as frmAracKayit;
            if (kontrol != null) { kontrol.Focus(); }
            else
            {
                frmAracKayit frmaarac = new frmAracKayit();
                frmaarac.MdiParent = this;
                frmaarac.Show();
            }

        }
    }
}
