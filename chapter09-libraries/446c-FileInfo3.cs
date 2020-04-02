// Abraham García

using System;
using System.IO;
using System.Collections.Generic;

class Directories_446
{
    static void Main()
    {
        DirectoryInfo dir = new DirectoryInfo(".");
        List<FileInfo> files = new List<FileInfo>(dir.GetFiles());

        foreach (FileInfo info in files)
        {
            if (info.Extension == ".java" || info.Extension == ".cs")
            {
                Console.Write(info.Name);
                Console.WriteLine(" (" + info.Length + " KB)");
            }
        }
    }
}
