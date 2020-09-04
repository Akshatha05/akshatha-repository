using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace AnagramPair
{
    class GenericCollections
    {
        public static void Main()
        {
            //Generic Collection using List.
            List<string> StringList = new List<string>() { "Harry Potter", "Iron Man", "Captain America","Black Widow",
                "Black Panther" };

            foreach(var s in StringList)
            {
                Console.WriteLine(s + "," + " ");
                
            }
            //Removing element from list
            StringList.RemoveRange(1,3);
            Console.WriteLine("Elements after removing");
            foreach (var s in StringList)
            {
                Console.Write(s + "," + " ");
            }
            //Sorting of list
             List<string> StringList1 = new List<string>() { "Harry Potter", "Iron Man", "Captain America","Black Widow",
                "Black Panther" };
            StringList1.Sort();
            Console.WriteLine("Elements after sorting :");
            foreach (var s in StringList1)
            {
                Console.Write( s +"," + " ");
            }


            /*-------------------*/
            //Collection Class
            Collection<string> NameCollection = new Collection<string>();
            NameCollection.Add("Black Widow");
            NameCollection.Add("Black Panther");
            NameCollection.Add("Bucky");
            Console.WriteLine("The element Count {0}",NameCollection.Count);
            Console.WriteLine("The element Black Panther at position {0}", NameCollection.IndexOf("Black Panther"));
            NameCollection.Insert(3, "Captain Marvel");
            
        }
    }
}
