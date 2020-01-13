using System;

class Funciones
{
    static char[] ObtenerIniciales(string cadena)
    {
        string[] palabras = cadena.Split();
        int tamanyo = palabras.Length;
        char[] iniciales = new char[tamanyo];
     
        for (int p = 0; p < tamanyo; p++)
        {
            iniciales[p] = palabras[p][0];
        }
        
        return iniciales;
    }

    static void Main()
    {
        string cadena = "Hola, como estás";
        char primeraInicial = ObtenerIniciales(cadena)[0];

        Console.WriteLine(primeraInicial);
    }
}
