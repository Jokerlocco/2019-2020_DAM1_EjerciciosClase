/*
Create a program which behaves like the Unix command "more": it must 
display the contents of a text file, and ask the user to press Enter 
each time the screen is full.

As a simple approach, you can display the lines truncated to 79 
characters, and stop after every 20 lines.

The name of the file to file to be displayed will be retrieved from the 
command line.
*/

using System;
using System.IO;

class More
{
    static void Main(string[] args)
    {
        string fileName;
        
        if (args.Length < 1)
        {
            Console.WriteLine("Usage: more fileName ");
        }
        else
        {
            fileName = args[0];
            if (!File.Exists(fileName))
            {
                Console.WriteLine("File does not exist");
            }
            else
            {
                try
                {
                    StreamReader file = File.OpenText(fileName);
                    string line;
                    int count = 0;
                    do
                    {
                        line = file.ReadLine();
                        if (line != null)
                        {
                            if (line.Length > 79)
                                Console.WriteLine(line.Substring(0,79));
                            else
                                Console.WriteLine(line);
                            count++;
                        }

                        if(count == 20)
                        {
                            Console.WriteLine();
                            Console.Write("More...");
                            Console.ReadLine();
                            count = 0;
                        }
                    } 
                    while (line != null);

                    file.Close();
                }
                catch(PathTooLongException)
                {
                    Console.WriteLine("Path too long");
                }
                catch(IOException ex)
                {
                    Console.WriteLine("I/O Error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
