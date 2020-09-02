using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramPair
{
    class AnagramPair
    {
        static void Main(string[] args)
        {
            string[] Input ={"geeksquiz", "geeksforgeeks", "abcd",
                 "forgeeksgeeks", "zuiqkeegs"};
            int length = Input.Length;
            char[] a = new char[length];

            for (int i = 0; i < Input.Length; i++)
            {
                for(int j=i+1;j<Input.Length;j++)
                    {
                    char[] CharArray1 = Input[i].ToLower().ToCharArray();
                    char[] CharArray2 = Input[j].ToLower().ToCharArray();
                    Array.Sort(CharArray1);Array.Sort(CharArray2);
                    string s1 = new string(CharArray1);
                    string s2 = new string(CharArray2);
                    if(s1==s2)
                    {
                        Console.WriteLine("The {0} is  Anagram Pair.", Input[i]);
                    }
                }
            }
        }
    }
}
