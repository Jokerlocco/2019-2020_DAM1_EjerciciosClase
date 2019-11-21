//Joel Martinez

using System;

class triangulo
{
    static void EscribirTriangulo(int ancho, char caracter)
    {
        for (int x = ancho; x > 0; x--)
        {
            for (int i = ancho; i > 0; i--)
            {
                Console.Write(caracter);
            }
            Console.WriteLine();
            ancho--;
        }
    }
    
    static void Main()
    {
        int ancho;
        char caracter;
        
        Console.Write("Introduce el ancho del triangulo: ");
        ancho = Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduce el caracter: ");
        caracter = Convert.ToChar(Console.ReadLine());
        
        EscribirTriangulo(ancho, caracter);
    }
}
