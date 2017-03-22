using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeInfoAtRuntime
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 65;
            PrintInfo(a);
            PrintInfo(new Program());
        }

        static void PrintInfo(object obj)
        {
            Type t = obj.GetType();
            PrintString(t.FullName);
            PrintString(t.Name);
            PrintString(t.Namespace);
            PrintString(t.Assembly.ToString());                        
        }

        static void PrintString(string s)
        {
            if(s != null)
                Console.WriteLine(s);
        }
    }
}
