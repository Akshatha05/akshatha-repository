using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramPair.Numbers
{
    class SwapNumber
    {
        public static void Main()
        {
            //using temp
            Console.WriteLine("Enter the two numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numbers before swapping {0},{1}", a, b);
            int temp = a;
            a = b; b = temp;
            Console.WriteLine("Numbers after swapping {0},{1}",a, b);

            //without using temp
            int c = 20; int d = 30;
            Console.WriteLine("Numbers before swapping {0},{1}",c,d);
            c = c + d;
            d = c - d;
            c = c - d;
            Console.WriteLine("Numbers after swapping {0},{1}", c,d);
        }
    }
}
