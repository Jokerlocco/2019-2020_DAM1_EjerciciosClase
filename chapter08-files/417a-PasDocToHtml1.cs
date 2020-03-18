//Abraham García 

using System;
using System.IO;

class DocumentoEXAGERADAMENTELARGOToHTML
{
    static void Main()
    {
        string path = "pas.txt";

        try
        {
            StreamReader input = File.OpenText(path);
            StreamWriter output = File.CreateText(path + ".html");

            output.WriteLine("<!DOCTYPE html>");
            output.WriteLine("<html lang=\"es\"");
            output.WriteLine("<head>");
            output.WriteLine("<title> Documento largo </title>");
            output.WriteLine("<meta charset=utf-8/>");
            output.WriteLine("</head>");
            output.WriteLine("<body>");

            string line;
            bool endOfParagraph = false;

            do
            {
                line = input.ReadLine();

                if (line != null)
                {
                    if (line.TrimStart().StartsWith("Section"))
                    {
                        line = "<h2>" + line + "</h2>";
                    }
                    else if (!endOfParagraph)
                    {
                        line = "<p>" + line;
                        endOfParagraph = true;
                    }
                    if (input.ReadLine() == "")
                    {
                        line = line + "</p>";
                        endOfParagraph = false;
                    }
                }
                output.WriteLine(line);
            } while (line != null);

            output.WriteLine("</body>");
            output.WriteLine("</html>");

            output.Close();
            input.Close();
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("ERROR: Path Too Long Exception");
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
