/*
En Villa Healthy, para estrenar y promocionar su nueva receta estrella de ensalada llamada
“Super-Saladable LOL” están preparando una gran comilona de ensaladas. Para ello han
puesto en fila tanto platos de ensalada normales como platos de ensalada “Super-Saladable
LOL”, todos en fila.

Para facilitar la distribución en las mesas, queremos partir la fila en tantos trozos como
mesas haya de forma que cada trozo de la fila tenga exactamente una ensalada
“Super-Saladable” y 0 o más ensaladas normales.
¿Podrás hacer un programa que nos diga si con una fila de ensaladas dada, la partición
deseada es posible para D mesas?

Entrada
- Una línea indicando con un entero el número de casos de prueba 1 <= T <= 100. Por
cada caso de prueba habrá:
- Una línea indicando el número de ensaladas 1 <= E <= 100 seguido del número
D indicando el número de mesas deseadas.
- Una segunda línea con E ensaladas, indicando con un 0 ensaladas
estándares y con un 1 ensaladas “Super-Saladable LOL”
Salida
- Para cada caso de prueba, se imprimirá POSIBLE si la partición es posible,
IMPOSIBLE en caso contrario.

Ejemplo de entrada

4
3 1
0 1 0
4 2
1 0 1 0
5 4
1 0 1 0 1
3 1
1 0 1

Ejemplo de salida

POSIBLE
POSIBLE
IMPOSIBLE
IMPOSIBLE

*/

// Nacho Cabanes, 14-Mar-2020

using System;

class SupermercadoSaludable
{
    static void Main()
    {
        int casos = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < casos; i++)
        {
            string[] ensaladasPlatos = Console.ReadLine().Split();
            string[] detallesEnsaladas = Console.ReadLine().Split();
            
            int platos = Convert.ToInt32(ensaladasPlatos[1]);
            
            int cantidadEnsaladasSaludables = 0;
            foreach (string e in detallesEnsaladas)
                if (e == "1")
                    cantidadEnsaladasSaludables ++;
            
            if (cantidadEnsaladasSaludables == platos)
                Console.WriteLine("POSIBLE");
            else
                Console.WriteLine("IMPOSIBLE");
        }
    }
}
