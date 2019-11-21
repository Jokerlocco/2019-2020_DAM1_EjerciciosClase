//Pablo Conde
//Dibujar triangulo

using System;

class Triangulo
{
    static void Main()
    {
        int lado;
        char simbolo;
        
        Console.Write("Dime lado: ");
        lado = Convert.ToInt32(Console.ReadLine());
        Console.Write("Dime símbolo: ");
        simbolo = Convert.ToChar(Console.ReadLine());
        Console.WriteLine();
        EscribirTriangulo(lado, simbolo);
    }

    static void EscribirTriangulo(int lado, char simbolo)
    {
        int asteriscos = lado;

       for (int i = 0; i < lado ; i++)
       {
           for (int j = 0; j < asteriscos; j++)
           {
               Console.Write(simbolo);
           }
           Console.WriteLine();
           asteriscos--;
       }
    }
}

