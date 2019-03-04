using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Print1to10(number);

        }

        private static bool Print1to10(int number)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("One");
                    return true;
                case 2:
                    Console.WriteLine("Two");
                    return true;
                case 3:
                    Console.WriteLine("Three");
                    return true;
                case 4:
                    Console.WriteLine("Four");
                    return true;
                case 5:
                    Console.WriteLine("Five");
                    return true;
                case 6:
                    Console.WriteLine("Six");
                    return true;
                case 7:
                    Console.WriteLine("Seven");
                    return true;
                case 8:
                    Console.WriteLine("Eight");
                    return true;
                case 9:
                    Console.WriteLine("Nine");
                    return true;
                case 10:
                    Console.WriteLine("Ten");
                    return true;
                default:
                    Console.WriteLine("Number not in range");
                    return false;

            }
        }
    }
}
