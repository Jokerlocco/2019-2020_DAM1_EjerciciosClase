//Jose Valera

/*
Crea una función "ExtraerVocales", que reciba una cadena y devuelva un array de 
caracteres. Este array contendrá las vocales que había en esa cadena. Por 
ejemplo, para "Hooola" devolvería un array que contendría 'o','o','o', 'a'

Crea una función "ExtraerVocalesNR", que reciba una cadena y devuelva una 
cadena formada por las vocales que contiene, sin repetir, en minúsculas y 
ordenadas alfabéticamente.Por ejemplo, para "Que Tal Estas?" devolvería la 
cadena “aeu”
 
Crea un Main que permita probar ambas (usando "foreach" para mostrar resultados 
en el caso del array de caracteres).
*/

using System;

class Ej07
{
    static char[] ExtraerVocales (string cadena)
    {
        string cadenaMayusculas = cadena.ToUpper();
        string textoVocales = "";
        
        for(int i = 0; i < cadena.Length; i ++)
        {
            if (cadenaMayusculas[i] == 'A' || 
                cadenaMayusculas[i] == 'E' || 
                cadenaMayusculas[i] == 'I' || 
                cadenaMayusculas[i] == 'O' || 
                cadenaMayusculas[i] == 'U')
            {
                textoVocales += cadena[i];
            }
        }
        
        return textoVocales.ToCharArray();
        
    }
    
    static string ExtraerVocalesNR (string cadena)
    {
        string cadenaMinusculas = cadena.ToLower();
        string textoVocales = "";
        bool tieneA = false, tieneE = false, tieneI = false, 
            tieneO = false, tieneU = false;
        
        for(int i = 0; i < cadena.Length; i ++)
        {
            if (cadenaMinusculas[i] == 'a')
            {
                tieneA = true;
            }
            
            if (cadenaMinusculas[i] == 'e')
            {
                tieneE = true;
            }
            
            if (cadenaMinusculas[i] == 'i')
            {
                tieneI = true;
            }
            
            if (cadenaMinusculas[i] == 'o')
            {
                tieneO = true;
            }
            
            if (cadenaMinusculas[i] == 'u')
            {
                tieneU = true;
            }
        }
        
        if (tieneA)
            textoVocales += "a";
        
        if (tieneE)
            textoVocales += "e";
        
        if (tieneI)
            textoVocales += "i";
        
        if (tieneO)
            textoVocales += "o";
        
        if (tieneU)
            textoVocales += "u";
        
        return textoVocales;
        
    }
    
    static void Main()
    {
        char[] vocales = ExtraerVocales ("Hooola");
        
        foreach (char i in vocales)
        {
            Console.Write(i + " ");
        }
        
        Console.WriteLine();
        
        Console.WriteLine(ExtraerVocalesNR ("Que Tal Estas?"));
    }
}
