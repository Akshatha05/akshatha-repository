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
            List<string> StringList = new List<string>();
            StringList.Add("Harry Potter");
            StringList.Add("Iron Man");
            StringList.Add("Captain America");
            foreach(var s in StringList)
            {
                Console.Write(s + " ");
                
            }
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
