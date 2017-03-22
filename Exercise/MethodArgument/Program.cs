using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodArgument
{
    class Program
    {
        static void OneParameter(int x)
        {
            Console.WriteLine(x);
        }

        static void ParameterList(params int[] val)
        {
            foreach(var i in val)
            {
                Console.WriteLine(i);
            }
        }

        static void OptionalParams(int a, int b = 1, int c = 2)
        {
            Console.WriteLine(a + b + c);
        }

        static void Main(string[] args)
        {
            OptionalParams(1);
            OptionalParams(1, 2);
            OptionalParams(1, c: 3);

            ParameterList(1, 1, 1);

        }
    }
}
