// Joel Martinez Sanchez

using System;
class Encriptador
{
    public static string Encriptar(string texto)
    {
        string codigo = "";
        foreach (char c in texto)
        {
            codigo += (char)(c + 1);
        }
        return codigo;
    }

    public static string Desencriptar(string codigo)
    {
        string texto = "";
        foreach (char c in codigo)
        {
            texto += (char)(c - 1);
        }
        return texto;
    }
}

class EncriptadorCesar : Encriptador
{
    public new static string Encriptar(string cadena)
    {
        string cadenaCifrada = "";

        for (int i = 0; i < cadena.Length; i++)
        {
            if (cadena[i] >= 'a' && cadena[i] <= 'w'
                || cadena[i] >= 'A' && cadena[i] <= 'W')
                cadenaCifrada += Convert.ToChar(cadena[i] + 3);
            else if (cadena[i] >= 'x' && cadena[i] <= 'z'
                || cadena[i] >= 'X' && cadena[i] <= 'Z')
                cadenaCifrada += Convert.ToChar(cadena[i] - 23);

            else
                cadenaCifrada += cadena[i];
        }
        return cadenaCifrada;
    }

    public new static string Desencriptar(string cadena)
    {
        string cadenaDescifrada = "";

        for (int i = 0; i < cadena.Length; i++)
        {
            if (cadena[i] >= 'd' && cadena[i] <= 'z'
              || cadena[i] >= 'D' && cadena[i] <= 'Z')
                cadenaDescifrada += Convert.ToChar(cadena[i] - 3);
            else if (cadena[i] >= 'a' && cadena[i] <= 'c'
                || cadena[i] >= 'A' && cadena[i] <= 'C')
                cadenaDescifrada += Convert.ToChar(cadena[i] + 23);

            else
                cadenaDescifrada += cadena[i];
        }
        return cadenaDescifrada;
    }
}

class PruebaDeEncriptador
{
    static void Main()
    {
        string encriptadoCesar = EncriptadorCesar.Encriptar("Holz");
        string encriptado = Encriptador.Encriptar("Holz");
        string desencriptadoCesar = EncriptadorCesar.Desencriptar("Holz");
        string desencriptado = Encriptador.Desencriptar("Holz");
        Console.WriteLine("Palabra encriptada cesar: {0}", encriptadoCesar);
        Console.WriteLine("Palabra encriptada: {0}", encriptado);
        Console.WriteLine("Palabra desencriptada cesar: {0}", desencriptadoCesar);
        Console.WriteLine("Palabra desencriptada: {0}", desencriptado);
    }
}
