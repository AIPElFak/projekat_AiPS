using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sah
{
    class PionC:Figura
    {
        public int pomeri(int kolona, int vrsta, int novaKolona, int novaVrsta, string napadnutaFigura)
        {
            if ((napadnutaFigura != null && ((novaKolona == kolona + 1 && novaVrsta == vrsta - 1 && novaVrsta == 1) || (novaKolona == kolona - 1 && novaVrsta == vrsta - 1 && novaVrsta == 1))) ||
                  (kolona == novaKolona && vrsta == (novaVrsta + 1) && napadnutaFigura == null && novaVrsta == 1))
            {
                return 3;
            }
            else
              if (napadnutaFigura != null && ((novaKolona == kolona + 1 && novaVrsta == vrsta - 1) || (novaKolona == kolona - 1 && novaVrsta == vrsta - 1)))
            {
                return 2;
            }
            if (kolona == novaKolona && vrsta == 7 && novaVrsta == 5 && Figura.Instance().vratiFiguru(kolona, 6) == null && napadnutaFigura == null)
                return 1;
            if (kolona == novaKolona && vrsta == (novaVrsta + 1) && napadnutaFigura == null)
            {
                return 1;
            }
            else
                return 0;
        }
    }
}