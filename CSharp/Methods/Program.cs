using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        int x = 0;
        public void Prozedur() //prozedur, kein rückgabewert.
        {
            ++x;
        }

        public int Function() //Funktion
        {
            return x; 
        }

        //Kurzformen
        public void Increase(int x) => this.x += x; 
        public int Add(int x) => this.x +=x;
        public int Value => x;
        public int this[int i] => x;

        override public string ToString()
        {
            return x.ToString();
        }

        static void Main(string[] args) //statische Methode
        {
            Program prog = new Program();
            prog.Increase(3);
            Print(prog);
            Console.WriteLine(prog.Add(2));
            Console.WriteLine(prog.Value);
            Console.WriteLine(prog[1]);


        }

        static void Print(Program x) => Console.WriteLine(x);
    }
}
