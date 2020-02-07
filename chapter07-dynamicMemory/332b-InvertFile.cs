using System;
using System.Collections.Generic;
using System.IO;

class InvertFile
{

    static void Main(string[] args)
    {
        File.WriteAllLines(
            args[0]+".2", 
            new Stack<string>(
                File.ReadAllLines(
                args[0]))
                .ToArray() );
    }
}
