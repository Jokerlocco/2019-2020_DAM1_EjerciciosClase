//Daniel García

using System;
using System.Collections.Generic;

class Traductor
{
    static void Main()
    {
        Dictionary<string, string> dic = new Dictionary<string, string>();
        dic.Add("hoygan", "perdonen");
        dic.Add("porfabor", "por favor");
        dic.Add("nesecito", "necesito");
        dic.Add("alluda", "ayuda");
        dic.Add("alludar", "ayudar");
        dic.Add("grasias", "gracias");
        dic.Add("ejersisio", "ejercicio");

        Console.Write("Introduce un texto: ");
        string texto = Console.ReadLine();

        string[] palabrasSeparadas = texto.Split(' ');

        for (int i = 0; i < palabrasSeparadas.Length; i++)
        {
            if ( dic.ContainsKey(palabrasSeparadas[i]) )
            {
                Console.Write(dic[palabrasSeparadas[i]] + " ");
            }
            else
            {
                Console.Write(palabrasSeparadas[i] + " ");
            }
        }

        
    }
}
