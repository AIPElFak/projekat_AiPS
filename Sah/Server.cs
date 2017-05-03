using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTCP;

namespace Sah
{
    class Server
    {
        static Server instance;
        public static Server Instance()
        {
            if (instance == null)
            {
                instance = new Server();
            }
            return instance;
        }
        
        SimpleTcpServer server = new SimpleTcpServer().Start(8911);
        static int i = 1;
        int clientsConnected;
        string partija,sahmat;
        public void server1()
        {
            //dodaj figuru za menjanje ovde
            server.Delimiter = 0x13;
            server.DelimiterDataReceived += (sender, msg) =>
            {
                // Console.WriteLine(msg.MessageString);
               
                string k = msg.MessageString;
                string[] niz = k.Split(',');
                primljeno1 = niz[5] + "," + niz[6] + "," + niz[1] + ","+niz[2];
                Console.WriteLine(primljeno1);
                if (primljeno1 == "0,0,0,0")
                    server.Broadcast(partija);
                Figura.Instance().zameni(int.Parse(niz[5]), int.Parse(niz[6]), int.Parse(niz[1]), int.Parse(niz[2]));
                if(niz[7]=="sahmat")
                {
                    sahmat = "sahmat";
                  //  Kraj kr = new Kraj();
                   // kr.Show();
                }
            };
            clientsConnected = server.ConnectedClientsCount;
            //Console.WriteLine("number of connected clients is: " + clientsConnected);
            //var listeningIps = server.GetListeningIPs();
            //Console.WriteLine("number of connected clients is: " + listeningIps);
            //var listeningV4Ips = server.GetListeningIPs().Where(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
            //Console.WriteLine("number of connected clients is: " + listeningV4Ips);
        }
        string primljeno1=",";
        public string vv()
        {
            if(sahmat=="sahmat")
            {
                Kraj kr = new Kraj();
                kr.Show();
                sahmat = "";
            }
            return primljeno1;
        }
     
        public void salji(string pozicija, int brojKlika,string prvaFigura,int staraKolona,int staraVrsta, int c,string pozicijamat)
        {
            var message = pozicija + "," + brojKlika.ToString()+","+prvaFigura+","+staraKolona+","+staraVrsta+","+pozicijamat; // Console.ReadLine();
            if(c ==1)
            while (message != null)
            {
                server.Broadcast(message);
               // server.DataReceived += (sender, msg) =>
                //{
                  //  Console.WriteLine(msg);
                //};
                clientsConnected = server.ConnectedClientsCount;
                    Console.WriteLine("number of connected clients is: " + clientsConnected);
                message = Console.ReadLine();
            }
        }

        public string gg()
        {
            return partija;
        }
        public string igra(string s)
        {
            partija = s;
            return "";
        }
    }
}
