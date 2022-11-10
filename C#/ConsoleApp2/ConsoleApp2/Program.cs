using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        struct member
        {
            public string Login;
            public string Password;
            public string name;
        }
        private static void InputInfor(out member Infor)
        {
            Console.WriteLine("Input login");
            Infor.Login = Console.ReadLine();
            Console.WriteLine("Input password");
            Infor.Password = Console.ReadLine();
            Console.WriteLine("Input name");
            Infor.name = Console.ReadLine();
        }
        static void checkInfor(member Infor)
        {
            Console.WriteLine("enter login: ");
            string checklogin1 = Console.ReadLine();
            if (checklogin1 == Infor.Login)
            {
                Console.WriteLine("This account exists");
            }
            else
            {
                Console.WriteLine("This account does not exist");
            }

            Console.WriteLine("enter password");

            for (int i = 1; i <= 3; i++)
            {
                string checkPassword1 = Console.ReadLine();
                if (checkPassword1 == Infor.Password)
                {
                    Console.WriteLine("correct password");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong Password");
                    Console.WriteLine("Enter the password one more time");
                }
            }
        }

        static void Main(string[] args)
        {
            // Input member number
            Console.Write("Input n member: ");
            int n = int.Parse(Console.ReadLine());
            member[] arr = new member[n];

            //for loop to input
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(" Input member: ");
                InputInfor(out arr[i]);
            }
            // for loop check infor
            for (int i = 0; i < n; i++)
            {
                checkInfor(arr[i]);
            }
            Console.ReadKey();

        }
    }
}