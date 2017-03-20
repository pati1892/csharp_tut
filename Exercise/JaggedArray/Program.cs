using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] jaggedArray = new string[3][];
            jaggedArray[0] = new string[] { "Kevin", "Jaqueline", "Jeromie" };
            jaggedArray[1] = new string[5] { "Patrick", "Andreas", "Stefan", "Sarah", "Linda" };
            jaggedArray[2] = new string[]{ "Hans", "Peter", "Otto", "Fritz"};

            for(int i =0; i<jaggedArray.Length; i++)
            {
                for(int a = 0; a < jaggedArray[i].Length; a++)
                {
                    Console.Write(jaggedArray[i][a]+" ");
                }
                Console.Write('\n');
            }

        }
    }
}
