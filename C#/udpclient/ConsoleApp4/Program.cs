using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint s_ips = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1501);
            Socket c_socket = new Socket( SocketType.Dgram, ProtocolType.Udp);
            while (true)
            {
                String mess;
                mess = Console.ReadLine();
                byte[] bmess = ASCIIEncoding.ASCII.GetBytes(mess);
                c_socket.SendTo(bmess, s_ips);
                Console.WriteLine("da gui");
                if (mess.Equals("thoat") == true)
                {
                    break;
                }
                byte[] breceive = new byte[1024];
                EndPoint s_ep = new IPEndPoint(IPAddress.None, 0);
                c_socket.ReceiveFrom(breceive, ref s_ep);
                String receive = ASCIIEncoding.ASCII.GetString(breceive);
                Console.WriteLine("<Server>: " + receive);

            }
            c_socket.Close();
        }
    }
}
