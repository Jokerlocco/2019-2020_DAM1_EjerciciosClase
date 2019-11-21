using System;

class Triangulos
{
    static void EscribirTriangulo(int alto, char caracter)
    {
        
        for (int i = 1; i <= alto; i++)
        {
            string line = new string(caracter, alto+1-i);
            Console.WriteLine(line);
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
