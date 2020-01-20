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
            texto +=(char)(c - 1);
        }
        return texto;
    }
}

class PruebaDeEncriptador
{
    static void Main()
    {
        string encriptado = Encriptador.Encriptar("Hola");
        string desencriptado = Encriptador.Desencriptar("Ipmb");
        Console.WriteLine("Palabra encriptada: {0}", encriptado);
        Console.WriteLine("Palabra desencriptada: {0}",desencriptado) ;
    }
}
