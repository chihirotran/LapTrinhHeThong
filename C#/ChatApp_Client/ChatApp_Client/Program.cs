using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ChatApp_Client
{
    internal class Program
    {

        public static void InputThread(object param)
        {
            Socket clientSocket = (Socket)param;
            string send = "";
            do
            {
                send = Console.ReadLine();
                byte[] bsend = ASCIIEncoding.ASCII.GetBytes(send);
                clientSocket.Send(bsend);
            } while (send.ToLower() != "thoat");
        }

        public static void OutThread(object param)
        {
            Socket clientSocket = (Socket)param;
            string message = "";
            while (message != "thoat")
            {
                byte[] breceive = new byte[1024];
                int len = clientSocket.Receive(breceive);
                message = ASCIIEncoding.ASCII.GetString(breceive, 0, len);
                Console.WriteLine("<Server>: " + message);

            }
        }

        static void Main(string[] args)
        {
            IPEndPoint s_iep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8888);
            Socket clientSocket = new Socket(SocketType.Stream, ProtocolType.Tcp);
            clientSocket.Connect(s_iep);
            Console.WriteLine("Ket noi thanh cong");

            Thread t1 = new Thread(new ParameterizedThreadStart(InputThread));
            Thread t2 = new Thread(new ParameterizedThreadStart(OutThread));

            t1.Start(clientSocket);
            t2.Start(clientSocket);
        }
    }
}