using System;
using System.Collections.Generic;

class HashtableAndGenerics
{
    static void Main()
    {
        Dictionary<string,string> dic = new Dictionary<string, string>();
        dic.Add("Hola", "Hello");
        dic["Adios"] = "Good bye";
        dic["Hasta luego"] = "See you later";

        Console.WriteLine(dic["Adios"]);
        if (dic.ContainsKey("Hola"))
            Console.WriteLine(dic["Hola"]);
    }
}
