//Sergio Gumpert


using System;
using System.Collections.Generic;
using System.IO;



class Prueba
{
    static void Main()
    {

        List<string> list = new List<string>(File.ReadAllLines("t1.txt"));
        list.Sort();

        List<string> listw = new List<string>();
        for (int i = 0; i < list.Count; i++)
        {
            if (!listw.Contains(list[i]))
                listw.Add(list[i]);
        }

        File.WriteAllLines("t2.txt", listw.ToArray());

    }
}
