using System;
class Encriptador
{
    public string Encriptar(string texto)
    {
        string codigo = "";
        foreach (char c in texto)
        {
            codigo += (char)(c + 1);
        }
        return codigo;
    }

    public string Desencriptar(string codigo)
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
        Encriptador e = new Encriptador();
        string encriptado = e.Encriptar("Hola");
        string desencriptado = e.Desencriptar("Ipmb");
        Console.WriteLine("Palabra encriptada: {0}", encriptado);
        Console.WriteLine("Palabra desencriptada: {0}",desencriptado) ;
    }
}
