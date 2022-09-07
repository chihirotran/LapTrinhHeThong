using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IPEndPoint s_iep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1501);
                Socket c_socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
                c_socket.Connect(s_iep);
                Console.WriteLine("ket noi thanh cong");
                while (true)
                {
                    string send = Console.ReadLine();
                    byte[] mess = ASCIIEncoding.ASCII.GetBytes(send);
                    c_socket.Send(mess);
                    string test = ASCIIEncoding.ASCII.GetString(mess).TrimEnd('/0');
                    Console.WriteLine("*" + test + "*");
                    if (send.Equals("thoat") == true)
                    {
                        break;
                    }
                    byte[] breceive = new byte[1024];
                    c_socket.Receive(breceive);
                    String tinnhan = ASCIIEncoding.ASCII.GetString(breceive).Trim();
                    Console.WriteLine("<Server>: " + tinnhan.Trim());
                }
                c_socket.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("loi:" + ex.Message);
            }
            
        }
    }
}
