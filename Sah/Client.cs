using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTCP;

namespace Sah
{
    class Client
    {
        string partija;
        static Client instance;
        public static Client Instance()
        {
            if (instance == null)
            {
                instance = new Client();
            }
            return instance;
        }
        SimpleTcpClient client = new SimpleTcpClient();
        Message replyMsg;//= client.WriteLineAndGetReply("Hello world!", TimeSpan.FromSeconds(3));
            
        public void client1()
        {
                client.Connect("10.66.150.252", 8911);
            replyMsg = client.WriteLineAndGetReply("0,0,0,0,0,0,0,0", TimeSpan.FromSeconds(200));
            if (replyMsg != null)
                Console.WriteLine(replyMsg.MessageString);
            partija = replyMsg.MessageString.ToString();
           // return 1;
        }
        string prinljeno;
        public string pp()
        {
            return prinljeno;
        }
        String message;
        public void salji(int c, string pozicija, int brojKlika, string prvaFigura, int staraKolona, int staraVrsta,string pozicijaMat)
        {
            message = c+","+pozicija+","+brojKlika.ToString()+","+prvaFigura+","+staraKolona+","+staraVrsta+","+pozicijaMat;
            //var message = Console.ReadLine(); //saljemo
            if (pozicijaMat == "sahmat")
            {  
                replyMsg = client.WriteLineAndGetReply(message, TimeSpan.FromSeconds(1)); //dobijena
                Kraj kr = new Kraj();
                kr.Show();
            }
            else if (c != 1)
            {
                while (message != null)
                {
                    replyMsg = client.WriteLineAndGetReply(message, TimeSpan.FromSeconds(1000)); //dobijena
                    if (replyMsg != null)
                    {
                        Console.WriteLine(replyMsg.MessageString);
                        string k = replyMsg.MessageString;
                        string[] niz = k.Split(',');
                        Figura.Instance().zameni(int.Parse(niz[4]), int.Parse(niz[5]), int.Parse(niz[0]), int.Parse(niz[1]));
                        prinljeno = replyMsg.MessageString;
                        if (niz[6] == "sahmat")
                        {
                            Kraj kr = new Kraj();
                            kr.Show();
                        }
                    }
                    message = Console.ReadLine();
                }
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
