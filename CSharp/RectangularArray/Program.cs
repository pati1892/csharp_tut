using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangularArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] rectArray = new string[3, 2];
            rectArray[0, 0] = "Hallo";
            rectArray[0, 1] = "Welt";
            rectArray[1, 0] = "Patrick";
            rectArray[1, 1] = "Henkelmann";
            rectArray[2, 0] = "Linda";
            rectArray[2, 1] = "Henkelmann";

            printArray(rectArray);

            string[,] a = {
      {"black", "white"},
      {"above", "below"},
      {"north", "south"}};
            printArray(a);


        }

        static void printArray(string[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
