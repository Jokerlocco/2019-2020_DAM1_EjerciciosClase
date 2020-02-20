// DAVID BERENGUER ANTON

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListWithArray
{
    class SortedListOfString
    {
        const int MAX = 1000;
        private int count;
        public int Count
        {
            get { return count; }
        }

        private string[] data;

        public SortedListOfString()
        {
            data = new string[MAX];
            count = 0;
        }

        public string Get(int n)
        {
            if (n < count)
            {
                return data[n];
            }
            else
                throw new IndexOutOfRangeException();
        }

        public Boolean Contains(string text)
        {
            for(int i = 0; i < count; i ++)
            {
                if (data[i] == text)
                    return true;
            }
            return false;
        }

        public void Add(string text)
        {
            int pos = 0;
            while(pos < count && data[pos].CompareTo(text) < 0)
            {
                pos++;
            }
            for (int i = count+1; i > pos; i--)
            {
                data[i] = data[i - 1];
            }
            data[pos] = text;
            count ++;
        }
        

    }
    class Program
    {
        static void Main(string[] args)
        {
            SortedListOfString myList = new SortedListOfString();

            myList.Add("Hola");
            myList.Add("Adios");
            Console.WriteLine( myList.Get(0) );
            
            myList.Add("Az");
            myList.Add("Mno");
            myList.Add("Abc");
            
            for (int i = 0; i < myList.Count; i++)
            {
                Console.Write( myList.Get(i) + " ");
            }
        }
    }
}
