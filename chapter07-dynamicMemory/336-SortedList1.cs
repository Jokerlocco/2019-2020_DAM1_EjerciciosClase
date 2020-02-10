using System;
using System.Collections;

class ContactWithSortedList
{
    static void Main()
    {
        SortedList dic = new SortedList();
        dic.Add("Hola", "Hello");
        dic["Adios"] = "Good bye";
        dic["Hasta luego"] = "See you later";

        Console.WriteLine(dic["Adios"]);
        if (dic.Contains("Hola"))
            Console.WriteLine(dic["Hola"]);
    }
}
