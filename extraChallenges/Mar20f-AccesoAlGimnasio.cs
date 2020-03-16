/*
Además de comer de forma saludable, el ejercicio moderado es un elemento clave para la
tener una buena salud.

Para ello, acudir al gimnasio y seguir un plan de ejercicio supervisado por un especialista,
es clave para conseguir este objetivo.

En Villa Healthy los gimnasios son muy populares. Para el acceso al gimnasio, los socios
tienen una tarjetita con un código QR impreso que pasan por un torno y les permite el
acceso. En principio, ese código QR simplemente proporcionaba el número de socio, pero
algunos “tramposos” se dieron cuenta y generaron códigos QR falsos para poder entrar.
Para mejorar la seguridad, han decidido realizar un pequeña medida e incluir una matriz de
N x M. Nos piden realizar un programa que valide dicha matriz para ver si el código QR es
auténtico o se trata de una falsificación.

Se considerará que dicha matriz es válida si todos los números de sus filas son
estrictamente crecientes y además todos los números de sus columnas son estrictamente
decrecientes.

Entrada

- Un número T indicando el número de casos de prueba. Por cada caso de prueba:
  - Dos números N y M indicando el tamaño de la matriz expresada en N filas y
    M columnas tal que 1 <= N <= 100 y 1 <= M <= 100.
  - N líneas con M elementos X tal que -1000 <= X <= 1000

Salida

- Para cada caso de prueba la cadena VALIDA si la matriz es válida, INVALIDA en
caso contrario.

Ejemplo de entrada
2
3 3
1 2 3
2 3 4
4 5 6
3 3
4 5 6
2 3 4
1 2 3
Ejemplo de salida
INVALIDA
VALIDA
*/

// Nacho Cabanes, 16-Mar-2020

using System;

class AccesoGimnasio
{
    static void Main()
    {
        int casos = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < casos; i++)
        {
            string[] filasCols = Console.ReadLine().Split();
            int filas = Convert.ToInt32(filasCols[0]);
            int cols = Convert.ToInt32(filasCols[1]);

            short[,] matriz = new short[filas, cols];

            for (int f = 0; f < filas; f++)
            {
                string[] detallesFila = Console.ReadLine().Split();
                for (int c = 0; c < cols; c++)
                {
                    matriz[f, c] = Convert.ToInt16(detallesFila[c]);
                }
            }

            bool filasOk = true;
            bool colsOk = true;

            // Comprobamos cada fila
            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < cols - 1; c++)
                {
                    if (matriz[f,c] >= matriz[f, c+1])
                        filasOk = false;
                }
            }

            // Comprobamos cada columna
            if (filasOk)
                for (int f = 0; f < filas - 1; f++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        if (matriz[f,c] <= matriz[f+1,c])
                            colsOk = false;
                    }
                }

            // Y mostramos respuesta
            if (filasOk && colsOk)
                Console.WriteLine("VALIDA");
            else
                Console.WriteLine("INVALIDA");
        }
    }
}
