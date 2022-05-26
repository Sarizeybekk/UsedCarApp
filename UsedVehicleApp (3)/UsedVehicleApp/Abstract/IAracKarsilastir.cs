using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsedVehicleApp.Concretes;

namespace UsedVehicleApp.Abstract
{
     public interface IAracKarsilastir
    {
        string karsilastir(Arac arac1, Arac arac2);
    }
}
