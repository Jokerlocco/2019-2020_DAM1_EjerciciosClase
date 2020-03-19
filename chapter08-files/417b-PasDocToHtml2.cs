// Nacho

using System;
using System.Collections.Generic;
using System.IO;

class MysticPascalUserManualToHtml
{
    static void Main()
    {
        string inputName = "pas.txt";
        string outputName = "pas.html";

        try
        {
            List<string> lines = new List<string>(
                File.ReadAllLines(inputName));

            // Let's remove the from feeds (char 12)
            for (int i = 0; i < lines.Count; i++)
            {
                if ((lines[i].Length > 0) && lines[i][0] == 12)
                {
                    lines.RemoveAt(i);
                    i--;
                }
            }

            // Let's remove the left margin
            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].StartsWith("        "))
                {
                    lines[i] = lines[i].Substring(8);
                }
            }

            // Let's remove the page headers and footers
            for (int i = 0; i < lines.Count; i++)
            {
                // Page header
                if ((lines[i].StartsWith("Mystic Pascal  User Manual"))
                    // Footer
                    || ((lines[i].StartsWith("Section ")) 
                        && (i > 0)
                        && (lines[i-1] == "")))
                {
                    lines.RemoveAt(i);
                    i--;
                }
            }

            // Redundant empty lines
            for (int i = 2; i < lines.Count; i++)
            {
                if ((lines[i].Trim() == "")
                    && (lines[i-1].Trim() == "")
                    && (lines[i-2].Trim() == ""))
                {
                    lines.RemoveAt(i);
                    i--;
                }
            }

            // Let's generate the paragraphs
            bool inParagraph = false;
            for (int i = 1; i < lines.Count-1; i++)
            {
                if (inParagraph && (lines[i+1].Trim() == "")) // Next empty?
                {
                    lines[i] = lines[i] + "</p>"; // End of paragraph
                    inParagraph = false;
                }

                else if ((lines[i].Length > 6)  // Long enough?
                    && (lines[i+1].Length > 1) // The next line has contents?
                    && (lines[i].StartsWith("     "))  // Starts with a tab?
                    && (lines[i].ToUpper()[5] >= 'A')  // Next char is alphabetic?
                    && (lines[i].ToUpper()[5] <= 'Z')
                    && (lines[i-1].Trim() == "")  //  Previous line is empty?
                    && (lines[i+1].ToUpper()[0] >= 'A')  // Next line starts with letter?
                    && (lines[i+1].ToUpper()[0] <= 'Z'))
                {
                    lines[i] = "<p>" + lines[i];  // It's a start of a paragraph
                    inParagraph = true;
                }
            }


            // And the tiles
            for (int i = 1; i < lines.Count - 1; i++)
            {
                if ( (i > 227)
                    && (lines[i].Length > 4)
                    && (lines[i][0] != ' ')  // Not starting with space
                    // Dot in second or 3rd position
                    && ((lines[i][1] == '.') || (lines[i][2] == '.'))
                    && (lines[i - 1].Trim() == "")  //  Previous line is empty?
                    && (lines[i + 1].Trim() == ""))  //  Next line is empty?
                {
                    lines[i] = "<h1>" + lines[i]  + "</h1>";
                }
            }


            // The remainder: preformatted
            bool inPreformatted = false;
            for (int i = 1; i < lines.Count - 1; i++)
            {
                if (inPreformatted && (lines[i + 1].Trim() == "")) // Next is empty?
                {
                    lines[i] = lines[i] + "</pre>"; // End of preformatted zone
                    inPreformatted = false;
                }

                else if ((lines[i].Trim() != "")  // Not empty?
                    && (lines[i].StartsWith("  "))   //  Has leading spaces?
                    && (lines[i - 1].Trim() == ""))  //  Previous line is empty?
                {
                    lines[i] = "<pre>" + lines[i];  // It's a start of a preformatted zone
                    if (lines[i + 1].Trim() == "")
                        lines[i] = lines[i] + "</pre>";
                    else
                        inPreformatted = true;
                }
            }


            StreamWriter output = File.CreateText(outputName);

            output.WriteLine("<!DOCTYPE html>");
            output.WriteLine("<html lang=\"es\"");
            output.WriteLine("<head>");
            output.WriteLine("<title>Mystic Pascal User Manual</title>");
            output.WriteLine("<meta charset=utf-8/>");
            output.WriteLine("</head>");
            output.WriteLine("<body>");

            foreach (string line in lines)
            {
                output.WriteLine(line);
            }

            output.WriteLine("</body>");
            output.WriteLine("</html>");

            output.Close();
            Console.WriteLine("Export finished");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("ERROR: Path Too Long");
        }
        catch (IOException)
        {
            Console.WriteLine("I/O ERROR");
        }
        catch (Exception e)
        {
            Console.WriteLine("ERROR: " + e.Message);
        }

    }
}
