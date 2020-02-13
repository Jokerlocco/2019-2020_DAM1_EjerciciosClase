using System;
using System.Collections;

class SortedListAndEnumerator
{
    static void Main()
    {
        SortedList dic = new SortedList();
        dic.Add("Hola", "Hello");
        dic["Adios"] = "Good bye";
        dic["Hasta luego"] = "See you later";
        dic["Tarde"] = "Late";
        dic["Pronto"] = "Soon";
        dic["Ayer"] = "Yesterday";

        IDictionaryEnumerator miEnum = dic.GetEnumerator();

        while (miEnum.MoveNext())
            Console.WriteLine(miEnum.Key + " - " + miEnum.Value);
    }
}
