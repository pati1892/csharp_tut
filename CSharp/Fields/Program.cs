using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields
{
    class Program //internal, nur innerhalb Assemblies bekannt.
    {
        int value = 0; //Variable.
        const int size = 5; //Wird von Compiler überall, wo aufgerufen, durch 5 ersetzt.
        readonly int length; // Bekommt eigenen Speicherplatz, Speicherzelle wird zur Laufzeit abgefragt, kann aber nicht verändert werden.

        int priv; //private
        private int priv_1; //private
        protected int prot; //protected
        public int pub; //public

        static int stat; //statisch

        public Program() { }

        public Program(int length)
        {
            this.length = length; //readonly initialisierung hier möglich.
        }

        public void printFields()
        {
            Console.WriteLine(value + " " + size + " " + length);
        }


        static void Main(string[] args)
        {

            Program prog = new Program(64);
            prog.printFields();
        }
    }
}
