using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20MinPract
{
    class Program
    {
        static void Main(string[] args)
        {
          //task1();
          //task2();
                

        }
        static void task1()
        {
            Console.WriteLine("Введите два произвольных числа");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            ulong n1;
            ulong n2;
            if (!UInt64.TryParse(str1, out n1) || !UInt64.TryParse(str2, out n2))
            {
                Console.WriteLine("Многовато будет ");
            }
            else
            {
                ulong sum = n1 + n2;
                Console.WriteLine(sum);
            }
        }
        static void task2()
        {
            Console.WriteLine("Введите Число");

        }
    }

}
