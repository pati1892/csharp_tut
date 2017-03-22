using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    public struct Time
    {
        int hour;
        int min;
        public Time(int hour, int min)
        {
            this.hour = hour;
            this.min = min;
        }
    }

    namespace B
    {
        class Programm
        {
            static void Main(string[] args)
            {
                Time time = new A.Time(10, 05);
            }
        }
    }

}
