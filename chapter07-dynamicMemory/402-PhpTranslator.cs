// Sergio Gumpert

using System;
using System.Collections.Generic;

class Ejercicio
{
    static void Main()
    {
        Dictionary<string, string> cToPhp = new Dictionary<string, string>();
        Dictionary<string, string> phpToJava = new Dictionary<string, string>();

        cToPhp.Add("Console.WriteLine()","echo");
        cToPhp.Add("Console.ReadLine()","readConsole");
        cToPhp.Add("int","$");

        phpToJava.Add("echo", "console.log");
        phpToJava.Add("readConsole", "alert");
        phpToJava.Add("$", "var");

        int option = 7;
        do
        {
            Console.WriteLine("1.Add translation");
            Console.WriteLine("2.Search translation");
            Console.WriteLine("0.Exit");
            option = Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1:
                    int opcion;
                    Console.WriteLine("1. c# To Php");
                    Console.WriteLine("2. php To JavaScript");
                    Console.WriteLine("0. Exit");
                    opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Command in c#?");
                            string csCommand = Console.ReadLine();
                            Console.WriteLine("The translation in php");
                            string phpCommand = Console.ReadLine();
                            cToPhp.Add(csCommand, phpCommand);
                            break;
                        case 2:
                            Console.WriteLine("Command in php?");
                            phpCommand = Console.ReadLine();
                            Console.WriteLine("The translation in JavaScript");
                            string javaCommand = Console.ReadLine();
                            phpToJava.Add(phpCommand, javaCommand);     
                            break;
                        case 0:
                            Console.WriteLine("Operation cancelled");
                            break;
                        default: Console.WriteLine("Not valid");break;
                    }
                    break;
                case 2:
                    int option3;
                    Console.WriteLine("Select traductor");
                    Console.WriteLine("1. C# to PHP");
                    Console.WriteLine("2. PHP to JavaScript");
                    Console.WriteLine("3. C# to JavaScript");
                    Console.WriteLine("0. Exit");
                    option3 = Convert.ToInt32(Console.ReadLine());
                    switch(option3)
                    {
                        case 1:
                            Console.WriteLine("Command in C#?");
                            string csCommand = Console.ReadLine();
                            if (cToPhp.ContainsKey(csCommand))
                                Console.WriteLine(cToPhp[csCommand]);
                            else
                                Console.WriteLine("Not exist");
                            break;
                        case 2:
                            Console.WriteLine("Command in PHP?");
                            string phpCommand = Console.ReadLine();
                            if (phpToJava.ContainsKey(phpCommand))
                                Console.WriteLine(phpToJava[phpCommand]);
                            else
                                Console.WriteLine("Not exist");
                            break;
                        case 3:
                            Console.WriteLine("Command in C#?");
                            csCommand = Console.ReadLine();
                            if (cToPhp.ContainsKey(csCommand))
                                if(phpToJava.ContainsKey(cToPhp[csCommand]))
                                    Console.WriteLine(
                                        phpToJava[cToPhp[csCommand]]);
                                else
                                    Console.WriteLine("Not found");
                            else
                                Console.WriteLine("Not exist");
                            break;
                    }
                    break;
                case 0:
                    Console.WriteLine("Bye.");
                    break;
                default:
                    Console.WriteLine("Option not valid.");
                        break;
                  
            }
        } while (option != 0);
    }
}
