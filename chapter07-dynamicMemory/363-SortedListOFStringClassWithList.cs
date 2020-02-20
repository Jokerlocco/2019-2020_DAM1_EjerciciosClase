// DAVID BERENGUER ANTON

using System;
using System.Collections.Generic;


namespace SortedListWithArray
{
    class SortedListOfString
    {
        public int Count
        {
            get { return data.Count; }
        }

        private List<string> data;

        public SortedListOfString()
        {
            data = new List<string>();
        }

        public string Get(int n)
        {
            return data[n];
        }

        public bool Contains(string text)
        {
            return data.Contains(text);
        }

        public void Add(string text)
        {
            int pos = 0;
            while(pos < data.Count 
                && data[pos].CompareTo(text) < 0)
            {
                pos++;
            }
            data.Insert(pos, text);
        }
        

    }
    class Program
    {
        static void Main(string[] args)
        {
            SortedListOfString myList = new SortedListOfString();

            myList.Add("Hola");
            myList.Add("Adios");
            Console.WriteLine(myList.Get(0));
            
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
