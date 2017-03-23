using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Program
    {
        //START INDEXER
        int[] array = new int[] {0,1,2,3,4,5,6,7,8,9};
        enum Days
        {
            One, Two, Three, Four, Five
        }

        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value; 
            }
        }

        public int this[int index, int mul]
        {
            get
            {
                return array[index] * mul;
            }
        }

        public string this[string day]
        {
            get {
                Days d = (Days)Enum.Parse(typeof(Days), day);
                return d.ToString();    
            }            
        }
        //END INDEXER
    

        static void Main(string[] args)
        {
            Program prog = new Program();
            Console.WriteLine(prog[1]);
            Console.WriteLine(prog[2, 2]);
            Console.WriteLine(prog["Three"]);

        }
    }
}
