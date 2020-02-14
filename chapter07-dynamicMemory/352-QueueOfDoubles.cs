// David Berenguer

using System;
using System.Collections.Generic;

namespace queueClass
{
    class Program
    {
        static void Main()
        {
            QueueOfDouble data = new QueueOfDouble();

            data.Enqueue(2345.1234);
            data.Enqueue(23234.1234);
            data.Enqueue(2323234.1234);

            int amount = data.Count;
            Console.WriteLine(data.Peek());
            Console.WriteLine(amount);
            for (int i = 0; i < data.Count; i++)
            {
                Console.WriteLine(data.Dequeue());
            }
        }
    }

    class QueueOfDouble
    {
        public int Count { get {return l1.Count;}  }
        private List<double> l1;
        
        public QueueOfDouble()
        {
            l1 = new List<double>();
        }

        public void Enqueue(double num)
        {
            l1.Add(num);
        }

        public double Dequeue()
        {
            double first = l1[0];
            l1.RemoveAt(0);
            return first;
        }

        public double Peek()
        {
            return l1[0];
        }
    }
}
