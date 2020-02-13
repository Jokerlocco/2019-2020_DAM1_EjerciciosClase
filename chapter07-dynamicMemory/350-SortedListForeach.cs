// Pablo Vigara Fernandez

using System;
using System.Collections.Generic;

class SortedListForeach
{
    static void Main()
    {
        Dictionary<string, string> dic = new Dictionary<string, string>();
        dic.Add("Hola", "Hello");
        dic["Adios"] = "Good bye";
        dic["Hasta luego"] = "See you later";
        dic["Tarde"] = "Late";
        dic["Pronto"] = "Soon";
        dic["Ayer"] = "Yesterday";

        foreach (KeyValuePair<string, string> entry in dic)
        {
            Console.WriteLine("{0} --> {1}", entry.Key, entry.Value);
        }
        
        foreach (var entry in dic)
        {
            Console.WriteLine("{0} --> {1}", entry.Key, entry.Value);
        }
    }
}
