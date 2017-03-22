using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Struct
{
    public struct Queue
    {
        public int headValue, tailValue; //Für Stack müssen Member public sein, sonst keine initialisierung möglich
        public object[] elements;

        public Queue(int size) //Nur parametierter konstruktor möglich, sonst fehler
        {
            headValue = 0;
            tailValue = 0;
            elements = new object[size];
        }
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
            if ((tail == head) && (elements[head] != null)) ++head;
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

        public void printQueue()
        {
            while (elements[head] != null)
            {
                Console.WriteLine(elements[head]);
                ++head;
                if (head == tail && elements[head] != null) break;

            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            //Muss initialisiert werden, da kein Konstruktoraufruf, Properties können nicht benutz werden!
            Queue queueStack;
            queueStack.tailValue = 0;
            queueStack.headValue = 0;
            queueStack.elements = new object[10];

            //Hier auch anlegen auf dem stack, Konstruktor und Properties können genutzt werden!
            Queue queue = new Queue(10);
            queue.Enqueue(0);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);
            queue.Enqueue(10);
            queue.Enqueue(11);

            queue.printQueue();
            Console.WriteLine("Dequeue: " + queue.Dequeue());
            Console.WriteLine("Dequeue: " + queue.Dequeue());
            queue.Enqueue(213);
            Console.WriteLine("Dequeue: " + queue.Dequeue());
            queue.printQueue();
        }
    }
}
