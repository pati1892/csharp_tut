using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Vehicle
    {
        private string brand;
        private string color;
        private int kwh;

        private readonly double CONVERSION = 1.3428;

        public string Brand
        {
            get { return brand; }
        }

        public string Color
        {
            get { return color; }
        }

        public int HP
        {
            get { return (int)(kwh * CONVERSION); }
            set { kwh = (int)(value / CONVERSION); }
        }

        public int KWH
        {
            get { return kwh; }
            set { kwh = value; }
        }

        public Vehicle(string brand, string color, int kwh)
        {
            this.brand = brand;
            this.color = color;
            this.kwh = kwh;
        }




    }
}
