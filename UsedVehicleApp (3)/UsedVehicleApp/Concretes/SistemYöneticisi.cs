using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsedVehicleApp.Abstract;

namespace UsedVehicleApp.Concretes
{
    public class SistemYöneticisi : Uyeler,IIlanOnay,IIlanİslemleri
    {
        public int yoneticiID { get; set; }


        public override void girisYap(Uyeler uyeler)
        {
            if (uyeler.Ad == "Sultan" && uyeler.SoyAd == "Sarızeybek")
            {
                MessageBox.Show("Hoşgeldiniz Yönetici: \n " + "Ad:" + uyeler.Ad + "  \nSoyad: " + uyeler.SoyAd);
                
            }
            else {
                MessageBox.Show("Yönetici  bulunamadı");
            }
        }

        public void IlanEkle(Arac arac)
        {
            MessageBox.Show("İlan eklendi..");
        }

        public string IlanOnaylama()
        {
            throw new NotImplementedException();
        }

        public string OturmAc()
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
