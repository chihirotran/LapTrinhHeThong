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
        static bool ktraSoHH(int a)
        {
            int sum = 0;
            for (int i = 1; i <= a / 2; i++)
            {
                if (a % i == 0)
                    //tổng các ước số của a
                    sum += i;
            }
            if (sum == a) return true;
            return false;
        }
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
                    int a = Convert.ToInt32(receive);
                    byte[] bmess  = new byte[1024];
                    if (ktraSoHH(a) == true)
                    {
                        String send="la so hoan hao";
                         bmess = ASCIIEncoding.ASCII.GetBytes(send);
                        
                    }
                    else
                    {
                        String send = "Khong phai so hoan hao";
                        bmess = ASCIIEncoding.ASCII.GetBytes(send);
                    }
                    s_socket.SendTo(bmess, c_iep);


                }
                Console.ReadKey();
                s_socket.Close();
            }
            catch (Exception ex) { Console.WriteLine("Loi: " + ex.Message); }
        }
    }
}
