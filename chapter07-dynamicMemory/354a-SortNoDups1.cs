using System;
using System.Collections.Generic;
using System.IO;

class RemoveDuplicatedRows
{
    static void Main()
    {
        string[] fileData = File.ReadAllLines("1.txt");
        List<string> data = new List<string>(fileData);
        
        data.Sort();

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

        File.WriteAllLines("2.txt", data.ToArray());
    }
}
