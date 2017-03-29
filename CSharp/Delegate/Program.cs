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

        static void SayHello(String sender)
        {
            Console.WriteLine(sender);
        }

        static void SayGoodBye(String sender)
        {
            Console.WriteLine(sender);
        }

        static void Main(string[] args)
        {
            Notifier notify = new Notifier(SayHello);
            notify("Hallo");
        }
    }
}
