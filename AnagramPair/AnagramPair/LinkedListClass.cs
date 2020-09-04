using System;
using System.Collections.Generic;
namespace AnagramPair
{
    class LinkedListClass
    {
       public static void Main()
        {
            checkLinkedList list = new checkLinkedList();
            list.ListMethod();
        }
    }

    public class checkLinkedList
    {
        public void ListMethod()
        {
            LinkedList<string> NameList = new LinkedList<string>();
            LinkedListNode<string> start = NameList.First;
            LinkedListNode<string> End = null;
            

            NameList.AddFirst("Captain America");
            NameList.AddLast("Black Panther");
            NameList.AddLast("spider Man");
            NameList.AddLast("Ant Man");
            Console.Write("Elements of LinkedList are:" + " ");
            foreach(var L in NameList)
            {
                Console.WriteLine(L);
            }
        }
        
    }
}
