// Abraham García

using System;
using System.IO;

class PascalToCSharpExam
{
    static void Main(string[] args)
    {
        string cSharpFile;
        if (args.Length > 1)
            cSharpFile = args[0];
        else
        {
            Console.Write("Enter Pascal file: ");
            cSharpFile = Console.ReadLine();
        }
        if (!File.Exists(cSharpFile))
        {
            Console.WriteLine("File doesn't exist");
        }
        else
        {
            try
            {
                StreamReader input = File.OpenText(cSharpFile);
                int posExtension = cSharpFile.LastIndexOf(".pas");
                if (posExtension > 0)
                    cSharpFile = cSharpFile.Substring(0, posExtension);
                StreamWriter output = File.CreateText(cSharpFile + ".cs");

                string line;
                bool tab = false; ;
                bool printMain = false;

                output.WriteLine("using System;");
                output.WriteLine();

                do
                {
                    line = input.ReadLine();
                    
                    if (line != null)
                    {
                        line = line.Trim();

                        if (line.ToUpper().StartsWith("PROGRAM "))
                        {
                            line = line.Split()[1];
                            line = line.Substring(0, line.Length - 1);
                            line = "class " + line + " {";
                            printMain = true;
                        }
                        else if (line.ToUpper().StartsWith("WRITELN"))
                        {
                            line = line.Substring(line.IndexOf("('") + 2);
                            line = line.Substring(0, line.Length - 3);
                            line = "Console.WriteLine(\"" + line + "\");";
                            line = "    " + line;
                            if (tab)
                            {
                                line = "    " + line;
                                tab = false;
                            }
                        }
                        else if (line.ToUpper().StartsWith("WRITE"))
                        {
                            line = line.Substring(line.IndexOf("('") + 2);
                            line = line.Substring(0, line.Length - 3);
                            line = "Console.Write(\"" + line + "\");";
                            line = "    " + line;
                            if (tab)
                            {
                                line = "    " + line;
                                tab = false;
                            }
                        }
                        else if (line.ToUpper().StartsWith("READLN"))
                        {
                            line = line.Substring(line.IndexOf("(") + 1);
                            line = line.Substring(0, line.Length - 2);
                            line = line + " = Convert.ToInt32(Console.ReadLine());";
                            line = "    " + line;
                            if (tab)
                            {
                                line = "    " + line;
                                tab = false;
                            }
                        }
                        else if (line.ToUpper().StartsWith("IF"))
                        {
                            line = line.Substring(line.IndexOf("if ") + 3);
                            string lenghtThen = "then";
                            line = line.Substring(
                                0, (line.Length - lenghtThen.Length));
                            line = "if ( " + line + ")";
                            line = "    " + line;
                            tab = true;
                        }
                        else if (line.ToUpper().StartsWith("FOR"))
                        {
                            line = line.Substring(line.IndexOf("for ") + 4);
                            string variable = line.Split()[0];
                            string init = line.Substring(
                                line.IndexOf(":=") + 2).Trim();
                            init = init.Split()[0];
                            string max = line.Substring(line.IndexOf("to ") + 3);
                            max = max.Substring(0, max.Length - 3);
                            line = "for ( " + variable + " = " + init +
                                "; " + variable + " < " + max + "; " +
                                variable + "++ )";
                            line = "    " + line;
                            tab = true;
                        }
                        else if (line.ToUpper().StartsWith("VAR"))
                        {
                            line = "";
                        }
                        else if (line.ToUpper().StartsWith("BEGIN"))
                        {
                            line = "{";
                        }
                        else if (line.ToUpper().StartsWith("END.") ||
                                line.ToUpper().StartsWith("END,") ||
                                line.ToUpper().StartsWith("END"))
                        {
                            line = "    }";
                        }
                        else
                        {
                            line = line.Split(':')[0];
                            line = "int " + line + ";";
                            line = "    " + line;
                        }
                        if (line != "")
                            output.WriteLine(line);
                        if (printMain)
                        {
                            output.WriteLine("  static void Main() {");
                            printMain = false;
                        }
                    }
                } while (line != null);

                output.WriteLine("  }");
                output.WriteLine("}");

                Console.WriteLine("Success!");
                output.Close();
                input.Close();
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("ERROR: Path too long");
            }
            catch (IOException)
            {
                Console.WriteLine("ERROR: IO Exception");
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e);
            }
        }
    }
}
