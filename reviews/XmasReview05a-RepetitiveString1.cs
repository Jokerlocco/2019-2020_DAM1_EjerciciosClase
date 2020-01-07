//Francisco Jimenez Velasco

/*Crea una función llamada "CadenaRepetitiva", que reciba como parámetros una 
 * letra y un número, y devuelva una cadena formada por esa letra, repetida 
 * tantas veces como indique el número. Crea una función "CambiarLetra", que 
 * reciba una cadena, una letra y una posición, y devuelva como resultado 
 * la misma cadena, pero en la que se haya modificado el carácter que hay en 
 * esa posición, para dejar en su lugar la letra indicada por el usuario.*/

using System;

class Funciones
{
    static string CadenaRepetitiva(int veces,char letra)
    {
        string letras = new String (letra,veces);
        
        return letras;
    }
    
    
    static string CambiarLetra(string palabra,char letra, int posicion)
    {
        string palabraNueva =palabra.Substring(0,posicion)+
            letra + palabra.Substring(posicion+1);
        return palabraNueva;
    }
    
    
    static void Main()
    {
        string palabra = CadenaRepetitiva(7,'a');
        Console.WriteLine(palabra);
        string palabraNueva=CambiarLetra("Hola",'j',2);
        Console.WriteLine(palabraNueva);        
    }
}
