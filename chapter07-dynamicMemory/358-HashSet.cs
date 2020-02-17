// Joel Martinez

using System;
using System.Collections.Generic;

class HashSetExample
{
    static void Main()
    {
        HashSet<string> set = new HashSet<string>();

        set.Add("perro");
        set.Add("gato");
        set.Add("pato");
        Console.WriteLine( set.Add("gato") );

        Console.WriteLine(set.Contains("gato"));

    }
}
