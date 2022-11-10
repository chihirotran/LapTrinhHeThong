using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread_cs
{
    class Params
    {
        public int sr { get; set; }
        public int er { get; set; }
        public DateTime st { get; set; }

        public Params() { }

        public Params(int _sr, int _er, DateTime _st)
        {
            sr = _sr;
            er = _er;
            st = _st;
        }
    }

    class Program
    {
        //public static string message = "";
        //public static bool check_changed = false;

        //public static void getData()
        //{
        //    do
        //    {
        //        message = Console.ReadLine();
        //        check_changed = true;

        //    } while (message.ToLower() != "thoat");
        //}

        //public static void showData()
        //{
        //    while(message.ToLower() != "thoat")
        //    {
        //        if (check_changed == true)
        //        {
        //            Console.WriteLine("message: " + message);
        //            check_changed = false;
        //        }
        //        Thread.Sleep(100);
        //    }

        //}

        public static int[,] a;
        public static int[,] b;
        public static int[,] c;
        public static int m, n;
        public static void MaTran()
        {
            Console.Write("Nhap so hang m = ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so cot n = ");
            n = Convert.ToInt32(Console.ReadLine());

            // Cấp phát bộ nhớ cho ma trận
            a = new int[m, n]; b = new int[m, n]; c = new int[m, n];

            Console.WriteLine("Nhap cac phan tu cua ma tran a:");
            // Duyệt từ hàng 0 => hàng m - 1;
            for (int i = 0; i < m; i++)
            {
                // Xét hàng thứ i
                // Duyệt từ cột 0 => cột n - 1 của hàng i
                for (int j = 0; j < n; j++)
                {
                    // Xét hàng i, cột j
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Nhap cac phan tu cua ma tran b:");
            // Duyệt từ hàng 0 => hàng m - 1;
            for (int i = 0; i < m; i++)
            {
                // Xét hàng thứ i
                // Duyệt từ cột 0 => cột n - 1 của hàng i
                for (int j = 0; j < n; j++)
                {
                    // Xét hàng i, cột j
                    Console.Write($"b[{i},{j}] = ");
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Ma tran a la: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{a[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Ma tran b la: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{b[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        public static void TinhTich(object obj)
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
            Console.WriteLine("Time: "+ DateTime.Now.Subtract(st));
        }


        static void Main(string[] args)
        {
            //Thread t1 = new Thread(new ThreadStart(getData));
            //Thread t2 = new Thread(new ThreadStart(showData));

            //t1.Start();
            //t2.Start();

            MaTran();

            DateTime st = DateTime.Now;
            Thread t1 = new Thread(new ParameterizedThreadStart(TinhTich));
            t1.Start(new Params(0, 2, st));
            Thread t2 = new Thread(new ParameterizedThreadStart(TinhTich));
            t2.Start(new Params(2, n, st));

            Console.ReadKey();

        }
    }
}
