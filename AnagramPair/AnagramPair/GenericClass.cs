using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace AnagramPair
{
    class GenericClass
    {
     public static void Main()
        {
            ImplementGeneric<int> G = new ImplementGeneric<int>();
          Console.WriteLine(G.Area(25, 25));
        }
        
    }

    // Making class as generic to make it type safe.
    public class ImplementGeneric<T>
    {
        public T Length { get; set; }
        public T Width { get; set; }

     
        public  T Area (T a,T b)
        {
            dynamic first = a;
            dynamic second = b;
            return first * second;
               
        }


    }
}
