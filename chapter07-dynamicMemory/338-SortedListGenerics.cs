using System;
using System.Collections.Generic;

class SortedListAndGenerics
{
    static void Main()
    {
        SortedList<string,string> dic = new SortedList<string, string>();
        dic.Add("Hola", "Hello");
        dic["Adios"] = "Good bye";
        dic["Hasta luego"] = "See you later";

        Console.WriteLine(dic["Adios"]);
        if (dic.ContainsKey("Hola"))
            Console.WriteLine(dic["Hola"]);
    }
}
