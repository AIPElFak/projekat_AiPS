using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sah
{
    class Top : Figura
    {
        public int pomeri(int kolona, int vrsta, int novaKolona, int novaVrsta, string napadnutaFigura)
        {
            if (napadnutaFigura != null && (novaKolona == kolona || novaVrsta == vrsta ))
            {
                if (kolona == novaKolona)  //na gore
                {
                    if (vrsta < novaVrsta)
                    {
                        for (int i = vrsta + 1; i < novaVrsta; i++)
                        {
                            if (Figura.Instance().vratiFiguru(kolona, i) != null)
                                return 0;
                        }
                        return 2;
                    }
                    else // na dole
                    {
                        for (int i = vrsta - 1; i > novaVrsta; i--)
                        {
                            if (Figura.Instance().vratiFiguru(kolona, i) != null)
                                return 0;
                        }
                        return 2;
                    }
                }
                else if (vrsta == novaVrsta)  //desno
                {
                    if (kolona < novaKolona)
                    {
                        for (int i = kolona + 1; i < novaKolona; i++)
                        {
                            if (Figura.Instance().vratiFiguru(i, vrsta) != null)
                                return 0;
                        }
                        return 2;
                    }
                    else  //levo
                    {
                        for (int i = kolona - 1; i > novaKolona; i--)
                        {
                            if (Figura.Instance().vratiFiguru(i, vrsta) != null)
                                return 0;
                        }
                        return 2;
                    }
                }
            }
            else if ((kolona == novaKolona || vrsta == novaVrsta) && napadnutaFigura == null)
            {
                if (kolona == novaKolona)  //na gore
                {
                    if (vrsta < novaVrsta)
                    {
                        for (int i = vrsta + 1; i < novaVrsta; i++)
                        {
                            if (Figura.Instance().vratiFiguru(kolona, i) != null)
                                return 0;
                        }
                        return 1;
                    }
                    else // na dole
                    {
                        for (int i = vrsta - 1; i >= novaVrsta; i--)
                        {
                            if (Figura.Instance().vratiFiguru(kolona, i) != null)
                                return 0;
                        }
                        return 1;
                    }
                }

                else if (vrsta == novaVrsta)  //desno
                {
                    if (kolona < novaKolona)
                    {
                        for (int i = kolona + 1; i < novaKolona; i++)
                        {
                            if (Figura.Instance().vratiFiguru(i, vrsta) != null)
                                return 0;
                        }
                        return 1;
                    }
                    else  //levo
                    {
                        for (int i = kolona - 1; i >= novaKolona; i--)
                        {
                            if (Figura.Instance().vratiFiguru(i, vrsta) != null)
                                return 0;
                        }
                        return 1;
                    }
                }
            }
                return 0;
        }
    }
}