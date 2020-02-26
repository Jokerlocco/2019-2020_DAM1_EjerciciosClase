//Kiko

using System;
using System.IO;

class LogFile
{
    static void Main()
    {
        StreamWriter file = new StreamWriter("Log.txt", true);
        string sentence;
        do
        {
            Console.Write("Enter a sentence for the log: ");
            sentence = Console.ReadLine();
            if(sentence!="")
            {
                file.WriteLine(sentence);
            }
        } while (sentence != "");
        file.Close();
    }
}
