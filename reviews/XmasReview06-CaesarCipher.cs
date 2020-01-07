//Pablo Conde 

/*Crea una función llamada "CifrarCesar", que reciba una cadena y 
la devuelva encriptada usando el “cifrado de César”, en el que cada letra del 
alfabeto (y sólo las letras del alfabeto) se reemplaza por la que resulta de 
desplazarse 3 posiciones a la derecha. Por ejemplo, una letra A se reemplazaría 
por una D, una B se reemplazaría por una E y así sucesivamente. Asegúrate de 
que se comporta correctamente con las letras del final del alfabeto (por 
ejemplo, la X se convertirá en A y la Z en C), Crea una función llamada 
"DescifrarCesar", que desencripte una cadena realizando la operación inversa.

Crea también un programa de prueba, que pida una cadena, muestre su equivalente 
cifrado, lo descifre y muestre el resultado, de modo que te permita saber si el 
funcionamiento de esas funciones es correcto.*/

using System;

class Cifrado
{
    static void Main()
    {
        string cadena;
        Console.Write("Dime una cadena para cifrar: ");
        cadena = Console.ReadLine();
        Console.Write("Cadena cifrada: ");
        Console.WriteLine(CifrarCesar(cadena));
        Console.Write("Cadena descifrada: ");
        Console.WriteLine(DescifrarCesar(CifrarCesar(cadena)));
        
    }
    
    static string CifrarCesar(string cadena)
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
    
    static string DescifrarCesar(string cadena)
    {
        string cadenaDescifrada = "";
        
        for (int i = 0; i < cadena.Length; i++)
        {
              if (cadena[i] >= 'd' && cadena[i] <= 'z'
                || cadena[i] >= 'd' && cadena[i] <= 'Z')
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
