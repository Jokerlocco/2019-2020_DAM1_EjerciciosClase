// Don Francisco Jiménez Velasco
using System;
using System.IO;
using System.Collections.Generic;

class ExtractText1
{
    static void Main()
    {
  
        string name;

        Console.Write("File name: ");
        name = Console.ReadLine();
        if (File.Exists(name))
        {
            try
            {
                StreamReader inputFile = File.OpenText(name);
                string line="";
                Queue<string> nonUppercaseSentences = new Queue<string>();
                do
                {
                    line = inputFile.ReadLine();

                    if(line != null)
                    {
                        if(line != line.ToUpper())
                        {
                            nonUppercaseSentences.Enqueue(line);
                        }
                    }
                }
                while (line != null);
                inputFile.Close();
                
                StreamWriter outputFile = File.CreateText(name + ".txt");
                while(nonUppercaseSentences.Count > 0)
                {
                    outputFile.WriteLine(nonUppercaseSentences.Dequeue());
                }
                outputFile.Close();
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path too long");
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }

            catch (IOException)
            {
                Console.WriteLine("I/O error");
            }

            catch (Exception e)
            {
                Console.WriteLine("Error" + e.Message);
            }
            Console.WriteLine("Done.");
        }
    }
}
