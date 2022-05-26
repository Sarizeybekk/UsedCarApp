using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsedVehicleApp.Abstract;
using UsedVehicleApp.Concretes;

namespace UsedVehicleApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Musteri musteri = new Musteri();
        SistemYöneticisi yönetici = new SistemYöneticisi();
        AracSahipleri aracSahibi = new AracSahipleri();

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public void girisKontrol(Uyeler uyeler)
        {
            uyeler.Ad = txt_ad.Text;
            uyeler.SoyAd = txt_soyad.Text;
            uyeler.girisYap(uyeler);
        }

        
       
        private void btn_db_Click(object sender, EventArgs e)
        {
            ConnSingleton dbConnectionSingleton = ConnSingleton.getDbInstance();
            dbConnectionSingleton.GetDBConnection();
        }

        private void btn_sahip_giris_Click(object sender, EventArgs e)
        {
            girisKontrol(aracSahibi);
            
            Ilan frm = new Ilan();
            frm.Show();
        }

        private void btn_yönetici_girisi_Click(object sender, EventArgs e)
        {
            girisKontrol(yönetici);
            
            Ilan frm = new Ilan();
            frm.Show();
        }

        private void btn_giris_musteri_Click(object sender, EventArgs e)
        {
            girisKontrol(musteri);
  
            MusteriGiris  frm = new  MusteriGiris();
            frm.Show();
        }
    }
}
