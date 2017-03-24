using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Number
    {
        public int Value
        {
            get;
            set;
        }

        public Number(int value)
        {
            Value = value;
        }

        public static Number operator + (Number a, Number b)
        {
            return new Number(a.Value + b.Value);
        }

        public static Number operator + (Number a)
        {
            return new Number(a.Value);
        }

        public static bool operator == (Number a, Number b)
        {
            return a.Value == b.Value;
        }

        public static bool operator != (Number a, Number b)
        {
            return a.Value != b.Value;
        }

        public static Number operator | (Number a, Number b)
        {
            return new Number((a.Value | b.Value));
        }

        public static Number operator & (Number a, Number b)
        {
            return new Number(a.Value & b.Value);
        }
        
        public static bool operator true (Number a)
        {
            if (a.Value > 0) return true;
            return false;
        }

        public static bool operator false (Number a)
        {
            if (a.Value <= 0) return false;
            return true;
        }

        public static implicit operator Number(int x)
        {
            return new Number(x);
        }

        public static explicit operator int(Number num)
        {
            return num.Value;
        }


        static void Main(string[] args)
        {
            Number a = new Number(1);
            Number b = new Number(2);
            Print(a + b);               //binär +
            Print(+a);                  //unär +

            Print(a == b);              //gleichheit
            Print(a != b);              //ungleichheit

            Print(a | b);               //oder
            Print(a & b);               //und

            if (a && b) Console.WriteLine("&&"); // &/| und false/true müssen überladen sein
            // -> false(a) ? x : (a & b)

            Print((int)a);
            b = 3;
            Print(b);

        }
        static void Print(Number num)
        {
            Console.WriteLine(num.Value);
        }
        static void Print(Boolean b)
        {
            Console.WriteLine(b);
        }
        static void Print(int b)
        {
            Console.WriteLine(b);
        }
    }
}
