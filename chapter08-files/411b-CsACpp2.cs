//Abraham García 

using System;
using System.IO;


class CSharpToCPLusPlus
{

    static void Main(string[] args)
    {
        string path;
        if (args.Length >= 1)
            path = args[0];
        else
        {
            Console.WriteLine("Enter path (.cs file, please): ");
            path = Console.ReadLine();
            if (!File.Exists(path))
                Console.WriteLine("File doesn't exist");
            else
            {
                try
                {
                    int extensionPosition = path.LastIndexOf(".cs");
                    string outputPath = path.Remove(extensionPosition) + ".cpp";
                    StreamReader input = new StreamReader(path);
                    StreamWriter output = File.CreateText(outputPath);

                    string line;
                    output.WriteLine("#include <iostream>");

                    do
                    {
                        line = input.ReadLine();
                        if (line != null)
                        {
                            if (line.StartsWith("class") ||
                                line.StartsWith("public class") ||
                                line.StartsWith("using System;"))
                            {
                                line = "";
                            }
                            if (line.Contains("static void Main()"))
                            {
                                line = "int main()    {";
                            }
                            if (line.Contains("Console.WriteLine"))
                            {
                                int firstParenthesis = line.IndexOf("(");
                                line = "cout << " +
                                    line.Substring(firstParenthesis);
                                line = line.Replace("(\"", "\"");
                                line = line.Replace("\");", "\"") + " << endl:";
                            }
                            else if (line.Contains("Console.Write"))
                            {
                                int firstParenthesis = line.IndexOf("(");
                                line = "cout << " +
                                    line.Substring(firstParenthesis);
                                line = line.Replace("(\"", "\"");
                                line = line.Replace("\")", "\"");
                            }
                            else if (line.Contains("Console.ReadLine()"))
                            {
                                string variable = line.Split(" = ")[0];
                                line = "cin >> " + variable.Trim() + ";";
                            }
                        }
                        output.WriteLine(line);
                    } while (line != null);

                    output.Close();
                    input.Close();
                    Console.WriteLine("File converted");

                }
                catch(PathTooLongException)
                {
                    Console.WriteLine("Path too long exception");
                }
                catch (IOException)
                {
                    Console.WriteLine("IOException error!");
                }
                catch(Exception e)
                {
                    Console.WriteLine("Error: " + e);
                }
            }

        }
    }
}
