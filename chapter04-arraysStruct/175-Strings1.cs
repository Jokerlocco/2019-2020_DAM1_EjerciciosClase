//Abraham García - Manipulación de cadenas

/*
Crea un programa que solicite al usuario una cadena y:

- Lo convierta a mayúsculas (almacenando el resultado en una nueva
  cadena)

- Lo convierta a minúsculas (almacenando el resultado en una nueva
  cadena)

- Elimine la segunda letra y la tercera letra (almacenando el resultado
  en una nueva cadena)

- Inserte "yo" después de la segunda letra (almacenando el resultado en
  una nueva cadena)

- Reemplace todos los espacios por guiones bajos (almacenando el
  resultado en una nueva cadena)

- Elimine los espacios iniciales (almacenando el resultado en otra
  cadena)

- Elimine los espacios finales (almacenando el resultado en otra cadena)

- Reemplace todas las letras A minúsculas por A mayúsculas (almacenando
  el resultado en otra cadena)

- Divida el texto en un array de strings que están separadas por
  espacios y las muestre, cada una en una línea.
*/

using System;

class cadenas
{
    static void Main()
    {
        string cadena;
        string nuevaCadena;

        Console.Write("Di algo: ");
        cadena = Console.ReadLine();

        // Mayúsculas
        nuevaCadena = cadena.ToUpper();
        Console.WriteLine(nuevaCadena);
        Console.WriteLine("---------------------");

        // Minúsculas
        nuevaCadena = cadena.ToLower();
        Console.WriteLine(nuevaCadena);
        Console.WriteLine("---------------------");

        //Eliminar la segunda letra y la tercera letra
        nuevaCadena = cadena.Remove(1,2);
        Console.WriteLine(nuevaCadena);
        Console.WriteLine("---------------------");

        // Insertar "yo" después de la segunda letra
        nuevaCadena = cadena.Insert(2,"yo");
        Console.WriteLine(nuevaCadena);
        Console.WriteLine("---------------------");

        // Reemplazar todos los espacios por guiones bajos
        nuevaCadena = cadena.Replace(" ","_");
        Console.WriteLine(nuevaCadena);
        Console.WriteLine("---------------------");

        // Eliminar los espacios iniciales
        nuevaCadena = cadena.TrimStart();
        Console.WriteLine(nuevaCadena);
        Console.WriteLine("---------------------");

        // Eliminar los espacios finales
        nuevaCadena = cadena.TrimEnd();
        Console.WriteLine(nuevaCadena);
        Console.WriteLine("---------------------");

        // Reemplazar a por A
        nuevaCadena = cadena.Replace("a","A");
        Console.WriteLine(nuevaCadena);
        Console.WriteLine("---------------------");

        // Dividir el texto en un array de strings
        string[] cadenaArray = cadena.Split();
        for (int i = 0; i < cadenaArray.Length; i++)
            Console.WriteLine(cadenaArray[i]);
    }
}
