using System;
using System.Collections.Generic;
using System.IO;

class RemoveDuplicatedRows
{
    static void Main()
    {
        string fileName = "dup.txt";
        List<string> data = new List<string>(
            File.ReadAllLines(fileName) );

        int pos = 1;
        while (pos < data.Count)
        {
            if (data[pos] == data[pos - 1])
            {
                data.RemoveAt(pos);
            }
            else
            {
                pos++;
            }
        }

        File.WriteAllLines(fileName + ".2", data.ToArray());
    }
}
