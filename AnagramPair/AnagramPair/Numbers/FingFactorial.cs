using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramPair.Numbers
{
    class FingFactorial
    {
        //using for loop
        public static void Main()
        {
            Console.WriteLine("Enter the range");
            int range = Convert.ToInt32(Console.ReadLine());
            int num = range;
            for(int i=range-1;i>0;i--)
            {
                int fact = num * i;
                num = fact;
            }
            Console.WriteLine("The factorial of number {0} is {1}", range, num);
        }
    }
}
