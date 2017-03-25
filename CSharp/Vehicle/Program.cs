using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {

            Vehicle seat = new Vehicle("Seat", "black", 80);
            Console.WriteLine(seat.Brand + " " + seat.HP);
            seat.HP = 220;
            Console.WriteLine(seat.KWH);
        }
    }
}
