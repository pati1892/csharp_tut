using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IWriter
    {
        //keine statischen erlaubt
        void Write(char c); //public, abstract, virtual
        void Clear();

    }

    interface IStringWriter : IWriter
    {
       void Write(String s);
    }


    class TextField : IStringWriter
    {
        char[] buf = new char[128];
        public void Write(char c)
        {

        }

        public virtual void Clear()
        {

        }
        public void Write(String s)
        {

        }
    }

}
