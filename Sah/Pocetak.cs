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
    public partial class Pocetak : Form
    {
        public Pocetak()
        {
            InitializeComponent();
        }
        private void kreirajIgru_Click(object sender, EventArgs e)
        {
            Sah s = new Sah();
            s.pasvaluec = 1;
            s.Show();
            this.Hide();
            Server.Instance().server1();
        }

        private void poveziSe_Click(object sender, EventArgs e)
        {
            Sah s = new Sah();
            s.pasvaluec = 2;
            s.Show();
            this.Hide();
            Client.Instance().client1();
        }
    }
}
