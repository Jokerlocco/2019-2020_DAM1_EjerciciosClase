//Jose Valera 1ºDAM

using System;
using System.Collections.Generic;
using System.IO;

class ReadWriteData
{
    static void Main()
    {
        string path = "doubles.bin";
        BinaryReader input;
        List<double> doubles = new List<double>();
        long length;
        try
        {
            if (File.Exists(path))
            {
                input = new BinaryReader(
                    File.Open(path, FileMode.Open));
                length = input.BaseStream.Length / 8;
                for(long i = 0; i < length; i++)
                {
                    doubles.Add(input.ReadDouble());
                }
                input.Close();
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }

        byte option;
        do
        {
            Console.WriteLine("OPTIONS");
            Console.WriteLine("1) ADD DOUBLE");
            Console.WriteLine("2) SHOW ALL");
            Console.WriteLine("0) SAVE AND EXIT");
            option = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();

            switch (option)
            {
                case 0: //Save & Exit
                    BinaryWriter output = new BinaryWriter(
                        File.Open(path, FileMode.Create));
                    for (int i = 0; i < doubles.Count; i++)
                        output.Write(doubles[i]);
                    output.Close();
                    Console.WriteLine("Bye! Saved successfully!"); 
                    break;
                case 1: //Add double
                    Console.WriteLine("data nº" + (doubles.Count + 1));
                    doubles.Add(Convert.ToDouble(Console.ReadLine()));
                    break;
                case 2: //Show all
                    if (doubles.Count == 0)
                        Console.WriteLine("(There no have datas)");
                    else
                        for (int i = 0; i < doubles.Count; i++)
                            Console.WriteLine((i + 1) + ") " + 
                                doubles[i]);
                    break;
                default: Console.WriteLine("Incorrect Option"); break;
            }
            Console.WriteLine();
        }
        while (option != 0);
    }
}
