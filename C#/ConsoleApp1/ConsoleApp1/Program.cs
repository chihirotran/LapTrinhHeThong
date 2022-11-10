using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        struct member
        {
            public int number;
            public string surname;
            public string name;
            public int year;
            public int month;
        }

        private static void Inputmember(member SV)
        {
            Console.Write(" Number: ");
            SV.number = int.Parse(Console.ReadLine());
            Console.Write(" Surname: ");
            SV.surname = Console.ReadLine();
            Console.Write(" Name: ");
            SV.name = Console.ReadLine();
            Console.Write("Input year: ");
            SV.year = int.Parse(Console.ReadLine());
            Console.Write("Input month: ");
            SV.month = int.Parse(Console.ReadLine());
        }
        private static void Inputmembertable(member SV, DataTable table)
        {
            Console.Write(" Number: ");
            SV.number = int.Parse(Console.ReadLine());
            Console.Write(" Surname: ");
            SV.surname = Console.ReadLine();
            Console.Write(" Name: ");
            SV.name = Console.ReadLine();
            Console.Write("Input year: ");
            SV.year = int.Parse(Console.ReadLine());
            Console.Write("Input month: ");
            SV.month = int.Parse(Console.ReadLine());
            table.Rows.Add(SV.number, SV.surname, SV.name,SV.year,SV.month);
        }

        static void Outputmember(member SV)
        {
            Console.Write(SV.number+"".PadRight(15));
            Console.Write(SV.surname);
            Console.Write(SV.name);
            Console.Write(SV.year * 365 * 24 * 64 * 64 + SV.month * 30 * 24 * 64 * 64);

        }
        public static DataTable InitEmployee()
        {
            Console.Write("Nhap n member: ");
            int n = int.Parse(Console.ReadLine());
            member[] arr = new member[n];
            var table = new DataTable();
            table.Columns.Add("number", typeof(int));
            table.Columns.Add("surname", typeof(string));
            table.Columns.Add("name", typeof(string));
            table.Columns.Add("year", typeof(int));
            table.Columns.Add("month", typeof(int));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(" Input member: ");
                Inputmembertable(arr[i],table);
                
            }
            return table;
        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var data = InitEmployee();
            string[] columnNames = data.Columns.Cast<DataColumn>()
                                 .Select(x => x.ColumnName)
                                 .ToArray();

            DataRow[] rows = data.Select();

            var table = new ConsoleTable(columnNames);
            foreach (DataRow row in rows)
            {
                table.AddRow(row.ItemArray);
            }
           // table.Write(Format.MarkDown);
            table.Write(Format.Alternative);
            //table.Write(Format.Minimal);
           // table.Write(Format.Default);
            Console.Read();
            Console.ReadKey();
            /*for (int i = 0; i < n; i++)
            {
                Console.WriteLine(" Input member: ");
                Inputmember( arr[i]);
            }
            Console.Write("Number".PadRight(15) + "Surname".PadRight(15) + "Name".PadRight(15) + "AgeSeconds".PadRight(15));
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(" Output member: ");
                Outputmember(arr[i]);
            }*/

            // member
            //Input
            //member SV1 = new member();
            //Console.WriteLine(" Input member: ");
            //Inputmember(out SV1);
            //member SV2 = new member();
            //Console.WriteLine(" Input member: ");
            //Inputmember(out SV2);
            //member SV3 = new member();
            //Console.WriteLine(" Input member: ");
            //Inputmember(out SV3);


            //output
            //Console.WriteLine("*******");
            //Console.WriteLine(" Output member: ");
            //Outputmember(SV1);
            //Console.WriteLine("*******");
            //Console.WriteLine(" Output member: ");
            //Outputmember(SV2);
            //Console.WriteLine("*******");
            //Console.WriteLine(" Output member: ");
            //Outputmember(SV3);

            //Console.ReadKey();
        }
    }
}