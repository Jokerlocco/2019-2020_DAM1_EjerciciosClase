// Abraham García Ortuño

using System;
using System.IO;

class File1to1000
{
    static void Main()
    {
        string[] data = new string[1000];

        for (int i = 0; i < data.Length; i++)
        {
            data[i] = ("" + (i + 1));
        }

        File.WriteAllLines("1to1000.txt", data);
    }
}

