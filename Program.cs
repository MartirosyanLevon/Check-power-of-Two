using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check__power_of_two
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            Console.WriteLine("Write a numbre for check:");
            int x = Convert.ToInt32(Console.ReadLine());
            s = x & (x - 1);
            if (s == 0)
            {
                Console.WriteLine("The numbre is = power of 2");
            }
            else
            {
                Console.WriteLine("The numbre in not = power of two 2");
            }
            Console.ReadKey();
        }
    }
}
