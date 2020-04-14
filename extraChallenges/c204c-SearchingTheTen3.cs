/*
Buscando el diez

Te dan todas las notas que has obtenido en una asignatura. Cada notas 
está entre 0 y 10 inclusive.

Suponiendo que en todas tus próximas tareas obtengas un 10, determina 
la cantidad de tareas necesarias para obtener un 10. Recibirás un 10 si 
tu promedio es de 9.5 o superior.

Por ejemplo, si sus calificaciones son 8, 9, entonces requerirá 4 
tareas adicionales en las que tendrá que obtener 10. Con cada tarea, su 
promedio aumentará a 9, 9.25, 9.4 y 9.5.

Entrada

La entrada está en una línea que contiene todas las notas que se han 
obtenido, separadas por una coma.

Salida

Escribe en una línea el número de tareas requeridas para obtener un 10.

Ejemplos de entrada
9,10,10,9
8,9
0,0,0,0,0,0,0,0,0,0,0,0,0
10,10,10,10

Ejemplos de salida
0
4
247
0


El problema que debes resolver:

Para la próxima entrada, escribe un programa que encuentre la respuesta.
7,7,10,10,4,6,4,6,0,6,7,4,6,6,9
La respuesta que debes obtener es:
101

(Primera Olimpiada de Computación Boliviana, Nivel 3, Tipo 1, Problema 1)
*/

// Nacho

using System;

class BuscandoElDiez
{
    static void Main()
    {
        string[] datos = Console.ReadLine().Split(',');
        
        int cantidad = datos.Length;
        double suma = 0;
        foreach(string d in datos) suma += Convert.ToInt32(d);
        
        while( suma / cantidad  < 9.5)
        {
            suma += 10;
            cantidad++;
        }
        Console.WriteLine(cantidad - datos.Length);
    }
}
