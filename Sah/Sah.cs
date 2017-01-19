using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sah
{
    public partial class Sah : Form
    {
        public Sah()
        {
            InitializeComponent();
     
            pB1.Image = Properties.Resources.pion;
            pB2.Image = Properties.Resources.pion;
            pB3.Image = Properties.Resources.pion;
            pB4.Image = Properties.Resources.pion;
            pB5.Image = Properties.Resources.pion;
            pB6.Image = Properties.Resources.pion;
            pB7.Image = Properties.Resources.pion;
            pB8.Image = Properties.Resources.pion;
            tB1.Image = Properties.Resources.top;
            tB2.Image = Properties.Resources.top;
            koB1.Image = Properties.Resources.konj;
            koB2.Image = Properties.Resources.konj;
            lB1.Image = Properties.Resources.lovac;
            lB2.Image = Properties.Resources.lovac;
            krB1.Image = Properties.Resources.kraljica;
            kB1.Image = Properties.Resources.kralj;

            pC1.Image = Properties.Resources.pionc;
            pC2.Image = Properties.Resources.pionc;
            pC3.Image = Properties.Resources.pionc;
            pC4.Image = Properties.Resources.pionc;
            pC5.Image = Properties.Resources.pionc;
            pC6.Image = Properties.Resources.pionc;
            pC7.Image = Properties.Resources.pionc;
            pC8.Image = Properties.Resources.pionc;
            tC1.Image = Properties.Resources.topc;
            tC2.Image = Properties.Resources.topc;
            koC1.Image = Properties.Resources.konjc;
            koC2.Image = Properties.Resources.konjc;
            lC1.Image = Properties.Resources.lovacc;
            lC2.Image = Properties.Resources.lovacc;
            krC1.Image = Properties.Resources.kraljicac;
            kC1.Image = Properties.Resources.kraljc;
        }

        static Tabla t = new Tabla(60, 60);
        private void Sah_Paint(object sender, PaintEventArgs e)
        {
            Graphics o = CreateGraphics();
            Brush black = new SolidBrush(Color.Black);
            Brush red = new SolidBrush(Color.Yellow);
            Brush green = new SolidBrush(Color.Green);
            Pen red1 = new Pen(Color.Red);
            o.FillRectangle(green, t.sirinaX() / 3 * 2, t.visinaY(), t.sirinaX() / 3, t.visinaY() * 8);
            o.FillRectangle(green, t.sirinaX() / 3 * 2, t.visinaY() * 9, t.sirinaX() * 8 + t.sirinaX() / 3, t.sirinaX() / 3);
            int k = 0;
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    k++;
                    if (k % 2 == 0 && i % 2 == 0)
                        o.FillRectangle(red, i * t.sirinaX(), j * t.visinaY(), t.sirinaX(), t.visinaY());
                    else if (k % 2 != 0 && i % 2 == 0)
                        o.FillRectangle(black, i * t.sirinaX(), j * t.visinaY(), t.sirinaX(), t.visinaY());
                    else if (k % 2 == 0 && i % 2 != 0)
                        o.FillRectangle(black, i * t.sirinaX(), j * t.visinaY(), t.sirinaX(), t.visinaY());
                    else if (k % 2 != 0 && i % 2 != 0)
                        o.FillRectangle(red, i * t.sirinaX(), j * t.visinaY(), t.sirinaX(), t.visinaY());
                }
            }
            pB1.Location = new Point(Figura.Instance().kolonaZaFiguru("pB1"), Figura.Instance().vrstaZaFiguru("pB1"));
            pB2.Location = new Point(Figura.Instance().kolonaZaFiguru("pB2"), Figura.Instance().vrstaZaFiguru("pB2"));
            pB3.Location = new Point(Figura.Instance().kolonaZaFiguru("pB3"), Figura.Instance().vrstaZaFiguru("pB3"));
            pB4.Location = new Point(Figura.Instance().kolonaZaFiguru("pB4"), Figura.Instance().vrstaZaFiguru("pB4"));
            pB5.Location = new Point(Figura.Instance().kolonaZaFiguru("pB5"), Figura.Instance().vrstaZaFiguru("pB5"));
            pB6.Location = new Point(Figura.Instance().kolonaZaFiguru("pB6"), Figura.Instance().vrstaZaFiguru("pB6"));
            pB7.Location = new Point(Figura.Instance().kolonaZaFiguru("pB7"), Figura.Instance().vrstaZaFiguru("pB7"));
            pB8.Location = new Point(Figura.Instance().kolonaZaFiguru("pB8"), Figura.Instance().vrstaZaFiguru("pB8"));
            tB1.Location = new Point(Figura.Instance().kolonaZaFiguru("tB1"), Figura.Instance().vrstaZaFiguru("tB1"));
            tB2.Location = new Point(Figura.Instance().kolonaZaFiguru("tB2"), Figura.Instance().vrstaZaFiguru("tB2"));
            koB1.Location = new Point(Figura.Instance().kolonaZaFiguru("koB1"), Figura.Instance().vrstaZaFiguru("koB1"));
            koB2.Location = new Point(Figura.Instance().kolonaZaFiguru("koB2"), Figura.Instance().vrstaZaFiguru("koB2"));
            lB1.Location = new Point(Figura.Instance().kolonaZaFiguru("lB1"), Figura.Instance().vrstaZaFiguru("lB1"));
            lB2.Location = new Point(Figura.Instance().kolonaZaFiguru("lB2"), Figura.Instance().vrstaZaFiguru("lB2"));
            krB1.Location = new Point(Figura.Instance().kolonaZaFiguru("krB1"), Figura.Instance().vrstaZaFiguru("krB1"));
            kB1.Location = new Point(Figura.Instance().kolonaZaFiguru("kB1"), Figura.Instance().vrstaZaFiguru("kB1"));

            pC1.Location = new Point(Figura.Instance().kolonaZaFiguru("pC1"), Figura.Instance().vrstaZaFiguru("pC1"));
            pC2.Location = new Point(Figura.Instance().kolonaZaFiguru("pC2"), Figura.Instance().vrstaZaFiguru("pC2"));
            pC3.Location = new Point(Figura.Instance().kolonaZaFiguru("pC3"), Figura.Instance().vrstaZaFiguru("pC3"));
            pC4.Location = new Point(Figura.Instance().kolonaZaFiguru("pC4"), Figura.Instance().vrstaZaFiguru("pC4"));
            pC5.Location = new Point(Figura.Instance().kolonaZaFiguru("pC5"), Figura.Instance().vrstaZaFiguru("pC5"));
            pC6.Location = new Point(Figura.Instance().kolonaZaFiguru("pC6"), Figura.Instance().vrstaZaFiguru("pC6"));
            pC7.Location = new Point(Figura.Instance().kolonaZaFiguru("pC7"), Figura.Instance().vrstaZaFiguru("pC7"));
            pC8.Location = new Point(Figura.Instance().kolonaZaFiguru("pC8"), Figura.Instance().vrstaZaFiguru("pC8"));
            tC1.Location = new Point(Figura.Instance().kolonaZaFiguru("tC1"), Figura.Instance().vrstaZaFiguru("tC1"));
            tC2.Location = new Point(Figura.Instance().kolonaZaFiguru("tC2"), Figura.Instance().vrstaZaFiguru("tC2"));
            koC1.Location = new Point(Figura.Instance().kolonaZaFiguru("koC1"), Figura.Instance().vrstaZaFiguru("koC1"));
            koC2.Location = new Point(Figura.Instance().kolonaZaFiguru("koC2"), Figura.Instance().vrstaZaFiguru("koC2"));
            lC1.Location = new Point(Figura.Instance().kolonaZaFiguru("lC1"), Figura.Instance().vrstaZaFiguru("lC1"));
            lC2.Location = new Point(Figura.Instance().kolonaZaFiguru("lC2"), Figura.Instance().vrstaZaFiguru("lC2"));
            krC1.Location = new Point(Figura.Instance().kolonaZaFiguru("krC1"), Figura.Instance().vrstaZaFiguru("krC1"));
            kC1.Location = new Point(Figura.Instance().kolonaZaFiguru("kC1"), Figura.Instance().vrstaZaFiguru("kC1"));
        }
        
        int brojKlika = 1;
        String prvaFigura;
        private void Sah_MouseClick(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            int brojKolone, brojVrste;
            brojKolone = (e.X) / 60;
            brojVrste = 8 - e.Y / 60 + 1;
            label1.Text= Figura.Instance().vratiFiguru(brojKolone,brojVrste);
            if(brojKolone<1 || brojKolone>8 || brojVrste<1 || brojVrste>8)
                Console.WriteLine("greska");
            else if (brojKlika == 1)
            {
                prvaFigura = Figura.Instance().nazivFigure(brojKolone, brojVrste, Figura.Instance().vratiFiguru(brojKolone, brojVrste));
                if (Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "pB1" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "pB6" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "pB7" ||
                    Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "pB2" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "pB5" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "pB8" ||
                    Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "pB3" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "pB4" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "tB1" ||
                    Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "tB2" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "koB1" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "koB2" ||
                    Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "lB1" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "lB2" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "krB1" ||
                    Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "kB1")
                {
                    brojKlika=2;
                }
            }
            else if (brojKlika == 2)
            {
                if (Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB1"    || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB2" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB3"
                    || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB4" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB5" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB6"
                    || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB7" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB8" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "tB1"
                    || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "tB2" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "koB1" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "koB2"
                    || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "lB1" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "lB2" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "krB1"
                    || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "kB1")

                {
                    if (Figura.Instance().napadnutBeliKralj(brojKolone, brojVrste) == 1)
                    {
                        ((PictureBox)this.Controls[Figura.Instance().odrediFiguru(brojKolone, brojVrste)]).Location = new Point(brojKolone * 60, (9 - brojVrste) * 60);
                        Figura.Instance().zameni(Figura.Instance().staraKolona(), Figura.Instance().staraVrsta(), brojKolone, brojVrste);
                        brojKlika = 3;
                    }
                    else brojKlika = 1;
                // NAPADANJE FIGURA
                }

                else
                if (prvaFigura != null && (prvaFigura == "pB1" || prvaFigura == "pB2" || prvaFigura == "pB3" || prvaFigura == "pB4" ||
                    prvaFigura == "pB4" || prvaFigura == "pB5" || prvaFigura == "pB6" || prvaFigura == "pB7" || prvaFigura == "pB8" ||
                    prvaFigura == "tB1" || prvaFigura == "tB2" || prvaFigura == "koB1" || prvaFigura == "koB2" || prvaFigura == "lB1" ||
                    prvaFigura == "lB2" || prvaFigura == "krB1" || prvaFigura == "kB1"))
                {
                    if (Figura.Instance().odrediFiguru(brojKolone, brojVrste) != null && (Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC1" ||
                        Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC2" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC6" ||
                        Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC3" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC7" ||
                        Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC4" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC8" ||
                        Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC5" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "tC1" ||
                        Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "tC2" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "koC1" ||
                        Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "koC2" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "lC1" ||
                        Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "lC2" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "krC1" ||
                        Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "kC1"))
                    {
                        try
                        {
                            if (Figura.Instance().napadnutBeliKralj(brojKolone, brojVrste) == 1)
                            {
                                ((PictureBox)this.Controls[prvaFigura]).Location = ((PictureBox)this.Controls[Figura.Instance().odrediFiguru(brojKolone, brojVrste)]).Location;
                                ((PictureBox)this.Controls[Figura.Instance().odrediFiguru(brojKolone, brojVrste)]).Visible = false;
                                Figura.Instance().zameni(Figura.Instance().staraKolona(), Figura.Instance().staraVrsta(), brojKolone, brojVrste);
                                brojKlika = 3;
                            }
                            else brojKlika = 1;
                        }
                        catch { }
                    }
                    else brojKlika = 1;
                }
            }

            else if (brojKlika == 3)
            {
                prvaFigura = Figura.Instance().nazivFigure(brojKolone, brojVrste, Figura.Instance().vratiFiguru(brojKolone, brojVrste));
                if (Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "pC1" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "pC6" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "pC7" ||
                    Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "pC2" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "pC5" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "pC8" ||
                    Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "pC3" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "pC4" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "tC1" ||
                    Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "tC2" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "koC1" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "koC2" ||
                    Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "lC1" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "lC2" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "krC1" ||
                    Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "kC1")
                {
                    brojKlika = 4;
                }
            }

            else if(brojKlika==4)
            {
                if (Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC1" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC2" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC3"
                   || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC4" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC5" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC6"
                   || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC7" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC8" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "tC1"
                   || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "tC2" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "koC1" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "koC2"
                   || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "lC1" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "lC2" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "krC1"
                   || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "kC1")
                {
                    ((PictureBox)this.Controls[Figura.Instance().odrediFiguru(brojKolone, brojVrste)]).Location = new Point(brojKolone * 60, (9 - brojVrste) * 60);
                    Figura.Instance().zameni(Figura.Instance().staraKolona(), Figura.Instance().staraVrsta(), brojKolone, brojVrste);
                    brojKlika = 1;
                }

                // NAPADANJE FIGURA
                else
               if (prvaFigura != null && (prvaFigura == "pC1" || prvaFigura == "pC2" || prvaFigura == "pC3" || prvaFigura == "pC4" ||
                   prvaFigura == "pC4" || prvaFigura == "pC5" || prvaFigura == "pC6" || prvaFigura == "pC7" || prvaFigura == "pC8" ||
                   prvaFigura == "tC1" || prvaFigura == "tC2" || prvaFigura == "koC1" || prvaFigura == "koC2" || prvaFigura == "lC1" || 
                   prvaFigura == "lC2" || prvaFigura == "krC1" || prvaFigura == "kC1"))
                {
                    if (Figura.Instance().odrediFiguru(brojKolone, brojVrste) != null && (Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB1" ||
                        Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB2" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB6" ||
                        Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB3" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB7" ||
                        Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB4" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB8" ||
                        Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB5" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "tB1" ||
                        Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "tB2" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "koB1" || 
                        Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "koB2" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "lB1" || 
                        Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "lB2" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "krB1" ||
                        Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "kB1"))
                    {
                        try
                        {
                            ((PictureBox)this.Controls[prvaFigura]).Location = ((PictureBox)this.Controls[Figura.Instance().odrediFiguru(brojKolone, brojVrste)]).Location;
                            ((PictureBox)this.Controls[Figura.Instance().odrediFiguru(brojKolone, brojVrste)]).Visible = false;
                            Figura.Instance().zameni(Figura.Instance().staraKolona(), Figura.Instance().staraVrsta(), brojKolone, brojVrste);
                            //f.zameni(brojKolone, brojVrste, 0, 1);
                            brojKlika = 1;
                        }
                        catch { }
                    }
                    else brojKlika = 3;
                }
            }
        }
    }
}