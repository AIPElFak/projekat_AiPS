using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

namespace Sah
{
    public partial class Pocetak : Form
    {
        public Pocetak()
        {
            InitializeComponent();
            listView1.Columns.Add("IME");
            listView1.AutoArrange = true;
            listView1.View = View.Details;
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("nesto1");
            var collection = database.GetCollection<Partija>("ggg");
            MongoCursor<Partija> igraci = collection.FindAll();
            foreach (Partija r in igraci.ToArray())
            {
                string[] row = { r.ime };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            }
        }
        private void kreirajIgru_Click(object sender, EventArgs e)
        {
            Sah s = new Sah();
            Baza baza = new Baza();
            Server.Instance().igra(baza.ucitaj("standard"));
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

        private void Ucitaj_Click(object sender, EventArgs e)
        {
            Baza baza = new Baza();
            Server.Instance().igra(baza.ucitaj(listView1.SelectedItems[0].Text/*"standard1"*/));
            Sah s = new Sah();
            s.pasvaluec = 1;
            s.Show();
            this.Hide();
            Server.Instance().server1();
        }
    }
}
