using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsedVehicleApp.Abstract;

namespace UsedVehicleApp.Concretes
{
   public  class AracSahipleri : Uyeler,IUyeOl,IVitrinIlanIslemleri,IIlanİslemleri
    {
        public int AracSahibiID { get; set; }

        public string CıkısYap()
        {
            throw new NotImplementedException();
        }

        public override void girisYap(Uyeler uyeler)
        {
            if (uyeler.Ad == "hatice" && uyeler.SoyAd == "Ay")
            {
                MessageBox.Show("Hoşgeldiniz Arac Sahibi: \n " + "Ad:" + uyeler.Ad + "  \nSoyad: " + uyeler.SoyAd);
            }
            else
            {
                MessageBox.Show("Araç sahibi  bulunamadı");
            }
        }
        public void IlanEkle(Arac arac)
        {
            MessageBox.Show("İlan eklendi..");
        }


        public string OturmAc()
        {
            throw new NotImplementedException();
        }

        public string Uye(string eposta, string sifre)
        {
            throw new NotImplementedException();
        }

        public string VitrinAra()
        {
            throw new NotImplementedException();
        }

        public string VitrinIlanGoruntuleme()
        {
            throw new NotImplementedException();
        }

        public string YorumYap()
        {
            throw new NotImplementedException();
        }

        void IIlanİslemleri.IlanDüzenle()
        {
            throw new NotImplementedException();
        }

        void IIlanİslemleri.IlanGuncelle()
        {
            throw new NotImplementedException();
        }

        public void IlanSil(Arac arac)
        {
            MessageBox.Show("İlan silindi!");
        }
    }
}
