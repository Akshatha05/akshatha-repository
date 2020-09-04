using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramPair.Numbers
{
    class FibonaciSeries
    {
        //find nth fibonaci series
        public static void Main()
        {
            Console.WriteLine("Enter the range");
            int range = Convert.ToInt32(Console.ReadLine());
            int a = 0;int b = 1;
            Console.Write("The fibonaci series is "+a + "," + b);
            for(int i=0;i<range-2;i++)
            {
                int c = a + b;
                Console.Write("," + c);
                a = b; b = c;//sd
               
            }
            Console.WriteLine();
                Console.WriteLine("The value of nth number is {0}",b);

        }


    }
}
