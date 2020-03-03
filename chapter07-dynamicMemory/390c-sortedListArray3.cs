//Abraham García

using System;

class SortedListSS
{
    private string[] keys;
    private string[] values;
    private int count;
    private const int MAX = 200;
    public int Count { get { return count; } }
    

    public SortedListSS()
    {
        count = 0;
        keys = new string[MAX];
        values = new string[MAX];
    }

    public void Add(string key, string value)
    {
        int pos = 0;
        while (pos < count && keys[pos].CompareTo(key) < 0)
        {
            pos++;
        }

        for (int i = count; i > pos; i--)
        {
            keys[i] = keys[i - 1];
            values[i] = values[i - 1];
        }
        keys[pos] = key;
        values[pos] = value;
        count++;
    }

    public string GetKey(int n)
    {
        return keys[n];
    }

    public string GetValue(int n)
    {
        return values[n];
    }

    public bool Contains(string key)
    {
        bool check = false;
        for (int i = 0; i < count; i++)
        {
            if (keys[i] == key)
                check = true;
        }
        return check;
    }

    public string GetByKey(string key)
    {
        bool stop = false;
        int pos = 0;
        int i = 0;
        while (!stop &&  i < count)
        {
            if (keys[i] == key)
            {
                pos = i;
                stop = true;
            }
            i++;
        }
        if (!stop)
            throw new Exception();

        return values[pos];
    }
}

public class Prueba
{
    public static void Main()
    {
        SortedListSS sortedList = new SortedListSS();

        sortedList.Add("zzz", "ZZZZZZ");
        sortedList.Add("hola", "hello");
        sortedList.Add("adios", "good bye");
        sortedList.Add("que tal", "how are you");

        Console.WriteLine(sortedList.Contains("hola"));
        Console.WriteLine(sortedList.Contains("xxx"));

        Console.WriteLine("---------------");

        Console.WriteLine(sortedList.GetByKey("adios"));

        Console.WriteLine("---------------");

        for (int i = 0; i < sortedList.Count; i++)
        {
            Console.WriteLine(sortedList.GetKey(i) + " - " + 
                sortedList.GetValue(i));
        }
    }
}
