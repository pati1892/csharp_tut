using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByRef
{
    class Program
    {

        static void CallByRef(ref int x) 
        {
            ++x;
        }

        static void OutParams(out int x, out int y) //"rückgabe" von mehreren parameter, eig. referenzen, wert muss zugewiesen werden.
        {
            y = x = 1;
        }

       /* static void foo(ref int x)    Überladung mit ref und out nicht möglich, da beides refernzen.
        {

        }

        static void foo(out int x)
        {
            x = 4;
        }*/ 

        static void Main(string[] args)
        {
            int x = 1; // Muss vorher initialisiert sein.
            CallByRef(ref x);
            Console.WriteLine(x);

            int w, z; //Muss nicht initialisert sein
            OutParams(out w, out z);
            Console.WriteLine(w + " " + z);

        }
    }
}
