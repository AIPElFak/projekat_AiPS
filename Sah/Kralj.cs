using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sah
{
    class Kralj
    {
        public int pomeri(int kolona, int vrsta, int novaKolona, int novaVrsta, string napadnutaFigura)
        {
            if ((novaKolona == kolona + 1 || novaKolona == kolona - 1) && napadnutaFigura != null)
            {
                if (novaVrsta == vrsta + 1)
                {
                    return 2;
                }
                else if (novaVrsta == vrsta)
                {
                    return 2;
                }
                else if (novaVrsta == vrsta - 1)
                {
                    return 2;
                }
                else return 0;
            }
            else if (novaKolona == kolona && napadnutaFigura != null)
            {
                if (novaVrsta == vrsta + 1)
                {
                    return 2;
                }
                else if (novaVrsta == vrsta - 1)
                {
                    return 2;
                }
                else return 0;
            }
            else
            //pomeranje
            if ((novaKolona == kolona + 1 || novaKolona == kolona - 1) && napadnutaFigura == null)
            {
                if (novaVrsta == vrsta + 1)
                {
                    return 1;
                }
                else if (novaVrsta == vrsta)
                {
                    return 1;
                }
                else if (novaVrsta == vrsta - 1)
                {
                    return 1;
                }
                else return 0;
            }
            else if(novaKolona == kolona && napadnutaFigura == null)
            {
                if (novaVrsta == vrsta + 1)
                {
                    return 1;
                }
                else if (novaVrsta == vrsta - 1)
                {
                    return 1;
                }
                else return 0;
            }
            else
                return 0;
        }
    }
}
