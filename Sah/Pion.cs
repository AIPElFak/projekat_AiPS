using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sah
{
    class Pion:Figura
    {
        public int pomeri(int kolona, int vrsta, int novaKolona, int novaVrsta, string napadnutaFigura)
        {
            if(napadnutaFigura != null && ((novaKolona==kolona+1 && novaVrsta==vrsta+1)||(novaKolona == kolona - 1 && novaVrsta == vrsta + 1)))
            {
                return 2;
            }
            if (kolona == novaKolona && vrsta == 2 && novaVrsta == 4 && napadnutaFigura==null)
                return 1;
            if (kolona == novaKolona && vrsta == (novaVrsta - 1) && napadnutaFigura!="pB1" && napadnutaFigura != "pB2"
                && napadnutaFigura != "pB3" && napadnutaFigura != "pB4" 
                && napadnutaFigura != "pB5" && napadnutaFigura != "pB6" 
                && napadnutaFigura != "pB7" && napadnutaFigura != "pB8"
                && napadnutaFigura != "pC1" && napadnutaFigura != "pC2"
                && napadnutaFigura != "pC3" && napadnutaFigura != "pC4"
                && napadnutaFigura != "pC5" && napadnutaFigura != "pC6"
                && napadnutaFigura != "pC7" && napadnutaFigura != "pC8")
            {
                return 1;
            }
            else
                return 0;
        }
    }
}