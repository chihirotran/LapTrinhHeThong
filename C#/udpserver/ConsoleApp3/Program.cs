using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IPEndPoint s_ips = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1501);
                Socket s_socket = new Socket( SocketType.Dgram, ProtocolType.Udp);
                s_socket.Bind(s_ips);
                
                while (true)
                {
                    byte[] breceive = new byte[1024];
                    //tao iep de luu dia chi co client
                    EndPoint c_iep = new IPEndPoint(IPAddress.None, 0);
                    s_socket.ReceiveFrom(breceive, ref c_iep);
                    String receive = ASCIIEncoding.ASCII.GetString(breceive).TrimEnd('\0');
                    Console.WriteLine("<Client>: " + receive);
                    if (receive.Equals("thoat") == true)
                    {
                        break;
                    }
                    String send;
                    send = Console.ReadLine();
                    byte[] bmess = ASCIIEncoding.ASCII.GetBytes(send);
                    s_socket.SendTo(bmess, c_iep);

                    
                }
                s_socket.Close();
            }
            catch (Exception ex) { Console.WriteLine("Loi: " + ex.Message); }
        }
    }
}
