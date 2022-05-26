using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsedVehicleApp.Concretes;
using UsedVehicleApp.Abstract;

namespace UsedVehicleApp
{
    public partial class Ilan : Form
    {
        public Ilan()
        {
            InitializeComponent();
        }

        SistemYöneticisi yönetici = new SistemYöneticisi();
        AracSahipleri aracSahibi = new AracSahipleri();


        private void btn_ekle_Click(object sender, EventArgs e)
        {
            
            try
            {
                Arac arac = new Arac();
                arac.Marka = txt_marka.Text;
                arac.Fiyat = txt_fiyat.Text;
                arac.AracTuru = txt_aracTürü.Text;
              yönetici.IlanEkle(arac);
                
            }
            catch(Exception ex)
            {
                throw ex;
            }

            
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            Arac arac = new Arac();
            arac.Marka = txt_marka.Text;
            arac.Fiyat = txt_fiyat.Text;
            arac.AracTuru = txt_aracTürü.Text;
            

            MessageBox.Show("İLAN BİLGİLERİ\n"+ "Marka: " + arac.Marka + "\n" + "Fiyat: " + arac.Fiyat+"\n" + "Tür: " + arac.AracTuru);
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            Arac arac = new Arac();
            arac.Marka = txt_marka.Text;
            yönetici.IlanSil(arac);
            
        }
    }
}
