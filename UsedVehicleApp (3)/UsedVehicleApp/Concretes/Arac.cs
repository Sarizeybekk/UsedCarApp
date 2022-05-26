using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsedVehicleApp.Abstract;
using UsedVehicleApp.Concretes;

namespace UsedVehicleApp.Concretes
{
     public class Arac 
    {
        public int AracID { get; set; }
        public string AracTuru { get; set; }
        public DateTime UretimYili { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string YakitTuru { get; set; }
        public string Motor { get; set; }
        public string Sanziman { get; set; }
        public int Km { get; set; }
        public string Fiyat { get; set; }
        public string Resim { get; set; }
        public bool SisFari { get; set; }
        public bool KatlanabilirAyna { get; set; }
        public bool CamTavan { get; set; }
        public bool ParkSensoru { get; set; }
        public bool MerkeziKilit { get; set; }

       
       
    }
}
