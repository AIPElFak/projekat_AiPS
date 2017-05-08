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
            zKrB.Image = Properties.Resources.kraljica;
            zKoB.Image = Properties.Resources.konj;
            zTB.Image = Properties.Resources.top;
            zLB.Image = Properties.Resources.lovac;
            zamenaBf.Image = Properties.Resources.bfigure;

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
            zKrC.Image = Properties.Resources.kraljicac;
            zKoC.Image = Properties.Resources.konjc;
            zTC.Image = Properties.Resources.topc;
            zLC.Image = Properties.Resources.lovacc;
            zamenaCf.Image = Properties.Resources.cfigure;
        }
        public void fenable()
        {
            pB1.Enabled = true;
            pB2.Enabled = true;
            pB3.Enabled = true;
            pB4.Enabled = true;
            pB5.Enabled = true;
            pB6.Enabled = true;
            pB7.Enabled = true;
            pB8.Enabled = true;
            tB1.Enabled = true;
            tB2.Enabled = true;
            koB1.Enabled = true;
            koB2.Enabled = true;
            lB1.Enabled = true;
            lB2.Enabled = true;
            krB1.Enabled = true;
            kB1.Enabled = true;
            zKrB.Enabled = true;
            zKoB.Enabled = true;
            zTB.Enabled = true;
            zLB.Enabled = true;
            //zKrB.Location = new Point(Figura.Instance().kolonaZaFiguru("kB1"), Figura.Instance().vrstaZaFiguru("kB1"));
            //new Point(Figura.Instance().kolonaZaFiguru("zKrB"), Figura.Instance().vrstaZaFiguru("zKrB"));
            pC1.Enabled = true;
            pC2.Enabled = true;
            pC3.Enabled = true;
            pC4.Enabled = true;
            pC5.Enabled = true;
            pC6.Enabled = true;
            pC7.Enabled = true;
            pC8.Enabled = true;
            tC1.Enabled = true;
            tC2.Enabled = true;
            koC1.Enabled = true;
            koC2.Enabled = true;
            lC1.Enabled = true;
            lC2.Enabled = true;
            krC1.Enabled = true;
            kC1.Enabled = true;
            zKrC.Enabled = true;
            zKoC.Enabled = true;
            zTC.Enabled = true;
            zLC.Enabled = true;
        }
        public void fdisable()
        {
            pB1.Enabled = false;
            pB2.Enabled = false;
            pB3.Enabled = false;
            pB4.Enabled = false;
            pB5.Enabled = false;
            pB6.Enabled = false;
            pB7.Enabled = false;
            pB8.Enabled = false;
            tB1.Enabled = false;
            tB2.Enabled = false;
            koB1.Enabled = false;
            koB2.Enabled = false;
            lB1.Enabled = false;
            lB2.Enabled = false;
            krB1.Enabled = false;
            kB1.Enabled = false;
            zKrB.Enabled = false;
            zKoB.Enabled = false;
            zTB.Enabled = false;
            zLB.Enabled = false;
            //zKrB.Location = new Point(Figura.Instance().kolonaZaFiguru("kB1"), Figura.Instance().vrstaZaFiguru("kB1"));
            //new Point(Figura.Instance().kolonaZaFiguru("zKrB"), Figura.Instance().vrstaZaFiguru("zKrB"));
            pC1.Enabled = false;
            pC2.Enabled = false;
            pC3.Enabled = false;
            pC4.Enabled = false;
            pC5.Enabled = false;
            pC6.Enabled = false;
            pC7.Enabled = false;
            pC8.Enabled = false;
            tC1.Enabled = false;
            tC2.Enabled = false;
            koC1.Enabled = false;
            koC2.Enabled = false;
            lC1.Enabled = false;
            lC2.Enabled = false;
            krC1.Enabled = false;
            kC1.Enabled = false;
            zKrC.Enabled = false;
            zKoC.Enabled = false;
            zTC.Enabled = false;
            zLC.Enabled = false;
        }
        Baza baza = new Baza();
        string pozicijamat;
        public int c,i=0;
        public int pasvaluec
        {
            get { return c; }
            set { c = value; }
        }

        static Tabla t = new Tabla(60, 60);
        private void Sah_Paint(object sender, PaintEventArgs e)
        {
            Graphics o = CreateGraphics();
           // Brush black = new SolidBrush(Color.Black);
            //Brush yellow = new SolidBrush(Color.Yellow);
            Brush green = new SolidBrush(Color.Green);
           // Pen red1 = new Pen(Color.Red);
            o.FillRectangle(green, t.sirinaX() / 3 * 2, t.visinaY(), t.sirinaX() / 3, t.visinaY() * 8);
            o.FillRectangle(green, t.sirinaX() / 3 * 2, t.visinaY() * 9, t.sirinaX() * 8 + t.sirinaX() / 3, t.sirinaX() / 3);
            //int k = 0;
            //for (int i = 1; i <= 8; i++)
            //{
            //    for (int j = 1; j <= 8; j++)
            //    {
            //        k++;
            //        if (k % 2 == 0 && i % 2 == 0)
            //            o.FillRectangle(yellow, i * t.sirinaX(), j * t.visinaY(), t.sirinaX(), t.visinaY());
            //        else if (k % 2 != 0 && i % 2 == 0)
            //            o.FillRectangle(black, i * t.sirinaX(), j * t.visinaY(), t.sirinaX(), t.visinaY());
            //        else if (k % 2 == 0 && i % 2 != 0)
            //            o.FillRectangle(black, i * t.sirinaX(), j * t.visinaY(), t.sirinaX(), t.visinaY());
            //        else if (k % 2 != 0 && i % 2 != 0)
            //            o.FillRectangle(yellow, i * t.sirinaX(), j * t.visinaY(), t.sirinaX(), t.visinaY());
            //    }
            //}
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
            pictureBox1.Location = new Point(0,0);
            //zKrB.Location = new Point(Figura.Instance().kolonaZaFiguru("kB1"), Figura.Instance().vrstaZaFiguru("kB1"));
            //new Point(Figura.Instance().kolonaZaFiguru("zKrB"), Figura.Instance().vrstaZaFiguru("zKrB"));
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
        
        int brojKlika = 1,kolonaZamena,vrstaZamena;
        String prvaFigura;
       public void odredi1(int brojKolone, int brojVrste)
        {
            if (Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB1" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB2" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB3"
                   || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB4" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB5" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB6"
                   || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB7" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB8" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "tB1"
                   || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "tB2" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "koB1" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "koB2"
                   || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "lB1" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "lB2" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "krB1"
                   || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "kB1" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "zKrB" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "izmeniPiona"
                   || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "zKoB" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "zTB" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "zLB")
            {
                if (Figura.Instance().napadnutBeliKralj(brojKolone, brojVrste) == 1)
                {
                    //if (Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "izmeniPiona")
                    //{
                    //    label1.Text = "izvrsi zamenu";
                    //    ((PictureBox)this.Controls[Figura.Instance().vratiFiguru(Figura.Instance().staraKolona(), Figura.Instance().staraVrsta())]).Location = new Point(brojKolone * 60, (9 - brojVrste) * 60);
                    //    Figura.Instance().zameni(Figura.Instance().staraKolona(), Figura.Instance().staraVrsta(), brojKolone, brojVrste);
                    //    zamenaBf.Visible = true;
                    //    //zamenaBf.Enabled = true;
                    //    kolonaZamena = brojKolone;
                    //    vrstaZamena = brojVrste;
                    //    brojKlika = 5;
                    //}
                    //else
                    //{
                        ((PictureBox)this.Controls[Figura.Instance().odrediFiguru(brojKolone, brojVrste)]).Location = new Point(brojKolone * 60, (9 - brojVrste) * 60);
                        Figura.Instance().zameni(Figura.Instance().staraKolona(), Figura.Instance().staraVrsta(), brojKolone, brojVrste);
                        if (Figura.Instance().mat1(brojKolone, brojVrste) == 0)
                        {
                            pozicijamat = "sahmat"; ;
                        }
                            
                        Client.Instance().salji(c, brojKolone + "," + brojVrste, brojKlika, prvaFigura, Figura.Instance().staraKolona(), Figura.Instance().staraVrsta(),pozicijamat);
                        baza.dodajAutomatski( Figura.Instance().sss1());
                        brojKlika = 1;
                    //}
                }
                else brojKlika = 1;
            }

            // NAPADANJE FIGURA
            else
               if (prvaFigura != null && (prvaFigura == "pB1" || prvaFigura == "pB2" || prvaFigura == "pB3" || prvaFigura == "pB4" ||
                   prvaFigura == "pB4" || prvaFigura == "pB5" || prvaFigura == "pB6" || prvaFigura == "pB7" || prvaFigura == "pB8" ||
                   prvaFigura == "tB1" || prvaFigura == "tB2" || prvaFigura == "koB1" || prvaFigura == "koB2" || prvaFigura == "lB1" ||
                   prvaFigura == "lB2" || prvaFigura == "krB1" || prvaFigura == "kB1" || prvaFigura == "zKrB" || prvaFigura == "zKoB" ||
                   prvaFigura == "zTB" || prvaFigura == "zLB"))
            {
                if (Figura.Instance().odrediFiguru(brojKolone, brojVrste) != null && (Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC1" ||
                    Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC2" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC6" ||
                    Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC3" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC7" ||
                    Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC4" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC8" ||
                    Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC5" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "tC1" ||
                    Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "tC2" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "koC1" ||
                    Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "koC2" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "lC1" ||
                    Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "lC2" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "krC1" ||
                    Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "kC1" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "izmeniPiona" ||
                    Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "zKrC" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "zKoC" ||
                    Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "zTC" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "zLC"))
                {
                    try
                    {
                        if (Figura.Instance().napadnutBeliKralj(brojKolone, brojVrste) == 1)
                        {
                            ((PictureBox)this.Controls[prvaFigura]).Location = ((PictureBox)this.Controls[Figura.Instance().odrediFiguru(brojKolone, brojVrste)]).Location;
                            ((PictureBox)this.Controls[Figura.Instance().odrediFiguru(brojKolone, brojVrste)]).Visible = false;
                            Figura.Instance().zameni(Figura.Instance().staraKolona(), Figura.Instance().staraVrsta(), brojKolone, brojVrste);
                            if (Figura.Instance().mat1(brojKolone, brojVrste) == 0)
                            {
                                pozicijamat = "sahmat";
                            }
                            Client.Instance().salji(c, brojKolone + "," + brojVrste, brojKlika, prvaFigura, Figura.Instance().staraKolona(), Figura.Instance().staraVrsta(),pozicijamat);
                            baza.dodajAutomatski(Figura.Instance().sss1());
                            brojKlika = 1;
                        }
                        else brojKlika = 1;
                    }
                    catch { }
                }
                else brojKlika = 1;
            }
        }
       public void odredi2(int brojKolone, int brojVrste)
        {
            if (Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC1" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC2" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC3"
                   || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC4" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC5" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC6"
                   || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC7" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pC8" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "tC1"
                   || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "tC2" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "koC1" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "koC2"
                   || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "lC1" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "lC2" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "krC1"
                   || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "kC1" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "izmeniPiona" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "zKrC"
                   || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "zKoC" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "zTC" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "zLC")
            {
                if (Figura.Instance().napadnutCrniKralj(brojKolone, brojVrste) == 1)
                {
                    //if (Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "izmeniPiona")
                    //{
                    //    label1.Text = "izvrsi zamenu";
                    //    ((PictureBox)this.Controls[Figura.Instance().vratiFiguru(Figura.Instance().staraKolona(), Figura.Instance().staraVrsta())]).Location = new Point(brojKolone * 60, (9 - brojVrste) * 60);
                    //    Figura.Instance().zameni(Figura.Instance().staraKolona(), Figura.Instance().staraVrsta(), brojKolone, brojVrste);
                    //    zamenaCf.Visible = true;
                    //    kolonaZamena = brojKolone;
                    //    vrstaZamena = brojVrste;
                    //    brojKlika = 6;
                    //}
                    //else
                    //{
                        ((PictureBox)this.Controls[Figura.Instance().odrediFiguru(brojKolone, brojVrste)]).Location = new Point(brojKolone * 60, (9 - brojVrste) * 60);
                        Figura.Instance().zameni(Figura.Instance().staraKolona(), Figura.Instance().staraVrsta(), brojKolone, brojVrste);
                        if (Figura.Instance().mat(brojKolone, brojVrste) == 0)
                        {
                            label1.Text = "sahmat";
                            pozicijamat = "sahmat";
                            Kraj k = new Kraj();
                            k.Show();
                        }
                        Server.Instance().salji(brojKolone + "," + brojVrste, brojKlika, prvaFigura, Figura.Instance().staraKolona(), Figura.Instance().staraVrsta(), c, pozicijamat);
                        baza.dodajAutomatski(Figura.Instance().sss1());
                        brojKlika = 3;
                    //}
                }
                else brojKlika = 3;
            }
            // NAPADANJE FIGURA
            else
               if (prvaFigura != null && (prvaFigura == "pC1" || prvaFigura == "pC2" || prvaFigura == "pC3" || prvaFigura == "pC4" ||
                   prvaFigura == "pC4" || prvaFigura == "pC5" || prvaFigura == "pC6" || prvaFigura == "pC7" || prvaFigura == "pC8" ||
                   prvaFigura == "tC1" || prvaFigura == "tC2" || prvaFigura == "koC1" || prvaFigura == "koC2" || prvaFigura == "lC1" ||
                   prvaFigura == "lC2" || prvaFigura == "krC1" || prvaFigura == "kC1" || prvaFigura == "zKrC" || prvaFigura == "zKoC" ||
                   prvaFigura == "zTC" || prvaFigura == "zLC"))
            {
                if (Figura.Instance().odrediFiguru(brojKolone, brojVrste) != null && (Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB1" ||
                    Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB2" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB6" ||
                    Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB3" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB7" ||
                    Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB4" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB8" ||
                    Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "pB5" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "tB1" ||
                    Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "tB2" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "koB1" ||
                    Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "koB2" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "lB1" ||
                    Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "lB2" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "krB1" ||
                    Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "kB1" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "zKrB" ||
                    Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "zKoB" || Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "zTB" ||
                    Figura.Instance().odrediFiguru(brojKolone, brojVrste) == "zLB"))
                {
                    try
                    {
                        if (Figura.Instance().napadnutCrniKralj(brojKolone, brojVrste) == 1)
                        {
                            ((PictureBox)this.Controls[prvaFigura]).Location = ((PictureBox)this.Controls[Figura.Instance().odrediFiguru(brojKolone, brojVrste)]).Location;
                            ((PictureBox)this.Controls[Figura.Instance().odrediFiguru(brojKolone, brojVrste)]).Visible = false;
                            Figura.Instance().zameni(Figura.Instance().staraKolona(), Figura.Instance().staraVrsta(), brojKolone, brojVrste);
                            if (Figura.Instance().mat(brojKolone, brojVrste) == 0)
                            {
                                label1.Text = "sahmat";
                                pozicijamat = "sahmat";
                                Kraj k = new Kraj();
                                k.Show();
                            }
                            Server.Instance().salji(brojKolone + "," + brojVrste, brojKlika, prvaFigura, Figura.Instance().staraKolona(), Figura.Instance().staraVrsta(), c,pozicijamat);
                            baza.dodajAutomatski(Figura.Instance().sss1());
                            brojKlika = 1;
                        }
                        else brojKlika = 1;
                    }
                    catch { }
                }
                else brojKlika = 3;
            }
        }

        private void Sah_Load(object sender, EventArgs e)
        {
            if (c == 2)
            {
                brojKlika = 1;
            }
            else
            {
                brojKlika = 3;
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                string k = Server.Instance().vv();
                string[] i = k.Split(',');
                if (i[0] == "7" || i[0] == "6" || i[0] == "2" || i[0] == "1" || i[0] == "3" || i[0] == "4" || i[0] == "5" || i[0] == "8")
                {
                    pictureBox1.Location = new Point(1000,1000);
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sacuvaj_Click(object sender, EventArgs e)
        {
            if(i==0)
            {
                sacuvajText.Visible = true;
                sacuvajLabel.Text = "Enter name";
                sacuvaj.Text = "Ok";
                i = 1;
            }
            else
            {
                
                baza.dodaj(sacuvajText.Text, Figura.Instance().sss1());
                sacuvajText.Visible = true;
                sacuvajLabel.Text = " ";
                sacuvaj.Text = "Ok";
                i = 1;

            }
        }

        private void Sah_MouseClick(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            int brojKolone, brojVrste;
            brojKolone = (e.X) / 60;
            brojVrste = 8 - e.Y / 60 + 1;
            //label1.Text= Figura.Instance().vratiFiguru(brojKolone,brojVrste);
            if(brojKolone<1 || brojKolone>8 || brojVrste<1 || brojVrste>8)  // u slucaju da je kliknuto van table
                Console.WriteLine("greska");
            else if (brojKlika == 1)  // beli igrac bira figuru koju zeli pomeriti
            {
                prvaFigura = Figura.Instance().nazivFigure(brojKolone, brojVrste, Figura.Instance().vratiFiguru(brojKolone, brojVrste));
                if (Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "pB1" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "pB6" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "pB7" ||
                    Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "pB2" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "pB5" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "pB8" ||
                    Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "pB3" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "pB4" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "tB1" ||
                    Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "tB2" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "koB1" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "koB2" ||
                    Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "lB1" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "lB2" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "krB1" ||
                    Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "kB1" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "zKrB" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "zKoB" ||
                    Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "zTB" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "zLB")
                {
                    brojKlika=2;
                }
            }
            else if (brojKlika == 2)  // beli igrac pomera izabranu figuru
            {
                if (c == 2)
                {
                    odredi1(brojKolone, brojVrste);  // odredjivanje dali je moguce pomeriti belu figuru na odabrano polje
                }
            }

            //CRNI JE NA POTEZU
            else if (brojKlika == 3)
            {
                prvaFigura = Figura.Instance().nazivFigure(brojKolone, brojVrste, Figura.Instance().vratiFiguru(brojKolone, brojVrste));
                if (Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "pC1" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "pC6" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "pC7" ||
                    Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "pC2" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "pC5" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "pC8" ||
                    Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "pC3" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "pC4" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "tC1" ||
                    Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "tC2" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "koC1" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "koC2" ||
                    Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "lC1" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "lC2" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "krC1" ||
                    Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "kC1" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "zKrC" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "zKoC"||
                    Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "zTC" || Figura.Instance().vratiFiguru(brojKolone, brojVrste) == "zLC")
                {
                    brojKlika = 4;
                }
            }
            else if(brojKlika==4)
            {
                if (c == 1)
                {
                    odredi2(brojKolone, brojVrste);
                    brojKlika = 3;
                    c = 2;
                }
            }

            //else if(brojKlika==5)
            //{
            //    if(e.X > 310 && e.Y >= 80 && e.Y < 140 && e.X < 460)
            //    {
            //        zamenaBf.Visible = false;
            //        fdisable();
            //        //brojKlika = 3;
            //        string kz = Figura.Instance().vratiFiguru(kolonaZamena, vrstaZamena);
            //        zKrB.Location = new Point(Figura.Instance().kolonaZaFiguru(kz), Figura.Instance().vrstaZaFiguru(kz));
            //        zKrB.Visible = true;
            //        Figura.Instance().izvrsiZamenu(kolonaZamena, vrstaZamena, 0, 1);
            //        //Client.Instance().salji(c, 0 +","+1 , brojKlika, prvaFigura, kolonaZamena , vrstaZamena);
            //        brojKlika = 1;
            //    }
            //    else if (e.X > 310 && e.Y >= 140 && e.Y<200 && e.X<460)
            //    {
            //        zamenaBf.Visible = false;
            //        fdisable();
            //        brojKlika = 3;
            //        string kz = Figura.Instance().vratiFiguru(kolonaZamena, vrstaZamena);
            //        zKoB.Location = new Point(Figura.Instance().kolonaZaFiguru(kz), Figura.Instance().vrstaZaFiguru(kz));
            //        zKoB.Visible = true;
            //        Figura.Instance().izvrsiZamenu(kolonaZamena, vrstaZamena, 0, 2);
            //    }
            //    else if (e.X > 310 && e.Y >= 200 && e.Y < 260 && e.X < 460)
            //    {
            //        zamenaBf.Visible = false;
            //        fdisable();
            //        brojKlika = 3;
            //        string kz = Figura.Instance().vratiFiguru(kolonaZamena, vrstaZamena);
            //        zTB.Location = new Point(Figura.Instance().kolonaZaFiguru(kz), Figura.Instance().vrstaZaFiguru(kz));
            //        zTB.Visible = true;
            //        Figura.Instance().izvrsiZamenu(kolonaZamena, vrstaZamena, 0, 3);
            //    }
            //    else if (e.X > 310 && e.Y >= 260 && e.Y < 320 && e.X < 460)
            //    {
            //        zamenaBf.Visible = false;
            //        fdisable();
            //        brojKlika = 3;
            //        string kz = Figura.Instance().vratiFiguru(kolonaZamena, vrstaZamena);
            //        zLB.Location = new Point(Figura.Instance().kolonaZaFiguru(kz), Figura.Instance().vrstaZaFiguru(kz));
            //        zLB.Visible = true;
            //        Figura.Instance().izvrsiZamenu(kolonaZamena, vrstaZamena, 0, 4);
            //    }
            //}

            //else if(brojKlika==6)
            //{
            //    if (e.X > 310 && e.Y >= 280 && e.Y < 340 && e.X < 460)
            //    {
            //        zamenaCf.Visible = false;
            //        fdisable();
            //        brojKlika = 1;
            //        string kz = Figura.Instance().vratiFiguru(kolonaZamena, vrstaZamena);
            //        zKrC.Location = new Point(Figura.Instance().kolonaZaFiguru(kz), Figura.Instance().vrstaZaFiguru(kz));
            //        zKrC.Visible = true;
            //        Figura.Instance().izvrsiZamenu(kolonaZamena, vrstaZamena, 0, 5);
            //    }
            //    else if (e.X > 310 && e.Y >= 340 && e.Y < 400 && e.X < 460)
            //    {
            //        zamenaCf.Visible = false;
            //        fdisable();
            //        brojKlika = 1;
            //        string kz = Figura.Instance().vratiFiguru(kolonaZamena, vrstaZamena);
            //        zKoC.Location = new Point(Figura.Instance().kolonaZaFiguru(kz), Figura.Instance().vrstaZaFiguru(kz));
            //        zKoC.Visible = true;
            //        Figura.Instance().izvrsiZamenu(kolonaZamena, vrstaZamena, 0, 6);
            //    }
            //    else if (e.X > 310 && e.Y >= 400 && e.Y < 460 && e.X < 460)
            //    {
            //        zamenaCf.Visible = false;
            //        fdisable();
            //        brojKlika = 1;
            //        string kz = Figura.Instance().vratiFiguru(kolonaZamena, vrstaZamena);
            //        zTC.Location = new Point(Figura.Instance().kolonaZaFiguru(kz), Figura.Instance().vrstaZaFiguru(kz));
            //        zTC.Visible = true;
            //        Figura.Instance().izvrsiZamenu(kolonaZamena, vrstaZamena, 0, 7);
            //    }
            //    else if (e.X > 310 && e.Y >= 460 && e.Y < 520 && e.X < 460)
            //    {
            //        zamenaCf.Visible = false;
            //        fdisable();
            //        brojKlika = 1;
            //        string kz = Figura.Instance().vratiFiguru(kolonaZamena, vrstaZamena);
            //        zLC.Location = new Point(Figura.Instance().kolonaZaFiguru(kz), Figura.Instance().vrstaZaFiguru(kz));
            //        zLC.Visible = true;
            //        Figura.Instance().izvrsiZamenu(kolonaZamena, vrstaZamena, 0, 8);
            //    }
            //}
        }
    }
}