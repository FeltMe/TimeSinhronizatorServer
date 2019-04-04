using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Time_sinhronizator
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpClient sender = new UdpClient();
            Console.WriteLine("Pres f to take date :)");
            var s = Console.ReadLine();
            if(s == "f")
            {
                byte[] data = Encoding.Unicode.GetBytes("Send me a date");
                sender.Send(data, data.Length, "127.0.0.1", 8080);
                IPEndPoint remoteIp = null;
                data = sender.Receive(ref remoteIp);
                Console.WriteLine(Encoding.Unicode.GetString(data));
            }
            else Console.WriteLine("Eror press");
        }
    }
}
