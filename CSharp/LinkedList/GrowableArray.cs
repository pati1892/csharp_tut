using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowableArray
{
    public class GrowableArray
    {

        private object[] array;

        private int Size
        {
            set;
            get;
        }

        public GrowableArray(int size)
        {
            if (size > 0)
            {
                array = new object[size];
                Size = size;
            }
            else
                throw new Exception("Size has to be greater then zero");
        }

        public void Add(object obj, int index)
        {
            if (index >= Size)
            {
                Grow(index);
            }
            array[index] = obj;
        }

        public void Grow(int index)
        {
            Size += index;
            object[] newArray = new object[Size];
            int i = 0;
            foreach (object obj in array)
            {
                newArray[i] = obj;
                ++i;
            }
            this.array = newArray;
        }

        public object this[int index]
        {
            get
            {
                if (index >= Size)
                    throw new IndexOutOfRangeException("Index ist zu groß");
                else
                    return array[index];
            }
            set
            {
                Add(value, index);
            }
        }


        static void Main(string[] args)
        {
            GrowableArray array = new GrowableArray(5);
            array[8] = 8;
            array[0] = 0;
            array[1] = 1;
            array[3] = 3;
            try
            {
                Console.WriteLine(array[53]);
            }catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }


        }


    }
}

