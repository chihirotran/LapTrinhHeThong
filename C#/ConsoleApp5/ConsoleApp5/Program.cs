using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] e = new byte[1024];
            String a = Console.ReadLine();
            Console.WriteLine(a);
            byte[] b = ASCIIEncoding.ASCII.GetBytes(a);
            e = ASCIIEncoding.ASCII.GetBytes(a);
            String b3 = ASCIIEncoding.ASCII.GetString(e);
            String b2 = ASCIIEncoding.ASCII.GetString(b);
            Console.WriteLine(b2+"*"+ b3 + "*");
            Console.ReadKey();
        }
    }
}
