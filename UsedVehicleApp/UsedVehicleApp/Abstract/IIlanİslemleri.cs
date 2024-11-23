using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsedVehicleApp.Abstract;
using UsedVehicleApp.Concretes;

namespace UsedVehicleApp.Abstract
{
   public  interface IIlanİslemleri
    {
        void IlanEkle(Arac arac);
        void IlanSil(Arac arac);
        void IlanGuncelle();
        void IlanDüzenle();
    }
}
