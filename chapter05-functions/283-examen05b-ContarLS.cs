using System;

class ContarLS
{
    static void Main()
    {
        int l, s;
        ContarLetrasYSeparadores("Uno-dos,tres", out l, out s);
        Console.WriteLine("Letras: " + l + ", Separadores: " + s);
    }

    static void ContarLetrasYSeparadores(string cadena,
        out int letras, out int separadores)
    {
        letras = 0;
        separadores = 0;

        for (int i = 0; i < cadena.Length; i++)
        {
            if (char.ToLower(cadena[i]) >= 'a' 
                    && char.ToLower(cadena[i]) <= 'z')
                letras++;

            if (cadena[i] == ' ' || cadena[i] == ','
                    || cadena[i] == '.' || cadena[i] == '-'
                    || cadena[i] == '_')
                separadores++;
        }
    }
}
