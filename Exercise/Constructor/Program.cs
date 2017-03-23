using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {

        int x, y, z;
        static int stat;

        public Program(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Program(int w, int h) : this(0, w, h) {}

        public Program() {
            //Standardkonstruktor, initialsiert felder mit default werden (0, false, null, '\0', Enum(0))
        }

        static Program()
        {
            stat = 5; //Init statische felder, bevor klasse das erstemal aufgerufen wird
                      //keine angabe von scope, keine parameter
                      //ohne statischen konstruktor, statische felder werden mit nullwerten init
        }

        ~Program()
        {
            //Destruktor, kein scope, keine parameter
            //z.b. stream.close();
        }
       


        static void Main(string[] args)
        {
            Program prog = new Program();
        }
    }

    public struct Struct
    {
        int x, y, z;

        //Kein Standardkonstruktor erlaubt, compiler erzeugt automatisch, init felder mit nullwerten
        //sonst wie bei klasse
    }
}
