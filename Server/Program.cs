using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    class Program
    {

        static void Main(string[] args)
        {
            UdpClient receiver = new UdpClient(8080);
            IPEndPoint remoteIp = null;
            Console.WriteLine("Start Server");

            while (true)
            {
                byte[] data = receiver.Receive(ref remoteIp);
                Console.WriteLine(Encoding.Unicode.GetString(data));
                IPEndPoint ip = remoteIp as IPEndPoint;

                data = Encoding.Unicode.GetBytes("Ok!");
                Console.WriteLine(data.ToString());

                receiver.Send(data, data.Length, ip.Address.ToString(), ip.Port);
            }
        }
    }
}
