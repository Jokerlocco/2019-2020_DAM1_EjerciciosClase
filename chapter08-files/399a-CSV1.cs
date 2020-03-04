// CSV, version 1 (simplified: no File.Exists nor try..catch)
// Uses "split" to obtain fragments

/*
Input sample:

"Juan";"López Pérez";"Alicante";25
"Antonio";"Pérez López";"Madrid";27

Output sample:

Juan
López Pérez
Alicante
25

Antonio
Pérez López
Madrid
27

*/

using System;
using System.IO;

public class CSV1
{
    public static void Main(string[] args)
    {
        string fileName = "data.csv";

        StreamReader input = new StreamReader(fileName);
        StreamWriter output = new StreamWriter(fileName + ".txt");

        string line;
        do
        {
            line = input.ReadLine();

            if ( line != null ) 
            {
                string[] parts = line.Split(';');
                for ( int i = 0; i < parts.Length; i++)
                    output.WriteLine( parts[i].Replace("\"","") );
                output.WriteLine( );
            }
        }
        while (line != null);
        input.Close();
        output.Close();
    }
}
