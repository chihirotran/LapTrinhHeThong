using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace ConsoleApp1
{
    internal class Program
    {
        public static void /(object obj)
        {
            Params p = (Params)obj;
            DateTime st = p.st;
            for (int i = 0; i < m; i++)
            {
                for (int j = p.sr; j < p.er; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < m; k++)
                    {
                        sum = sum + a[i, k] * b[k, j];
                    }
                    c[i, j] = sum;
                }
            }

            static void Main(string[] args)
        {
            try
            {
                IPEndPoint s_iep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1501);
                Socket s_socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
                s_socket.Bind(s_iep);
                Console.WriteLine("cho ket noi"); ;
                s_socket.Listen(10);
                Socket c_socket = s_socket.Accept();
                Console.WriteLine(" Ket noi thanh cong" + c_socket.RemoteEndPoint.ToString());
                while (true)
                {
                    byte[] breceive = new byte[1024];
                    c_socket.Receive(breceive);
                    Console.WriteLine("test" + "*");
                    string tinnhan = Encoding.ASCII.GetString(breceive).TrimEnd('\0');
                    
                    
                    Console.WriteLine("<client:> " + tinnhan+"*");
                    
                    if (tinnhan.Equals("thoat") == true)
                    {
                        break ;
                    }
                    Console.Write("<server>: ");
                    string mess = Console.ReadLine();
                    byte[] mess2 = ASCIIEncoding.ASCII.GetBytes(mess);
                    c_socket.Send(mess2);
                }
                c_socket.Close();
                s_socket.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi: "+ ex.Message);
            }
            
        }
    }
}
