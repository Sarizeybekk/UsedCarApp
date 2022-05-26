  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedVehicleApp.Abstract
{
    public abstract class Uyeler
    {

        public string Ad { get; set; }

        public string SoyAd { get; set; }

        public string Eposta { get; set; }

        public string Sifre { get; set; }

        public abstract void girisYap(Uyeler uyeler);
    }
}
