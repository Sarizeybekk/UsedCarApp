using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsedVehicleApp.Abstract;

namespace UsedVehicleApp.Concretes
{
    public class Musteri: Uyeler,IUyeOl,IVitrinIlanIslemleri,IAracKarsilastir,IYorumYap
    {

        public int MusteriId { get; set; }

        public override void girisYap(Uyeler uyeler)
        {
            if (uyeler.Ad == "Emel" && uyeler.SoyAd == "Ay")
            {
                MessageBox.Show("Hoşgeldiniz Müşteri: \n "+"Ad:"+ uyeler.Ad + "  \nSoyad: " + uyeler.SoyAd);
            }else
            {
                MessageBox.Show("Müşteri  bulunamadı");
            }
        }


        public string karsilastir(Arac arac1, Arac arac2)
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

    }
}
