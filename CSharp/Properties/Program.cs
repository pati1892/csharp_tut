using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        private int size;
        
        public int Size //get und set müssen nicht immer vorhanden sein, einer von beiden kann scope haben der restriktiver ist als propertie
        {               //können nicht als ref oder out parameter genutzt werden
            private get
            {
                return size;
            }
            set
            {
                size = 2 * value;
            }
        }

        public int Length //automatische properties, compiler hinterlegt feld, keine logik in get und set
        {
            get;
            set;
        }

        public int Hight
        {               //readonly parameter, mit "=" kann initialisiert werden
            get;
        } = 5;



        static void Main(string[] args)
        {
        }
    }
}
