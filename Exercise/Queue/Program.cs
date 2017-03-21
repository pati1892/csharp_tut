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
        private int backValue = 0;
        private int frontValue = 0;

        public int back
        {
            set
            {
                backValue = value % 10;
            }
            get
            {
                return backValue;
            }
        }

        private int front
        {
            set
            {
                frontValue = value % 10;
            }
            get
            {
                return frontValue;
            }
        }

        private int getNextIndex()
        {
            if((back == front) && (elements[front] != null)) ++front;
            return back;
        }

        public void Enqueue(object element)
        {
            elements[getNextIndex()] = element;
            ++back;
        }

        public object Dequeue()
        {
            object obj = elements[front];
            elements[front] = null;
            ++front;
            return obj;
        }

        public Queue()
        {
           

        }

        public void printQueue()
        {
            while(elements[front] != null)
            {
                Console.WriteLine(elements[front]);
                ++front;
                if (front == back && elements[front] != null) break;

            }
        }
    }
}
