using System;

class Triangulos
{
    static void EscribirTriangulo(int alto, char caracter)
    {
        string line = new string(caracter, alto);
        for (int i = 1; i <= alto; i++)
        {
            Console.WriteLine(line);
            line = line.Substring(0, line.Length-1);
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
