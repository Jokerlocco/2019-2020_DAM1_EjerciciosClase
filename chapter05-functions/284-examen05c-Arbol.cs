using System;

class Arbol
{
    static void DibujarArboldeNavidad(int altura)
    {
        int simbolos, espacios, anchoTriangulo;
        int alturaCopa = altura - 2;
        int espaciosTronco;
        string tronco;

        if (alturaCopa % 2 == 0)
        {
            anchoTriangulo = 2 * alturaCopa;
            simbolos = 2;
            espacios = (anchoTriangulo / 2) - 1;
            espaciosTronco = espacios;
            tronco = new string(' ', espaciosTronco) + "**";
        }
        else
        {
            anchoTriangulo = 2 * alturaCopa - 1;
            simbolos = 1;
            espacios = anchoTriangulo / 2;
            espaciosTronco = espacios;
            tronco = new string(' ', espaciosTronco) + '*';
        }

        // Copa del árbol (triángulo centrado)
        for (int i = 0; i < alturaCopa; i++)
        {
            string espaciosString = new string(' ', espacios);
            string simbolosString = new string('*', simbolos);
            Console.WriteLine(espaciosString + simbolosString);
            espacios--;
            simbolos += 2;
        }

        // Tronco
        Console.WriteLine(tronco);
        Console.WriteLine(tronco);
    }

    static void Main()
    {
        DibujarArboldeNavidad(17);
        DibujarArboldeNavidad(18);
        DibujarArboldeNavidad(5);
        DibujarArboldeNavidad(6);
    }
}

