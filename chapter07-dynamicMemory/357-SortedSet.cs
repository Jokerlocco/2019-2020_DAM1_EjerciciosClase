using System;
using System.Collections.Generic;

class SortedSetExample
{
    static void Main()
    {
        SortedSet<string> set = new SortedSet<string>();

        set.Add("aspdfjapf00");
        set.Add("se me copian");
        set.Add("listo");
        Console.WriteLine( set.Add("se me copian") );

        if(set.Contains("listo"))
        {
            Console.WriteLine("si esta");
        }
    }
}
