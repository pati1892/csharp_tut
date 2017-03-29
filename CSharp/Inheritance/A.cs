using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //vererbung nur bei klassen, nicht bei structs, könnne aber interface implementieren

    class Basisklasse
    {
        public virtual int PropVirtual
        {
            get;
            set;
        }

        public int Prop
        {
            get;
            set;
        }

        int a;
        public Basisklasse() { }
        public Basisklasse(int a)
        {
            this.a = a;
        }
        public virtual void VirtualMethod() {
            Console.WriteLine("VirtualMethod aus der Oberklasse");
        }

        public void Method()
        {
            Console.WriteLine("Method aus der Oberklasse");
        }

    }

    class Unterklasse : Basisklasse
    {
        //erbt feld a und methode f();
        //konstruktor wird nicht veerbt

        //sichtbar aus oberklasse:
        //public, protected,

        public new int Prop { get; set; }
        public override int PropVirtual { get; set; }

        int b;
        public Unterklasse() { }
        public Unterklasse(int a, int b) : base(a)
        {
            this.b = b;
        }
        public void G() { }

        public sealed override void VirtualMethod() //kann nichtmehr von anderen unterklassen überschrieben werden!
        {
            Console.WriteLine("Überschriebene VirtualMethod aus der Unterklasse");
        }

        public new void Method()
        {
            Console.WriteLine("Überdeckte Method aus der Unterklasse");
            Console.WriteLine("Zusätzlich Method aus der Oberklasse über base:");
            base.Method();
        }

    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Basisklasse basis = new Unterklasse();
            //a ist vom dynamischen Typ Unterklasse und
            //ihr statischer Typ ist Basisklasse
            Console.WriteLine("v is T: (Ist v vom dynamischen Typ T) " + (basis is Unterklasse));

            basis.VirtualMethod(); //Aufruf Unterklasse -> dynamische Bindung
            basis.Method(); //Auruf Oberklasse -> dynamische Bindung nur bei virtual

            Unterklasse unter = new Unterklasse();
            unter.Method();
            unter.VirtualMethod();
        }
    }
}
