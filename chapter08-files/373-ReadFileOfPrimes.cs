// Araceli Yáñez Muñoz
using System;
using System.IO;

class ReadPrime
{
    static void Main()
    {
        StreamReader primesFile = File.OpenText("primes.txt");
        Console.WriteLine( primesFile.ReadLine() );
        primesFile.Close();
    }
}
