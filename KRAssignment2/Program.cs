using System;
using System.Text.RegularExpressions;

namespace KRAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu();

        }

        public static string sideA()
        {
            Console.WriteLine("Insert the length of the first side of the triangle.");
            String a = Console.ReadLine();
            Match m = Regex.Match(a, @"^\d$");
            if (m.Success)
            {
               return a;
            }
            else
            {
               return "";
            }

        }


        public static string sideB()
        {
            Console.WriteLine("Insert the length of the second side of the triangle.");
            string b = Console.ReadLine();
            Match m = Regex.Match(b, @"^\d$");
            if (m.Success)
            {
                return b;
            }
            else
            {
              return "";
            }
        }

        public static string sideC()
        {
            Console.WriteLine("Insert the length of the third side of the triangle.");
            String c = Console.ReadLine();
            Match m = Regex.Match(c, @"^\d$");
            if (m.Success)
            {
                return c;
            }
            else
            {
                return "";
            }
        }


        public static void Menu()
        {
            Console.WriteLine("1. Enter triangle dimensions");
            Console.WriteLine("2. Exit");
            String option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    String type = TriangleSolver.Analize(sideA(), sideB(), sideC());
                    Console.WriteLine(type);
                    break;
                case "2":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Option not defined try again!");
                    Menu();
                    break;
            }
        }
    }
}
