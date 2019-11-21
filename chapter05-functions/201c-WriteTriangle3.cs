//Ruth Martínez Iborra

using System;

class Triangulos
{
    static void EscribirTriangulo(int alto, char caracter)
    {
        for (int i = 1; i <= alto; i++)
        {
            for (int j = i /* !!!!! */; j <= alto; j++)
            {
                Console.Write(caracter);
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.Write("Dime el alto: ");
        int alto = Convert.ToInt32(Console.ReadLine());

        Console.Write("Dime el carácter: ");
        char caracter = Convert.ToChar(Console.ReadLine());

        EscribirTriangulo(alto, caracter);
    }
}
