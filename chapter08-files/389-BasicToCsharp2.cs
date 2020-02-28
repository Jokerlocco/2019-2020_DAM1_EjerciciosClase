/*
Simple BASIC to C# Converter (V2)

10 PRINT "Enter a number"
20 INPUT n1
30 PRINT "Enter another number"
40 INPUT n2
50 PRINT "Their sum is"
60 PRINT n1+n2

100 PRINT "AMOUNT OF PRINTERS? "
200 INPUT PRINTERS
300 PRINT "PRICE = "
400 PRICE = PRINTERS * 60
500 PRINT PRICE

*/

using System;
using System.Collections.Generic;
using System.IO;

public class Bas2cs
{
    public static void Main(string[] args)
    {
        string name;

        if (args.Length < 1)
        {
            Console.Write("Enter file name: ");
            name = Console.ReadLine();
        }
        else
            name = args[0];

        if (!File.Exists(name))
        {
            Console.WriteLine("File not found");
        }
        else
        {
            try
            {
                string[] linesInFile = File.ReadAllLines(name);
                int posOfExtension = name.LastIndexOf(".bas");
                if (posOfExtension == -1)
                    posOfExtension = name.Length;
                string outputname = name.Substring(0,
                    posOfExtension) + ".cs";

                List<string> lines = new List<string>(linesInFile);

                lines.Insert(0, "using System;");
                lines.Insert(1, "class ConvertedFromBasic");
                lines.Insert(2, "{");
                lines.Insert(3, "    static void Main()");
                lines.Insert(4, "    {");

                for (int i = 5; i < lines.Count; i++)
                {
                    string line = lines[i];

                    string[] parts = line.Split();

                    // Case of "PRINT"
                    if (parts[1].ToUpper() == "PRINT")
                    {
                        string textToDisplay = "";
                        for (int p = 2; p < parts.Length; p++)
                        {
                            textToDisplay += parts[p] + " ";
                        }
                        line = "        Console.WriteLine(" + textToDisplay + ");";
                    }
                    else if (parts[1].ToUpper() == "INPUT")
                    {
                        string variable = parts[2];
                        line = "        int " + variable +
                            " = Convert.ToInt32(Console.ReadLine());";
                    }
                    else
                    {
                        string command = "";
                        for (int p = 1; p < parts.Length; p++)
                        {
                            command += parts[p] + " ";
                        }
                        line = "        " + line + ";";
                    }

                    lines[i] = line;                    
                }

                lines.Add("    }");
                lines.Add("}");

                File.WriteAllLines(outputname, lines.ToArray());
                Console.WriteLine("Converted");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path too long");
            }

            catch (IOException)
            {
                Console.WriteLine("I/O error");
            }

            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
