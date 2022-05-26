using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsedVehicleApp.Abstract;

namespace UsedVehicleApp.Concretes
{
    public class Vitrinİlan :  IVitrinIlanIslemleri
    {
       public List<Arac> AracListesi { get; set; }

        public string VitrinAra()
        {
            throw new NotImplementedException();
        }

        public string VitrinIlanGoruntuleme()
        {
            throw new NotImplementedException();
        }
    }
}
