// Gonzalo Arques

using System;

class FuncionMostrarRecuadroRedondeado
{ 
    static void MostrarRecuadroRedondeado(int ancho, int alto)
    {

        Console.Write("/");
        Console.Write(new string('-', ancho - 2));
        Console.WriteLine("\\");

        for (int fila = 1; fila <= alto - 2; fila++)
        {
            Console.Write("|");
            Console.Write(new string(' ', ancho - 2));
            Console.WriteLine("|");
        }
            
        Console.Write("\\");
        Console.Write(new string('-', ancho - 2));
        Console.WriteLine("/");
    }

    static void MostrarRecuadroRedondeadoAlt(int ancho, int alto)
    {
        Console.Write("/");
        for (int columna = 1; columna <= ancho-2; columna++)
        {
            Console.Write("-");
        }
        Console.WriteLine("\\");

        for (int fila = 1; fila <= alto-2; fila++)
        {
            Console.Write("|");
            for (int columna = 1; columna <= ancho - 2; columna++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("|");
        }

        Console.Write("\\");
        for (int columna = 1; columna <= ancho-2; columna++)
        {
            Console.Write("-");
        }
        Console.WriteLine("/");
    }

    static void Main()
    {
        MostrarRecuadroRedondeado(8, 3);
        Console.WriteLine();
        MostrarRecuadroRedondeadoAlt(8, 3);
    }
}
