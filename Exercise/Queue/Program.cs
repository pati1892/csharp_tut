using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Queue
    {
        private object[] elements = new object[10];
        private int tailValue = 0;
        private int headValue = 0;

        public int tail
        {
            set
            {
                tailValue = value % 10;
            }
            get
            {
                return tailValue;
            }
        }

        private int head
        {
            set
            {
                headValue = value % 10;
            }
            get
            {
                return headValue;
            }
        }

        private int getNextIndex()
        {
            if((tail == head) && (elements[head] != null)) ++head;
            return tail;
        }

        public void Enqueue(object element)
        {
            elements[getNextIndex()] = element;
            ++tail;
        }

        public object Dequeue()
        {
            object obj = elements[head];
            elements[head] = null;
            ++head;
            return obj;
        }

        public Queue()
        {
           

        }

        public void printQueue()
        {
            while(elements[head] != null)
            {
                Console.WriteLine(elements[head]);
                ++head;
                if (head == tail && elements[head] != null) break;

            }
        }
    }
}
