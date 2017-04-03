using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        //ist ein Methodentyp, dient zur deklaration von variablen, in denen Methoden gespeichert werden können

        delegate void Notifier(String sender);
        delegate void Adder(int x);

        static void SayHello(String sender)
        {
            Console.WriteLine("Hallo " + sender);
        }

        static void SayGoodBye(String sender)
        {
            Console.WriteLine("Tschüss " + sender);
        }

        void Add(int x)
        {
            Console.WriteLine(x + 2);
        }

        static void AddStatic(int x)
        {
            Console.WriteLine(x + 2);
        }

        static void Main(string[] args)
        {
            Notifier notify = new Notifier(SayHello);
            notify += new Notifier(SayGoodBye);
            notify("Patrick");
            Program prog_1 = new Program();
            Program prog_2 = new Program();
            Adder add = new Adder(prog_1.Add);
            add += new Adder(prog_2.Add);
            Console.WriteLine("Delegate calls the Method of the two Objects");
            add(2);
            Console.WriteLine("Remove first Method call");
            add -= prog_1.Add;
            add(2);
            Console.WriteLine("Add static Method");
            add += new Adder(Program.AddStatic);
            add(2);
            Console.WriteLine("Alternativ assignment");
            Adder addIt = prog_1.Add;
            addIt(2);
            
        }
    }
}
