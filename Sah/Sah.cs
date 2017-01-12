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
            //Figura.Instance();
            pB1.Image = Image.FromFile("pion.png");
            pB2.Image = Image.FromFile("pion.png");
            pB3.Image = Image.FromFile("pion.png");
            pB4.Image = Image.FromFile("pion.png");
            pB5.Image = Image.FromFile("pion.png");
            pB6.Image = Image.FromFile("pion.png");
            pB7.Image = Image.FromFile("pion.png");
            pB8.Image = Image.FromFile("pion.png");
            tB1.Image = Image.FromFile("top.png");
            //pB1.Location = new Point(60, 420);
            //pB1.Location = new Point(f.kolonaZaFiguru("pB1"), f.vrstaZaFiguru("pB1"));
            //pB2.Location = new Point(120, 420);
            //pB3.Location = new Point(180, 420);
            //pB4.Location = new Point(240, 420);
            //pB5.Location = new Point(300, 420);
            //pB6.Location = new Point(360, 420);
            //pB7.Location = new Point(420, 420);
            //pB8.Location = new Point(480, 420);

            pC1.Image = Image.FromFile("pionc.png");
            pC2.Image = Image.FromFile("pionc.png");
            pC3.Image = Image.FromFile("pionc.png");
            pC4.Image = Image.FromFile("pionc.png");
            pC5.Image = Image.FromFile("pionc.png");
            pC6.Image = Image.FromFile("pionc.png");
            pC7.Image = Image.FromFile("pionc.png");
            pC8.Image = Image.FromFile("pionc.png");
            //pC1.Location = new Point(60, 120);
            //pC2.Location = new Point(120, 120);
            //pC3.Location = new Point(180, 120);
            //pC4.Location = new Point(240, 120);
            //pC5.Location = new Point(300, 120);
            //pC6.Location = new Point(360, 120);
            //pC7.Location = new Point(420, 120);
            //pC8.Location = new Point(480, 120);
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
            pC1.Location = new Point(Figura.Instance().kolonaZaFiguru("pC1"), Figura.Instance().vrstaZaFiguru("pC1"));
            pC2.Location = new Point(Figura.Instance().kolonaZaFiguru("pC2"), Figura.Instance().vrstaZaFiguru("pC2"));
            pC3.Location = new Point(Figura.Instance().kolonaZaFiguru("pC3"), Figura.Instance().vrstaZaFiguru("pC3"));
            pC4.Location = new Point(Figura.Instance().kolonaZaFiguru("pC4"), Figura.Instance().vrstaZaFiguru("pC4"));
            pC5.Location = new Point(Figura.Instance().kolonaZaFiguru("pC5"), Figura.Instance().vrstaZaFiguru("pC5"));
            pC6.Location = new Point(Figura.Instance().kolonaZaFiguru("pC6"), Figura.Instance().vrstaZaFiguru("pC6"));
            pC7.Location = new Point(Figura.Instance().kolonaZaFiguru("pC7"), Figura.Instance().vrstaZaFiguru("pC7"));
            pC8.Location = new Point(Figura.Instance().kolonaZaFiguru("pC8"), Figura.Instance().vrstaZaFiguru("pC8"));
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
                    Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "pB3" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "pB4" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "tB1")
                {
                    brojKlika=2;
                }
            }
            else if (brojKlika == 2)
            {
                if (Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB1"    || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB2" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB3"
                    || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB4" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB5" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB6"
                    || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB7" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB8" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "tB1")
                {
                    ((PictureBox)this.Controls[Figura.Instance().odrediFiguru(brojKolone, brojVrste)]).Location = new Point(brojKolone * 60, (9 - brojVrste) * 60);
                    Figura.Instance().zameni(Figura.Instance().staraKolona(), Figura.Instance().staraVrsta(), brojKolone, brojVrste);
                    brojKlika = 3;
                }

                // NAPADANJE FIGURA
                else
                if (prvaFigura != null && (prvaFigura == "pB1" || prvaFigura == "pB2" || prvaFigura == "pB3" || prvaFigura == "pB4" ||
                    prvaFigura == "pB4" || prvaFigura == "pB5" || prvaFigura == "pB6" || prvaFigura == "pB7" || prvaFigura == "pB8" || prvaFigura == "tB1"))
                {
                    if (Figura.Instance().odrediFiguru(brojKolone, brojVrste) != null && (Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC1" ||
                        Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC2" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC6" ||
                        Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC3" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC7" ||
                        Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC4" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC8" ||
                        Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC5"))
                    {
                        try
                        {
                            ((PictureBox)this.Controls[prvaFigura]).Location = ((PictureBox)this.Controls[Figura.Instance().odrediFiguru(brojKolone, brojVrste)]).Location;
                            ((PictureBox)this.Controls[Figura.Instance().odrediFiguru(brojKolone, brojVrste)]).Visible = false;
                            Figura.Instance().zameni(Figura.Instance().staraKolona(), Figura.Instance().staraVrsta(), brojKolone, brojVrste);
                            brojKlika = 3;
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
                    Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "pC3" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "pC4")
                {
                    brojKlika = 4;
                }
            }

            else if(brojKlika==4)
            {
                if (Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC1" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC2" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC3"
                   || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC4" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC5" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC6"
                   || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC7" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC8")
                {
                    ((PictureBox)this.Controls[Figura.Instance().odrediFiguru(brojKolone, brojVrste)]).Location = new Point(brojKolone * 60, (9 - brojVrste) * 60);
                    Figura.Instance().zameni(Figura.Instance().staraKolona(), Figura.Instance().staraVrsta(), brojKolone, brojVrste);
                    brojKlika = 1;
                }

                // NAPADANJE FIGURA
                else
               if (prvaFigura != null && (prvaFigura == "pC1" || prvaFigura == "pC2" || prvaFigura == "pC3" || prvaFigura == "pC4" ||
                   prvaFigura == "pC4" || prvaFigura == "pC5" || prvaFigura == "pC6" || prvaFigura == "pC7" || prvaFigura == "pC8"))
                {
                    if (Figura.Instance().odrediFiguru(brojKolone, brojVrste) != null && (Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB1" ||
                        Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB2" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB6" ||
                        Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB3" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB7" ||
                        Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB4" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB8" ||
                        Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB5" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "tB1"))
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