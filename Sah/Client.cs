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
                client.Connect("192.168.0.101", 8910);
            replyMsg = client.WriteLineAndGetReply("Hello world!", TimeSpan.FromSeconds(20));
            if (replyMsg != null)
                Console.WriteLine(replyMsg.MessageString);
           // return 1;
        }
        string prinljeno;
        public string pp()
        {
            return prinljeno;
        }
        String message;
        public void salji(int c, string pozicija, int brojKlika, string prvaFigura, int staraKolona, int staraVrsta)
        {
            message = c+","+pozicija+","+brojKlika.ToString()+","+prvaFigura+","+staraKolona+","+staraVrsta;
            //var message = Console.ReadLine(); //saljemo
            if (c != 1)
            {
                while (message != null)
                {
                    replyMsg = client.WriteLineAndGetReply(message, TimeSpan.FromSeconds(100)); //dobijena
                    if (replyMsg != null)
                    {
                        Console.WriteLine(replyMsg.MessageString);
                        string k = replyMsg.MessageString;
                        string[] niz = k.Split(',');
                        Figura.Instance().zameni(int.Parse(niz[4]), int.Parse(niz[5]), int.Parse(niz[0]), int.Parse(niz[1]));
                        prinljeno = replyMsg.MessageString;
                    }
                    message = Console.ReadLine();
                }
            }
            
        }
    }
}
