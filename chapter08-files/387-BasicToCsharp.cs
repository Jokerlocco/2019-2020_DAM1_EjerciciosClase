/*
Simple BASIC to C# Converter

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
                StreamReader input = File.OpenText(name);
                int posOfExtension = name.LastIndexOf(".bas");
                if (posOfExtension == -1)
                    posOfExtension = name.Length;
                string outputname = name.Substring(0,
                    posOfExtension) + ".cs";
                StreamWriter output = File.CreateText(outputname);

                output.WriteLine("using System;");
                output.WriteLine("class ConvertedFromBasic");
                output.WriteLine("{");
                output.WriteLine("    static void Main()");
                output.WriteLine("    {");

                string line;
                do
                {
                    line = input.ReadLine();
                    if (line != null)
                    {
                        // Let's remove the line number
                        int posOfFirstSpace = line.IndexOf(" ");
                        line = line.Substring(posOfFirstSpace + 1);

                        // Case of "PRINT"
                        if (line.ToUpper().StartsWith("PRINT "))
                        {
                            posOfFirstSpace = line.IndexOf(" ");
                            string textToDisplay = line.Substring(posOfFirstSpace + 1);
                            line = "        Console.WriteLine(" + textToDisplay + ");";
                        }
                        else if (line.ToUpper().StartsWith("INPUT "))
                        {
                            posOfFirstSpace = line.IndexOf(" ");
                            string variable = line.Substring(posOfFirstSpace + 1);
                            line = "        int "+variable+ 
                                " = Convert.ToInt32(Console.ReadLine());";
                        }
                        else
                        {
                            line = "        " + line+";";
                        }
                        output.WriteLine(line);
                    }
                }
                while (line != null);

                output.WriteLine("    }");
                output.WriteLine("}");

                output.Close();
                input.Close();
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
