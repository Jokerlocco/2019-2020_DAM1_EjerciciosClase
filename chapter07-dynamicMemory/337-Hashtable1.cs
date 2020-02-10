using System;
using System.Collections;

class ContactWithHashtable
{
    static void Main()
    {
        Hashtable dic = new Hashtable();
        dic.Add("Hola", "Hello");
        dic["Adios"] = "Good bye";
        dic["Hasta luego"] = "See you later";

        Console.WriteLine(dic["Adios"]);
        if (dic.Contains("Hola"))
            Console.WriteLine(dic["Hola"]);
    }
}
