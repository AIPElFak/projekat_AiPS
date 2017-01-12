using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sah
{
    public class Figura
    {
        static Figura instace;
        int kolona, vrsta;
        string figura;
        string[,] pozicija = new string[9, 9];
        private Figura()
        {
            pozicija[8, 4] = "pB1";
            pozicija[2, 2] = "pB2";
            pozicija[3, 2] = "pB3";
            pozicija[4, 2] = "pB4";
            pozicija[5, 2] = "pB5";
            pozicija[6, 2] = "pB6";
            pozicija[4, 6] = "pB7";
            pozicija[8, 2] = "pB8";
            pozicija[1, 7] = "pC1";
            pozicija[3, 5] = "pC2";
            pozicija[3, 1] = "pC3";
            pozicija[5, 3] = "pC4";
            pozicija[5, 7] = "pC5";
            pozicija[6, 7] = "pC6";
            pozicija[7, 7] = "pC7";
            pozicija[8, 7] = "pC8";
            pozicija[0, 0] = null;
        }
        public static Figura Instance()
        {
            if (instace == null)
            {
                instace = new Figura();
            }
            return instace;
        }

        public int kolonaZaFiguru(string s)
        {
            for (int a = 0; a < 9; a++)
            {
                for (int b = 0; b < 9; b++)
                {
                    if (pozicija[a, b] == s)
                    {
                        return a*60;
                    }
                   // else
                        //return 0;
                }
            }
            return 1000;
        }
        public int vrstaZaFiguru(string s)
        {
            for (int a = 0; a < 9; a++)
            {
                for (int b = 0; b < 9; b++)
                {
                    if (pozicija[a, b] == s)
                    {
                        return (9- b)*60;
                    }
                    //else
                       // return 1000;
                }
            }
            return 1000;
        }
        public string nazivFigure(int kliknutaKolona, int kliknutaVrsta, string imeFigure)
        {
            kolona = kliknutaKolona;
            vrsta = kliknutaVrsta;
            staraKolona();
            staraVrsta();
            figura = imeFigure;
            return figura;
        }
        public int staraKolona()
        {
            return kolona;
        }
        public int staraVrsta()
        {
            return vrsta;
        }
        public string odrediFiguru(int kliknutaDrugaKolona, int kliknutaDrugaVrsta)
        {
            if (figura == "pB1" || figura == "pB2" || figura == "pB3" || figura == "pB4" || figura == "pB5" || figura == "pB6" || figura == "pB7" || figura == "pB8")
            {
                Pion p = new Pion();
                if (p.pomeri(kolona, vrsta, kliknutaDrugaKolona, kliknutaDrugaVrsta, pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta]) == 1)
                {
                    return figura;
                }
                else if (p.pomeri(kolona, vrsta, kliknutaDrugaKolona, kliknutaDrugaVrsta, pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta]) == 2)
                {
                    if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "pC1")  // pC1 je napadnuta
                        return "pC1";  //ako je figutra napadnuta
                    if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "pC2")
                        return "pC2";
                    if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "pC3")
                        return "pC3";
                    if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "pC4")
                        return "pC4";
                    if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "pC5")
                        return "pC5";
                    if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "pC6")
                        return "pC6";
                    if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "pC7")
                        return "pC7";
                    if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "pC8")
                        return "pC8";
                    else return "0";
                }

                else return "0";
            }
            else
                 if (figura == "pC1" || figura == "pC2" || figura == "pC3" || figura == "pC4" || figura == "pC5" || figura == "pC6" || figura == "pC7" || figura == "pC8")
            {
                PionC p = new PionC();
                if (p.pomeri(kolona, vrsta, kliknutaDrugaKolona, kliknutaDrugaVrsta, pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta]) == 1)
                {
                    return figura;
                }
                else if (p.pomeri(kolona, vrsta, kliknutaDrugaKolona, kliknutaDrugaVrsta, pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta]) == 2)
                {
                    if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "pB1")  // pC1 je napadnuta
                        return "pB1";  //ako je figutra napadnuta
                    if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "pB2")
                        return "pB2";
                    if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "pB3")
                        return "pB3";
                    if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "pB4")
                        return "pB4";
                    if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "pB5")
                        return "pB5";
                    if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "pB6")
                        return "pB6";
                    if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "pB7")
                        return "pB7";
                    if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "pB8")
                        return "pB8";
                    else return "0";
                }

                else return "0";
            }
            else
                return "0";
        }

        public string createMatrix(int l, int m)
        {
            for (int a = 0; a < 9; a++)
            {
                for (int b = 0; b < 9; b++)
                {
                    if (a == l && b == m)
                    {
                        return pozicija[a, b];
                    }
                }
            }
            return "x";
        }
        public void zameni(int staraKolona, int staraVrsta, int novaKolona, int novaVrsta)
        {
            pozicija[novaKolona, novaVrsta] = pozicija[staraKolona, staraVrsta];
            pozicija[staraKolona, staraVrsta] = pozicija[0, 0];
        }
    }
}