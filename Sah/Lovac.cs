using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sah
{
    class Lovac
    {
        public int pomeri(int kolona, int vrsta, int novaKolona, int novaVrsta, string napadnutaFigura)
        {
            int j = 0;
            if (novaKolona > kolona && novaVrsta > vrsta && napadnutaFigura != null)
            {
                for (int i = 1; i < novaKolona - kolona; i++)
                {
                    if (Figura.Instance().vratiFiguru(kolona + i, vrsta + i) != null)
                        return 0;
                    j = i;
                }
                j++;
                if (novaKolona == kolona + j && novaVrsta == vrsta + j)
                    return 2;
                else return 0;
            }
            else if (novaKolona > kolona && novaVrsta < vrsta && napadnutaFigura != null)
            {
                for (int i = 1; i < novaKolona - kolona; i++)
                {
                    if (Figura.Instance().vratiFiguru(kolona + i, vrsta - i) != null)
                        return 0;
                    j = i;
                }
                j++;
                if (novaKolona == kolona + j && novaVrsta == vrsta - j)
                    return 2;
                else return 0;
            }
            else if (novaKolona < kolona && novaVrsta > vrsta && napadnutaFigura != null)
            {
                for (int i = 1; i < kolona - novaKolona; i++)
                {
                    if (Figura.Instance().vratiFiguru(kolona - i, vrsta + i) != null)
                        return 0;
                    j = i;
                }
                j++;
                if (novaKolona == kolona - j && novaVrsta == vrsta + j)
                    return 2;
                else return 0;
            }
            else if (novaKolona < kolona && novaVrsta < vrsta && napadnutaFigura != null)
            {
                for (int i = 1; i < kolona - novaKolona; i++)
                {
                    if (Figura.Instance().vratiFiguru(kolona - i, vrsta - i) != null)
                        return 0;
                    j = i;
                }
                j++;
                if (novaKolona == kolona - j && novaVrsta == vrsta - j)
                    return 2;
                else return 0;
            }
            //kretanje
            
            else if (novaKolona>kolona && novaVrsta > vrsta && napadnutaFigura == null)
            {
                for(int i= 1;i<=novaKolona-kolona;i++)
                {
                    if (Figura.Instance().vratiFiguru(kolona + i, vrsta + i) != null)
                        return 0;
                    j = i;
                }
                if (novaKolona == kolona + j && novaVrsta == vrsta + j)
                    return 1;
                else return 0;
            }
            else if (novaKolona > kolona && novaVrsta < vrsta && napadnutaFigura == null)
            {
                for (int i = 1; i <= novaKolona - kolona; i++)
                {
                    if (Figura.Instance().vratiFiguru(kolona + i, vrsta - i) != null)
                        return 0;
                    j = i;
                }
                if (novaKolona == kolona + j && novaVrsta == vrsta - j)
                    return 1;
                else return 0;
            }
            else if (novaKolona < kolona && novaVrsta > vrsta && napadnutaFigura == null)
            {
                for (int i = 1; i <= kolona - novaKolona; i++)
                {
                    if (Figura.Instance().vratiFiguru(kolona - i, vrsta + i) != null)
                        return 0;
                    j = i;
                }
                if (novaKolona == kolona - j && novaVrsta == vrsta + j)
                    return 1;
                else return 0;
            }
            else if (novaKolona < kolona && novaVrsta < vrsta && napadnutaFigura == null)
            {
                for (int i = 1; i <= kolona - novaKolona; i++)
                {
                    if (Figura.Instance().vratiFiguru(kolona - i, vrsta - i) != null)
                        return 0;
                    j = i;
                }
                if (novaKolona == kolona - j && novaVrsta == vrsta - j)
                    return 1;
                else return 0;
            }
            else
                return 0;
        }
    }
}