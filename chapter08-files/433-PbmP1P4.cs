//kiko, improved by Nacho

using System;
using System.IO;

class PbmP1ToP4
{
    static void Main(string[] args)
    {
        bool debugging = true;

        string path;
        if (args.Length == 0)
        {
            Console.Write("Enter the path:");
            path = Console.ReadLine();
        }
        else
        {
            path = args[0];
        }
        Console.Clear();

        if (File.Exists(path))
        {
            try
            {
                StreamReader input = new StreamReader(path);
                StreamWriter output1 = new StreamWriter(path + "-bin.pbm");

                string line = input.ReadLine();

                if (line != "P1")
                {
                    Console.WriteLine("Not a P1 PBM!");
                    return;
                }

                line = input.ReadLine();
                output1.Write("P4\n");  // File mark
                if (line.StartsWith("#")) // Skip comment
                    line = input.ReadLine();
                output1.Write(line+"\n"); // Size
                output1.Close();

                if (debugging)
                    Console.WriteLine(line);

                FileStream output2 = new FileStream(path + "-bin.pbm", FileMode.Append);

                // Size
                int width = Convert.ToInt32(line.Split(' ')[0]);
                int height = Convert.ToInt32(line.Split(' ')[1]);
                if (width % 8 != 0)
                {
                    Console.WriteLine("Width must be a multiple of 8");
                    return;
                }

                // Data, as a string
                string data = "";
                line = input.ReadLine();
                while (line != null)
                {
                    data += line;
                    line = input.ReadLine();
                }
                input.Close();
                data = data.Replace(" ", "");
                
                // And string to sequence of bytes
                while(data.Length >= 8)
                {
                    if (debugging)
                        Console.WriteLine(data);
                    
                    string currentByte = data.Substring(0, 8);
                    if (debugging)
                        Console.WriteLine(Convert.ToInt32(currentByte, 2) + " ");
                    
                    output2.WriteByte( (byte) Convert.ToInt32(currentByte, 2));
                    data = data.Remove(0, 8);
                }
                output2.Close();
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
        else
        {
            Console.WriteLine("File doesn't exist.");
        }
    }
}
