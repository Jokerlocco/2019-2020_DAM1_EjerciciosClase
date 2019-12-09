using System;

class FuncionIniciales
{
    static string Iniciales(string cadena)
    {
        string[] palabras = cadena.Split();
        string iniciales = "";

        for (int p = 0; p < palabras.Length; p++)
        {
            string palabra = palabras[p];
            if (palabra != "") // Por si hay espacios duplicados
                iniciales += palabra[0];
        }
        return iniciales.ToUpper();
    }

    static void Main()
    {
        Console.WriteLine(Iniciales("Primero de Dam"));
    }
}
