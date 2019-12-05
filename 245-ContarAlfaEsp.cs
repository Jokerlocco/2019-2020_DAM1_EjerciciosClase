//Sergio Gumpert

using System;

class Ejercio
{


    static void ContarAlfaEsp(out int a, out int e, string texto)
    {
        a = 0;
        e = 0;

        texto = texto.ToUpper();
        for (int i = 0; i < texto.Length; i++)
        {
            if (texto[i] >= 'A' && texto[i] <= 'Z')
                a++;
            else if (texto[i] == ' ')
                e++;
        }

    }


    static void Main()
    {
        int alfa, espacios;

        ContarAlfaEsp(out alfa, out espacios, "Hola, tú!");
        Console.WriteLine("Alfabéticos: " + alfa+ ", Espacios: " + espacios);

    }
}
