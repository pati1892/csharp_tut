using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class Sequence
    //wenn klasse min. eine abstrakte methode, ist sie selbst abstrakt
    {
        public abstract void Add(object x);
        public abstract string Name { get; }
        public abstract object this[int i] { get; set; }

    }

    sealed class List : Sequence
    {
        public sealed override void Add(object x) //Auch nur bei einer Methode möglich, anstatt ganze klasse
        {
            throw new NotImplementedException();
        }
        public override string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public override object this[int i]
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }

    //class LinkedList : List
    //{
        //Nicht Möglich da sealed
    //}
}
