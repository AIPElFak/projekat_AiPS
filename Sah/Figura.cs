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
        string figura, novaFigura;
        string[,] pozicija = new string[11, 11];
        public Figura()
        {
            pozicija[1, 7] = "pB1";
            pozicija[2, 2] = "pB2";
            pozicija[3, 2] = "pB3";
            pozicija[4, 2] = "pB4";
            pozicija[5, 2] = "pB5";
            pozicija[6, 2] = "pB6";
            pozicija[7, 2] = "pB7";
            pozicija[8, 2] = "pB8";
            pozicija[1, 1] = "tB1";
            pozicija[8, 1] = "tB2";
            pozicija[2, 1] = "koB1";
            pozicija[7, 1] = "koB2";
            pozicija[3, 1] = "lB1";
            pozicija[6, 1] = "lB2";
            pozicija[4, 1] = "krB1";
            pozicija[5, 1] = "kB1";

            pozicija[1, 3] = "pC1";
            pozicija[2, 7] = "pC2";
            pozicija[3, 7] = "pC3";
            pozicija[4, 7] = "pC4";
            pozicija[5, 7] = "pC5";
            pozicija[6, 7] = "pC6";
            pozicija[7, 7] = "pC7";
            pozicija[8, 7] = "pC8";
            pozicija[1, 4] = "tC1";
            pozicija[8, 8] = "tC2";
            pozicija[2, 8] = "koC1";
            pozicija[7, 8] = "koC2";
            pozicija[3, 8] = "lC1";
            pozicija[6, 8] = "lC2";
            pozicija[4, 8] = "krC1";
            pozicija[5, 8] = "kC1";
            pozicija[0, 0] = null;
            pozicija[0, 1] = "zKrB";
            pozicija[0, 2] = "zKoB";
            pozicija[0, 3] = "zTB";
            pozicija[0, 4] = "zLB";
            pozicija[0, 5] = "zKrC";
            pozicija[0, 6] = "zKoC";
            pozicija[0, 7] = "zTC";
            pozicija[0, 8] = "zLC";
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
                        return a * 60;
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
                        return (9 - b) * 60;
                    }
                    //else
                    // return 1000;
                }
            }
            return 1000;
        }

        public string rtrnValC(int kliknutaDrugaKolona, int kliknutaDrugaVrsta)
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
            if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "tC1")
                return "tC1";
            if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "tC2")
                return "tC2";
            if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "koC1")
                return "koC1";
            if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "koC2")
                return "koC2";
            if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "lC1")
                return "lC1";
            if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "lC2")
                return "lC2";
            if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "krC1")
                return "krC1";
            if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "kC1")
                return "kC1";
            if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "zKrC")
                return "zKrC";
            if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "zKoC")
                return "zKoC";
            if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "zTC")
                return "zT";
            if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "zLC")
                return "zLC";
            else return "0";
        }
        public string rtrnValB(int kliknutaDrugaKolona, int kliknutaDrugaVrsta)
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
            if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "tB1")
                return "tB1";
            if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "tB2")
                return "tB2";
            if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "koB1")
                return "koB1";
            if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "koB2")
                return "koB2";
            if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "lB1")
                return "lB1";
            if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "lB2")
                return "lB2";
            if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "krB1")
                return "krB1";
            if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "kB1")
                return "kB1";
            if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "zKrB")
                return "zKrB";
            if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "zKoB")
                return "zKoB";
            if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "zTB")
                return "zTB";
            if (pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta] == "zLB")
                return "zLB";
            else return "0";
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
                    return rtrnValC(kliknutaDrugaKolona, kliknutaDrugaVrsta);
                }

                else if (p.pomeri(kolona, vrsta, kliknutaDrugaKolona, kliknutaDrugaVrsta, pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta]) == 3)
                {
                    return "izmeniPiona";
                }
                 else   return "0";
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
                    return rtrnValB(kliknutaDrugaKolona, kliknutaDrugaVrsta);
                }
                else if (p.pomeri(kolona, vrsta, kliknutaDrugaKolona, kliknutaDrugaVrsta, pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta]) == 3)
                {
                    return "izmeniPiona";
                }

                else return "0";
            }
            else if (figura == "tB1" || figura == "tB2" || figura=="zTB")
            {
                Top t = new Top();
                if (t.pomeri(kolona, vrsta, kliknutaDrugaKolona, kliknutaDrugaVrsta, pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta]) == 1)
                {
                    return figura;
                }
                else if (t.pomeri(kolona, vrsta, kliknutaDrugaKolona, kliknutaDrugaVrsta, pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta]) == 2)
                {
                    return rtrnValC(kliknutaDrugaKolona, kliknutaDrugaVrsta);
                }

                else return "0";
            }
            else if (figura == "tC1" || figura == "tC2" || figura=="zTC")
            {
                Top t = new Top();
                if (t.pomeri(kolona, vrsta, kliknutaDrugaKolona, kliknutaDrugaVrsta, pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta]) == 1)
                {
                    return figura;
                }
                else if (t.pomeri(kolona, vrsta, kliknutaDrugaKolona, kliknutaDrugaVrsta, pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta]) == 2)
                {
                    return rtrnValB(kliknutaDrugaKolona, kliknutaDrugaVrsta);
                }
                else return "0";
            }
            else if (figura == "koB1" || figura == "koB2" || figura == "zKoB")
            {
                Konj ko = new Konj();
                if (ko.pomeri(kolona, vrsta, kliknutaDrugaKolona, kliknutaDrugaVrsta, pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta]) == 1)
                {
                    return figura;
                }
                else if (ko.pomeri(kolona, vrsta, kliknutaDrugaKolona, kliknutaDrugaVrsta, pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta]) == 2)
                {
                    return rtrnValC(kliknutaDrugaKolona, kliknutaDrugaVrsta);
                }

                else return "0";
            }
            else if (figura == "koC1" || figura == "koC2" || figura=="zKoC")
            {
                Konj ko = new Konj();
                if (ko.pomeri(kolona, vrsta, kliknutaDrugaKolona, kliknutaDrugaVrsta, pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta]) == 1)
                {
                    return figura;
                }
                else if (ko.pomeri(kolona, vrsta, kliknutaDrugaKolona, kliknutaDrugaVrsta, pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta]) == 2)
                {
                    return rtrnValB(kliknutaDrugaKolona, kliknutaDrugaVrsta);
                }
                else return "0";
            }
            if (figura == "lB1" || figura == "lB2" || figura == "zLB" )
            {
                Lovac l = new Lovac();
                if (l.pomeri(kolona, vrsta, kliknutaDrugaKolona, kliknutaDrugaVrsta, pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta]) == 1)
                {
                    return figura;
                }
                else if (l.pomeri(kolona, vrsta, kliknutaDrugaKolona, kliknutaDrugaVrsta, pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta]) == 2)
                {
                    return rtrnValC(kliknutaDrugaKolona, kliknutaDrugaVrsta);
                }
                else return "0";
            }
            else if (figura == "lC1" || figura == "lC2" || figura == "zLC")
            {
                Lovac l = new Lovac();
                if (l.pomeri(kolona, vrsta, kliknutaDrugaKolona, kliknutaDrugaVrsta, pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta]) == 1)
                {
                    return figura;
                }
                else if (l.pomeri(kolona, vrsta, kliknutaDrugaKolona, kliknutaDrugaVrsta, pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta]) == 2)
                {
                    return rtrnValB(kliknutaDrugaKolona, kliknutaDrugaVrsta);
                }
                else return "0";
            }
            else if (figura == "krB1" || figura == "zKrB")
            {
                Lovac lk = new Lovac();
                Top tk = new Top();
                if (lk.pomeri(kolona, vrsta, kliknutaDrugaKolona, kliknutaDrugaVrsta, pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta]) == 1 ||
                    tk.pomeri(kolona, vrsta, kliknutaDrugaKolona, kliknutaDrugaVrsta, pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta]) == 1)
                {
                    return figura;
                }
                else if (lk.pomeri(kolona, vrsta, kliknutaDrugaKolona, kliknutaDrugaVrsta, pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta]) == 2 ||
                    tk.pomeri(kolona, vrsta, kliknutaDrugaKolona, kliknutaDrugaVrsta, pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta]) == 2)
                {
                    return rtrnValC(kliknutaDrugaKolona, kliknutaDrugaVrsta);
                }
                else return "0";
            }
            else if (figura == "krC1" || figura=="zKrC")
            {
                Lovac lk = new Lovac();
                Top tk = new Top();
                if (lk.pomeri(kolona, vrsta, kliknutaDrugaKolona, kliknutaDrugaVrsta, pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta]) == 1 ||
                    tk.pomeri(kolona, vrsta, kliknutaDrugaKolona, kliknutaDrugaVrsta, pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta]) == 1)
                {
                    return figura;
                }
                else if (lk.pomeri(kolona, vrsta, kliknutaDrugaKolona, kliknutaDrugaVrsta, pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta]) == 2 ||
                    tk.pomeri(kolona, vrsta, kliknutaDrugaKolona, kliknutaDrugaVrsta, pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta]) == 2)
                {
                    return rtrnValB(kliknutaDrugaKolona, kliknutaDrugaVrsta);
                }
                else return "0";
            }
            else if (figura == "kB1")
            {
                Kralj k = new Kralj();
                if (k.pomeri(kolona, vrsta, kliknutaDrugaKolona, kliknutaDrugaVrsta, pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta]) == 1)
                {
                    return figura;
                }
                else if (k.pomeri(kolona, vrsta, kliknutaDrugaKolona, kliknutaDrugaVrsta, pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta]) == 2)
                {
                    return rtrnValC(kliknutaDrugaKolona, kliknutaDrugaVrsta);
                }
                else return "0";
            }
            else if (figura == "kC1")
            {
                Kralj k = new Kralj();
                if (k.pomeri(kolona, vrsta, kliknutaDrugaKolona, kliknutaDrugaVrsta, pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta]) == 1)
                {
                    return figura;
                }
                else if (k.pomeri(kolona, vrsta, kliknutaDrugaKolona, kliknutaDrugaVrsta, pozicija[kliknutaDrugaKolona, kliknutaDrugaVrsta]) == 2)
                {
                    return rtrnValB(kliknutaDrugaKolona, kliknutaDrugaVrsta);
                }
                else return "0";
            }
            else return "0";
        }
        public string vratiFiguru(int l, int m)
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
            novaFigura = pozicija[novaKolona, novaVrsta];
            pozicija[novaKolona, novaVrsta] = pozicija[staraKolona, staraVrsta];
            pozicija[staraKolona, staraVrsta] = pozicija[0, 0];
        }
        public void izvrsiZamenu(int staraKolona, int staraVrsta, int novaKolona, int novaVrsta)
        {
            pozicija[staraKolona, staraVrsta] = pozicija[novaKolona, novaVrsta];
        }
        public void vratiZamenu(int staraKolona, int staraVrsta, int novaKolona, int novaVrsta)
        {
            pozicija[staraKolona, staraVrsta] = pozicija[novaKolona, novaVrsta];
            pozicija[novaKolona, novaVrsta] = novaFigura;
        }

        public int napadnutBeliKralj( int brojKolone, int brojVrste)
        {
                for (int i = 1; i < 9; i++)
                {
                    for (int j = 1; j < 9; j++)
                    {
                        if (pozicija[i, j] == "kB1")
                        {
                            if (pozicija[staraKolona(), staraVrsta()] == "kB1")
                            {
                                return nevalidanBeliPotezZaKralja(brojKolone, brojVrste);
                            }
                            else
                            {
                                zameni(staraKolona(), staraVrsta(), brojKolone, brojVrste);
                                if (nevalidanBeliPotezZaKralja(i,j) == 0)
                                {
                                    vratiZamenu(staraKolona(), staraVrsta(), brojKolone, brojVrste);
                                    return 0;
                                }
                                else
                                {
                                    vratiZamenu(staraKolona(), staraVrsta(), brojKolone, brojVrste);
                                    return 1;
                                }
                            //return nevalidanBeliPotezZaKralja(i, j);
                             }
                        }
                    }
                }
                return 1;
            }
        public int nevalidanBeliPotezZaKralja(int k, int v)
        {
            
            if (pozicija[k + 1, v + 1] == "pC1" || pozicija[k - 1, v + 1] == "pC1" || pozicija[k + 1, v + 1] == "pC2" || pozicija[k - 1, v + 1] == "pC2" ||
                pozicija[k + 1, v + 1] == "pC3" || pozicija[k - 1, v + 1] == "pC3" || pozicija[k + 1, v + 1] == "pC4" || pozicija[k - 1, v + 1] == "pC4" ||
                pozicija[k + 1, v + 1] == "pC5" || pozicija[k - 1, v + 1] == "pC5" || pozicija[k + 1, v + 1] == "pC6" || pozicija[k - 1, v + 1] == "pC6" ||
                pozicija[k + 1, v + 1] == "pC7" || pozicija[k - 1, v + 1] == "pC7" || pozicija[k + 1, v + 1] == "pC8" || pozicija[k - 1, v + 1] == "pC8")
                return 0;
            else if (pozicija[Math.Abs(k - 2), v - 1] == "koC1" || pozicija[Math.Abs(k - 2), v - 1] == "koC2" || pozicija[Math.Abs(k - 2), v + 1] == "koC1" || pozicija[Math.Abs(k - 2), v + 1] == "koC2" || pozicija[k - 1, Math.Abs(v - 2)] == "koC1" ||
                pozicija[k - 1, Math.Abs(v - 2)] == "koC2" || pozicija[k - 1, v + 2] == "koC1" || pozicija[k - 1, v + 2] == "koC2" || pozicija[k + 1, Math.Abs(v - 2)] == "koC1" || pozicija[k + 1, Math.Abs(v - 2)] == "koC2" ||
                pozicija[k + 1, v + 2] == "koC1" || pozicija[k + 1, v + 2] == "koC2" || pozicija[k + 2, v - 1] == "koC1" || pozicija[k + 2, v - 1] == "koC2" || pozicija[k + 2, v + 1] == "koC1" ||
                pozicija[k + 2, v + 1] == "koC2" || pozicija[Math.Abs(k - 2), v - 1] == "zKoC" || pozicija[Math.Abs(k - 2), v + 1] == "zKoC" || pozicija[k - 1, Math.Abs(v - 2)] == "zKoC" || pozicija[k + 1, Math.Abs(v - 2)] == "zKoC" ||
                pozicija[k - 1, v + 2] == "zKoC" || pozicija[k + 1, v + 2] == "zKoC" || pozicija[k + 2, v - 1] == "zKoC" || pozicija[k + 2, v + 1] == "zKoC")
                return 0;
            else
            {
                for (int i = 2; ((k + i) < 9 && (v + i) < 9 && pozicija[k + i - 1, v + i - 1] == null); i++)
                {
                    if (pozicija[k + i, v + i] == "krC1" || pozicija[k + i, v + i] == "zKrC" || pozicija[k + i, v + i] == "lC1" || pozicija[k + i, v + i] == "lC2" || pozicija[k + i, v + i] == "zLC")
                        return 0;
                    if (rtrnValC((k + i), (v + i)) != "0")
                    {
                        continue;
                    }

                }
                for (int i = 2; ((k - i) > 0 && (v + i) < 9 && pozicija[k - i + 1, v + i - 1] == null); i++)
                {
                    if (pozicija[k - i, v + i] == "krC1" || pozicija[k - i, v + i] == "zKrC" || pozicija[k - i, v + i] == "lC1" || pozicija[k - i, v + i] == "lC2" || pozicija[k - i, v + i] == "zLC")
                        return 0;
                    if (rtrnValC((k - i), (v + i)) != "0")
                        continue;
                }
                for (int i = 2; ((k - i) > 0 && (v - i) > 0 && pozicija[k - i + 1, v - i + 1] == null); i++)
                {
                    if ( pozicija[k - i, v - i] == "krC1" || pozicija[k - i, v - i] == "zKrC" || pozicija[k - i, v - i] == "lC1" || pozicija[k - i, v - i] == "lC2" || pozicija[k - i, v - i] == "zLC")
                        return 0;
                    if (rtrnValC((k - i), (v - i)) != "0")
                        continue;
                }
                for (int i = 2; ((k + i) < 9 && (v - i) > 0 && pozicija[k + i - 1, v - i + 1] == null); i++)
                {
                    if (pozicija[k + i, v - i] == "krC1" || pozicija[k + i, v - i] == "zKrC" || pozicija[k + i, v - i] == "lC1" || pozicija[k + i, v - i] == "lC2" || pozicija[k + i, v - i] == "zLC")
                        return 0;
                    if (rtrnValC((k + i), (v - i)) != "0")
                        continue;
                }

                for (int i = 2; ((k + i) < 9 && pozicija[k + i - 1, v] == null); i++)
                {
                    if (pozicija[k + i, v] == "krC1" || pozicija[k + i, v] == "zKrC" || pozicija[k + i, v] == "tC1" || pozicija[k + i, v] == "tC2" || pozicija[k + i, v] == "zTC")
                        return 0;
                    if (rtrnValC((k + i), (v)) != "0")
                        continue;
                }
                for (int i = 2; ((k - i) > 0 && pozicija[k - i + 1, v] == null); i++)
                {
                    if (pozicija[k - i, v] == "krC1" || pozicija[k - i, v] == "zKrC" || pozicija[k - i, v] == "tC1" || pozicija[k - i, v] == "tC2" || pozicija[k - i, v] == "zTC")
                        return 0;
                    if (rtrnValC((k - i), (v)) != "0")
                        continue;
                }
                for (int i = 2; ((v - i) > 0 && pozicija[k, v - i + 1] == null); i++)
                {
                    if (pozicija[k, v - i] == "krC1" || pozicija[k, v - i] == "zKrC" || pozicija[k, v - i - 1] == "tC1" || pozicija[k, v - i] == "tC2" || pozicija[k, v - i] == "zTC")
                        return 0;
                    if (rtrnValC((k), (v - i)) != "0")
                        continue;
                }
                for (int i = 2; ((v + i) < 9 && pozicija[k, v + i - 1] == null); i++)
                {
                    if (pozicija[k, v + i] == "krC1" || pozicija[k, v + i] == "zKrC" || pozicija[k, v + i] == "tC1" || pozicija[k, v + i] == "tC2" || pozicija[k, v + i] == "zTC")
                        return 0;
                    if (rtrnValC((k), (v + i)) != "0")
                        continue;
                }
                if (pozicija[k - 1, v + 1] == "krC1" || pozicija[k - 1, v + 1] == "zKrC" || pozicija[k - 1, v + 1] == "lC1" || pozicija[k - 1, v + 1] == "lC2" || pozicija[k - 1, v + 1] == "tC1" || pozicija[k - 1, v + 1] == "tC2" || pozicija[k - 1, v + 1] == "zTC" || pozicija[k - 1, v + 1] == "zLC" ||
                    pozicija[k - 1, v] == "krC1" || pozicija[k - 1, v] == "zKrC" || pozicija[k - 1, v] == "lC1" || pozicija[k - 1, v] == "lC2" || pozicija[k - 1, v] == "tC1" || pozicija[k - 1, v] == "tC2" || pozicija[k - 1, v] == "zTC" || pozicija[k - 1, v] == "zLC" ||
                    pozicija[k - 1, v - 1] == "krC1" || pozicija[k - 1, v - 1] == "zKrC" || pozicija[k - 1, v - 1] == "lC1" || pozicija[k - 1, v - 1] == "lC2" || pozicija[k - 1, v - 1] == "tC1" || pozicija[k - 1, v - 1] == "tC2" || pozicija[k - 1, v - 1] == "zTC" || pozicija[k - 1, v - 1] == "zLC" ||
                    pozicija[k, v + 1] == "krC1" || pozicija[k, v + 1] == "zKrC" || pozicija[k, v + 1] == "lC1" || pozicija[k, v + 1] == "lC2" || pozicija[k, v + 1] == "tC1" || pozicija[k, v + 1] == "tC2" || pozicija[k, v + 1] == "zTC" || pozicija[k, v + 1] == "zLC" ||
                    pozicija[k, v - 1] == "krC1" || pozicija[k, v - 1] == "zKrC" || pozicija[k, v - 1] == "lC1" || pozicija[k, v - 1] == "lC2" || pozicija[k, v - 1] == "tC1" || pozicija[k, v - 1] == "tC2" || pozicija[k, v - 1] == "zTC" || pozicija[k, v - 1] == "zLC" ||
                    pozicija[k + 1, v + 1] == "krC1" || pozicija[k + 1, v + 1] == "zKrC" || pozicija[k + 1, v + 1] == "lC1" || pozicija[k + 1, v + 1] == "lC2" || pozicija[k + 1, v + 1] == "tC1" || pozicija[k + 1, v + 1] == "tC2" || pozicija[k + 1, v + 1] == "zTC" || pozicija[k + 1, v + 1] == "zLC" ||
                    pozicija[k + 1, v] == "krC1" || pozicija[k + 1, v] == "zKrC" || pozicija[k + 1, v] == "lC1" || pozicija[k + 1, v] == "lC2" || pozicija[k + 1, v] == "tC1" || pozicija[k + 1, v] == "tC2" || pozicija[k + 1, v] == "zTC" || pozicija[k + 1, v] == "zLC" ||
                    pozicija[k + 1, v - 1] == "krC1" || pozicija[k + 1, v - 1] == "zKrC" || pozicija[k + 1, v - 1] == "lC1" || pozicija[k + 1, v - 1] == "lC2" || pozicija[k + 1, v - 1] == "tC1" || pozicija[k + 1, v - 1] == "tC2" || pozicija[k + 1, v - 1] == "zTC" || pozicija[k + 1, v - 1] == "zLC")
                    return 0;
                return 1;
            }
        }

        public int napadnutCrniKralj(int brojKolone, int brojVrste)
        {
            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    if (pozicija[i, j] == "kC1")
                    {
                        if (pozicija[staraKolona(), staraVrsta()] == "kC1")
                        {
                            return nevalidanCrniPotezZaKralja(brojKolone, brojVrste);
                        }
                        else
                        {
                            zameni(staraKolona(), staraVrsta(), brojKolone, brojVrste);
                            if (nevalidanCrniPotezZaKralja(i, j) == 0)
                            {
                                vratiZamenu(staraKolona(), staraVrsta(), brojKolone, brojVrste);
                                return 0;
                            }
                            else
                            {
                                vratiZamenu(staraKolona(), staraVrsta(), brojKolone, brojVrste);
                                return 1;
                            }
                            //return nevalidanBeliPotezZaKralja(i, j);
                        }
                    }
                }
            }
            return 1;
        }
        public int nevalidanCrniPotezZaKralja(int k, int v)
        {
            if (pozicija[k + 1, v - 1] == "pB1" || pozicija[k - 1, v - 1] == "pB1" || pozicija[k + 1, v - 1] == "pB2" || pozicija[k - 1, v - 1] == "pB2" ||
               pozicija[k + 1, v - 1] == "pB3" || pozicija[k - 1, v - 1] == "pB3" || pozicija[k + 1, v - 1] == "pB4" || pozicija[k - 1, v - 1] == "pB4" ||
               pozicija[k + 1, v - 1] == "pB5" || pozicija[k - 1, v - 1] == "pB5" || pozicija[k + 1, v - 1] == "pB6" || pozicija[k - 1, v - 1] == "pB6" ||
               pozicija[k + 1, v - 1] == "pB7" || pozicija[k - 1, v - 1] == "pB7" || pozicija[k + 1, v - 1] == "pB8" || pozicija[k - 1, v - 1] == "pB8")
                return 0;
            else if (pozicija[Math.Abs(k - 2), v - 1] == "koB1" || pozicija[Math.Abs(k - 2), v - 1] == "koB2" || pozicija[Math.Abs(k - 2), v + 1] == "koB1" || pozicija[Math.Abs(k - 2), v + 1] == "koB2" || pozicija[k - 1, Math.Abs(v - 2)] == "koB1" ||
                pozicija[k - 1, Math.Abs(v - 2)] == "koB2" || pozicija[k - 1, v + 2] == "koB1" || pozicija[k - 1, v + 2] == "koB2" || pozicija[k + 1, Math.Abs(v - 2)] == "koB1" || pozicija[k + 1, Math.Abs(v - 2)] == "koB2" ||
                pozicija[k + 1, v + 2] == "koB1" || pozicija[k + 1, v + 2] == "koB2" || pozicija[k + 2, v - 1] == "koB1" || pozicija[k + 2, v - 1] == "koB2" || pozicija[k + 2, v + 1] == "koB1" ||
                pozicija[k + 2, v + 1] == "koB2" || pozicija[Math.Abs(k - 2), v - 1] == "zKoB" || pozicija[Math.Abs(k - 2), v + 1] == "zKoB" || pozicija[k - 1, Math.Abs(v - 2)] == "zKoB" || pozicija[k + 1, Math.Abs(v - 2)] == "zKoB" ||
                pozicija[k - 1, v + 2] == "zKoB" || pozicija[k + 1, v + 2] == "zKoB" || pozicija[k + 2, v - 1] == "zKoB" || pozicija[k + 2, v + 1] == "zKoB")
                return 0;
            else
            {
                for (int i = 2; ((k + i) < 9 && (v + i) < 9 && pozicija[k + i - 1, v + i - 1] == null); i++)
                {
                    if (pozicija[k + i, v + i] == "krB1" || pozicija[k + i, v + i] == "zKrB" || pozicija[k + i, v + i] == "lB1" || pozicija[k + i, v + i] == "lB2" || pozicija[k + i, v + i] == "zLB")
                        return 0;
                    if (rtrnValC((k + i), (v + i)) != "0")
                    {
                        continue;
                    }

                }
                for (int i = 2; ((k - i) > 0 && (v + i) < 9 && pozicija[k - i + 1, v + i - 1] == null); i++)
                {
                    if (pozicija[k - i, v + i] == "krB1"|| pozicija[k - i, v + i] == "zKrB" || pozicija[k - i, v + i] == "lB1" || pozicija[k - i, v + i] == "lB2" || pozicija[k - i, v + i] == "zLB")
                        return 0;
                    if (rtrnValC((k - i), (v + i)) != "0")
                        continue;
                }
                for (int i = 2; ((k - i) > 0 && (v - i) > 0 && pozicija[k - i + 1, v - i + 1] == null); i++)
                {
                    if (pozicija[k - i, v - i] == "krB1" || pozicija[k - i, v - i] == "zKrB" || pozicija[k - i, v - i] == "lB1" || pozicija[k - i, v - i] == "lB2" || pozicija[k - i, v - i] == "zLB")
                        return 0;
                    if (rtrnValC((k - i), (v - i)) != "0")
                        continue;
                }
                for (int i = 2; ((k + i) < 9 && (v - i) > 0 && pozicija[k + i - 1, v - i + 1] == null); i++)
                {
                    if (pozicija[k + i, v - i] == "krB1"|| pozicija[k + i, v - i] == "zKrB" || pozicija[k + i, v - i] == "lB1" || pozicija[k + i, v - i] == "lB2" || pozicija[k + i, v - i] == "zLB")
                        return 0;
                    if (rtrnValC((k + i), (v - i)) != "0")
                        continue;
                }

                for (int i = 2; ((k + i) < 9 && pozicija[k + i - 1, v] == null); i++)
                {
                    if (pozicija[k + i, v] == "krB1" || pozicija[k + i, v] == "zKrB" || pozicija[k + i, v] == "tB1" || pozicija[k + i, v] == "tB2" || pozicija[k + i, v] == "zTB")
                        return 0;
                    if (rtrnValC((k + i), (v)) != "0")
                        continue;
                }
                for (int i = 2; ((k - i) > 0 && pozicija[k - i + 1, v] == null); i++)
                {
                    if (pozicija[k - i, v] == "krB1" || pozicija[k - i, v] == "zKrB" || pozicija[k - i, v] == "tB1" || pozicija[k - i, v] == "tB2" || pozicija[k - i, v] == "zTB")
                        return 0;
                    if (rtrnValC((k - i), (v)) != "0")
                        continue;
                }
                for (int i = 2; ((v - i) > 0 && pozicija[k, v - i + 1] == null); i++)
                {
                    if (pozicija[k, v - i] == "krB1" || pozicija[k, v - i] == "zKrB" || pozicija[k, v - i - 1] == "tB1" || pozicija[k, v - i] == "tB2" || pozicija[k , v-i] == "zTB")
                        return 0;
                    if (rtrnValC((k), (v - i)) != "0")
                        continue;
                }
                for (int i = 2; ((v + i) < 9 && pozicija[k, v + i - 1] == null); i++)
                {
                    if (pozicija[k, v + i] == "krB1" || pozicija[k , v + i] == "zKrB" || pozicija[k, v + i] == "tB1" || pozicija[k, v + i] == "tB2" || pozicija[k , v+i] == "zTB")
                        return 0;
                    if (rtrnValC((k), (v + i)) != "0")
                        continue;
                }
                if (pozicija[k - 1, v + 1] == "krB1" || pozicija[k - 1, v + 1] == "zKrB" || pozicija[k - 1, v + 1] == "lB1" || pozicija[k - 1, v + 1] == "lB2" || pozicija[k - 1, v + 1] == "tB1" || pozicija[k - 1, v + 1] == "tB2" || pozicija[k - 1, v + 1] == "zTB" || pozicija[k - 1, v + 1] == "zLB" ||
                    pozicija[k - 1, v] == "krB1" || pozicija[k - 1, v ] == "zKrB" || pozicija[k - 1, v] == "lB1" || pozicija[k - 1, v] == "lB2" || pozicija[k - 1, v] == "tB1" || pozicija[k - 1, v] == "tB2" || pozicija[k - 1, v] == "zTB" || pozicija[k - 1, v] == "zLB" ||
                    pozicija[k - 1, v - 1] == "krB1" || pozicija[k - 1, v - 1] == "zKrB" || pozicija[k - 1, v - 1] == "lB1" || pozicija[k - 1, v - 1] == "lB2" || pozicija[k - 1, v - 1] == "tB1" || pozicija[k - 1, v - 1] == "tB2" || pozicija[k - 1, v - 1] == "zTB" || pozicija[k - 1, v - 1] == "zLB" ||
                    pozicija[k, v + 1] == "krB1" || pozicija[k , v + 1] == "zKrB" || pozicija[k, v + 1] == "lB1" || pozicija[k, v + 1] == "lB2" || pozicija[k, v + 1] == "tB1" || pozicija[k, v + 1] == "tB2" || pozicija[k, v + 1] == "zTB" || pozicija[k, v + 1] == "zLB" ||
                    pozicija[k, v - 1] == "krB1" || pozicija[k , v - 1] == "zKrB" || pozicija[k, v - 1] == "lB1" || pozicija[k, v - 1] == "lB2" || pozicija[k, v - 1] == "tB1" || pozicija[k, v - 1] == "tB2" || pozicija[k, v - 1] == "zTB" || pozicija[k, v - 1] == "zLB" ||
                    pozicija[k + 1, v + 1] == "krB1" || pozicija[k + 1, v + 1] == "zKrB" || pozicija[k + 1, v + 1] == "lB1" || pozicija[k + 1, v + 1] == "lB2" || pozicija[k + 1, v + 1] == "tB1" || pozicija[k + 1, v + 1] == "tB2" || pozicija[k + 1, v + 1] == "zTB" || pozicija[k + 1, v + 1] == "zLB" ||
                    pozicija[k + 1, v] == "krB1" || pozicija[k + 1, v ] == "zKrB" || pozicija[k + 1, v] == "lB1" || pozicija[k + 1, v] == "lB2" || pozicija[k + 1, v] == "tB1" || pozicija[k + 1, v] == "tB2" || pozicija[k + 1, v] == "zTB" || pozicija[k + 1, v] == "zLB" ||
                    pozicija[k + 1, v - 1] == "krB1" || pozicija[k + 1, v - 1] == "zKrB" || pozicija[k + 1, v - 1] == "lB1" || pozicija[k + 1, v - 1] == "lB2" || pozicija[k + 1, v - 1] == "tB1" || pozicija[k + 1, v - 1] == "tB2" || pozicija[k + 1, v - 1] == "zTB" || pozicija[k + 1, v - 1] == "zLB")
                    return 0;
                return 1;
            }
        }
        //string broj;
        
    }
}