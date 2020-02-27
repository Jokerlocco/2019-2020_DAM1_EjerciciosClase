//DAVID BERENGUER ANTON

using System;
using System.Collections.Generic;
using System.IO;


namespace Ficheros1
{
    class pathFather
    {
       static void Main()
        {
            Console.WriteLine("enter the name of file");
            string name = Console.ReadLine();
            if (File.Exists(name)) 
            {
                StreamReader input = File.OpenText(name);
                string line;
                List<string> myList = new List<string>();
                do
                {
                    line = input.ReadLine();
                    if (line != null)
                    {
                        myList.Add(line);
                    }
                }
                while (line != null);
                input.Close();
                myList.Reverse();
                
                StreamWriter output = File.CreateText(name + ".reversed.txt");
                for (int i = 0; i < myList.Count; i++)
                {
                    output.WriteLine(myList[i]);
                }
                output.Close();

                Console.WriteLine("program run success");
            }
            else
            {
                Console.WriteLine("The file is not exits");
            }
            
            
        }
    }
}
