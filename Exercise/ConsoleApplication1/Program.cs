using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxValue(1, 3, 2));
            Console.WriteLine(SwitchCase("one"));
            ForEach(new int[]{ 1,2,3,4,5});
        }

        static int MaxValue(int a, int b, int c) // if
        {
            if (a > b && a > c) return a;
            else if (b > a && b > c) return b;
            else return c;
        }

        static int SwitchCase(string value)
        {
            switch (value)
            {
                case ("one"): return 1;
                case ("two"): return 2;
                case ("three"): return 3;
                default: return -1; 
                    
            }

        }

        static void ForEach(int[] array)
        {
            foreach(int obj in array)
            {
                Console.WriteLine(obj.ToString());
            }
        }
        

        }


    }
