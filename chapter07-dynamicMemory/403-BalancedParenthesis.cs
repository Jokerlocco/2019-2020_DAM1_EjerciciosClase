// Joel Martinez Sanchez
using System;
using System.Collections.Generic;

public class Parentesis
{
    static void Main()
    {
        Stack<char> c;
        string opcion = "";

        do
        {
            c = new Stack<char>();
            Console.Write("Order? ");
            opcion = Console.ReadLine();

            if (opcion != "")
            {
                try
                {
                    for (int i = 0; i < opcion.Length; i++)
                    {
                        if (opcion[i] == '(')
                        {
                            c.Push(opcion[i]);
                        }
                        else if (opcion[i] == ')')
                        {
                            c.Pop();
                        }
                    }
                    if (c.Count == 0)
                        Console.WriteLine("Expresion balanceada");
                    else
                        Console.WriteLine("Expresion no balanceada");
                        
                } 
                catch (Exception)
                {
                    Console.WriteLine("Expresion no balanceada");
                }
            }
        } while (opcion != "");
        
    }
}
