//DAVID BERENGUER ANTON

using System;
using System.IO;


namespace Ficheros1
{
    class NoSpacesRedundances
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("should be enter a parameter");
                return;
            }

            string name = args[0];
            string input = File.ReadAllText(name);
            while (input.Contains("  "))
            {
                input = input.Replace("  ", " ");
            }
            input = input.Replace(Environment.NewLine, "¬");

            string[] lines = input.Split('¬');
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = (i + 1) + ". " + lines[i].Trim();
            }
            string output = String.Join(
                Environment.NewLine, 
                lines);
            File.WriteAllText(name + ".nospc.txt", output);

            Console.WriteLine("redundant spaces removed");
        }
    }
}
