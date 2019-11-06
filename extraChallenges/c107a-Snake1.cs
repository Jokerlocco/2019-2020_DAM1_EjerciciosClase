// Avelino Martinez Rodriguez
// Challenge107 - Snake

/*
Ejemplo de entrada

4
3
3
3
4
5
3
9
9
Ejemplo de salida

Caso 1
###
..#
###
Caso 2
####
...#
####
Caso 3
###
..#
###
#..
###
Caso 4
#########
........#
#########
#........
#########
........#
#########
#........
#########
*/

using System;

class Challenge107
{
    static void Main()
    {
        long lineas, columnas, veces;
        bool ladoIzquierdo;
        veces = Convert.ToInt64(Console.ReadLine());
        for (int i = 0; i < veces; i++)
        {
            lineas = Convert.ToInt64(Console.ReadLine());
            columnas = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Caso "+(i+1));
            ladoIzquierdo = false;
            for (int linea = 1; linea <= lineas; linea++)
            {
                if (linea % 2 == 0) // Líneas pares: lateral
                {
                    if (ladoIzquierdo)
                    {
                        Console.Write("#");
                        for (int columna = 0; columna < columnas - 1; columna++)
                            Console.Write(".");
                        ladoIzquierdo = ! ladoIzquierdo;
                    }
                    else
                    {
                        for (int columna = 0; columna < columnas - 1; columna++)
                            Console.Write(".");
                        Console.Write("#");
                        ladoIzquierdo = !ladoIzquierdo;
                    }
                }
                else  // Líneas impares: completo
                {
                    for (int columna = 0; columna < columnas; columna++)
                        Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
