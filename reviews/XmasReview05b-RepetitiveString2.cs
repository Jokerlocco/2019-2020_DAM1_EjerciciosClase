//Pablo Conde 

/*Crea una función llamada "CadenaRepetitiva", que reciba como 
parámetros una letra y un número, y devuelva una cadena formada por esa 
letra, repetida tantas veces como indique el número. 
 
Crea una función "CambiarLetra", que reciba una cadena, una letra y una 
posición, y devuelva como resultado la misma cadena, pero en la que se 
haya modificado el carácter que hay en esa posición, para dejar en su 
lugar la letra indicada por el usuario. Por ejemplo, 
CambiarLetra("Hola", 'j', 2) devolvería como resultado "Hoja".

Crea también un programa de prueba, que te permita saber si el 
funcionamiento de esas funciones es correcto. */

using System;

class CadenasTexto
{
    static int Main(string[] args)
    {
        int codeError = 0;
        
        if (args.Length == 0)
            codeError = 1;
        
        else
        {                         
            string opcion = args[0].ToUpper();
            
            switch (opcion)
            {
                case "CADENA":
                    if(args.Length == 3)
                    {   
                        char letra = Convert.ToChar(args[1]);
                        short veces = Convert.ToInt16(args[2]);
                        Console.WriteLine(  
                            CadenaRepetitiva(letra,veces) );
                    }
                    else
                        codeError = 2;
                    break;
                
                case "CAMBIAR":
                    if(args.Length == 4)
                    {   
                        string texto = args[1];
                        char letra = Convert.ToChar(args[2]);
                        short posicion = Convert.ToInt16(args[3]);
                        Console.WriteLine(
                            CambiarLetra(texto, letra, posicion) );
                    }
                    else
                        codeError = 2;
                    break;
                    
                
                default:
                    codeError = 1;
                    break;
            }
        }
        
        return codeError;
    }
    
    static string CadenaRepetitiva(char letra, short veces)
    {
        return new string(letra, veces);
    }
    
    static string CambiarLetra(string texto, char letra, short posicion)
    {
        string nuevoTexto;
        nuevoTexto = texto.Substring(0,posicion) + letra + 
            texto.Substring(posicion + 1);
        
        return nuevoTexto;
    }
}
