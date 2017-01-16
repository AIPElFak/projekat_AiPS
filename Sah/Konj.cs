using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sah
{
    class Konj:Figura
    {
        public int pomeri(int kolona, int vrsta, int novaKolona, int novaVrsta, string napadnutaFigura)
        {
            if (napadnutaFigura != null && novaKolona == kolona - 2 && (novaVrsta == vrsta + 1 || novaVrsta == vrsta - 1))
            {
                return 2;
            }
            else if (napadnutaFigura != null && novaKolona == kolona - 1 && (novaVrsta == vrsta + 2 || novaVrsta == vrsta - 2))
            {
                return 2;
            }
            else if (napadnutaFigura != null && novaKolona == kolona + 1 && (novaVrsta == vrsta + 2 || novaVrsta == vrsta - 2))
            {
                return 2;
            }
            else if (napadnutaFigura != null && novaKolona == kolona + 2 && (novaVrsta == vrsta + 1 || novaVrsta == vrsta - 1))
            {
                return 2;
            }
            else
            if (novaKolona == kolona - 2 && (novaVrsta == vrsta + 1 || novaVrsta == vrsta - 1))
            {
                return 1;
            }
            else if (novaKolona == kolona - 1 && (novaVrsta == vrsta + 2 || novaVrsta == vrsta - 2))
            {
                return 1;
            }
            else if (novaKolona == kolona + 1 && (novaVrsta == vrsta + 2 || novaVrsta == vrsta - 2))
            {
                return 1;
            }
            else if (novaKolona == kolona + 2 && (novaVrsta == vrsta + 1 || novaVrsta == vrsta - 1))
            {
                return 1;
            }
            else return 0;
        }
    }
}