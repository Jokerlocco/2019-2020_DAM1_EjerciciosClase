//Jose Valera 1ºDAM

using System;
using System.Collections;
using System.IO;

class Lines1to1000
{
    static void Main()
    {
        const int MAX = 1000;
        string content = "";
        for (int i = 0; i < MAX; i++)
            content += (i + 1) + "\n";

        File.WriteAllText("1al1000.txt", content);
    }
}
