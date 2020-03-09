//DAVID BERENGUER ANTON

using System;


class SortedListSS
{
    const int TAM_MAX = 1000;


    public struct Pair : IComparable<Pair>
    {
        public string key;
        public string value;

        public int CompareTo(Pair other)
        {
            return this.key.CompareTo(other.key);
        }
    }

    private Pair[] diccionary;

    private int count;
    public int Count
    {
        get { return count; }
    }

    public SortedListSS()
    {
        diccionary = new Pair[TAM_MAX];
        count = 0;
    }

    public void Add(string key, string value)
    {
        diccionary[count].key = key;
        diccionary[count].value = value;
        count++;
        Array.Sort(diccionary);
    }

    public string GetKey(int n)
    {
        return diccionary[n].key;
    }
    public string GetValue(int n)
    {
        return diccionary[n].value;
    }
    public bool Contains(string key)
    {
        for (int i = 0; i < diccionary.Length; i++)
        {
            if (diccionary[i].key == key)
            {
                return true;
            }
        }
        return false;
    }

    public string GetByKey(string key)
    {
        for (int i = 0; i < diccionary.Length; i++)
        {
            if (diccionary[i].key == key)
            {
                return diccionary[i].value;
            }
        }
        throw new Exception();
    }
}

class Test
{
    static void Main()
    {
        SortedListSS myList = new SortedListSS();

        myList.Add("hello", "bye");
        myList.Add("sugar", "salt");
        myList.Add("sea", "mountain");

        Console.WriteLine(myList.GetByKey("sugar"));

        for (int i = 0; i < myList.Count; i++)
        {
            Console.WriteLine(myList.GetKey(i));
            Console.WriteLine(myList.GetValue(i));
        }
    }
}
