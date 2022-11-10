using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread
{
    internal class Program
    {
        public static string mess = "";
        public static bool check = false;
        public static void showdata()
        {
            while (mess.ToLower() != "thoat")
            {
                if (check)
                {
                    Console.WriteLine("mess: " + mess);
                    check = false;
                    Thread.Sleep(1000);
                }
                
            }
        }
        public static void getdata()
        {
            do
            {
                Console.WriteLine("Nhap:");
                mess = Console.ReadLine();
                check = true;
            }
            while (mess.ToLower() != "thoat");

        }
        static void Main(string[] args)

        {
            Thread t1 = new Thread(new ThreadStart(getdata));  
            Thread t2 = new Thread(new ThreadStart(showdata));
            t1.Start();
            t2.Start();
        }

    }
}
