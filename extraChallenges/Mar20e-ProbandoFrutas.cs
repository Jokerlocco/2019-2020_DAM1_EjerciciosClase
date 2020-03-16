/*

Dos grandes amigos de Villa Healthy han decidido acudir al vecino pueblo de FrutaHermosa
a hacer una degustación de frutas. En ella tienen una fila en la que cada elemento es un
tipo de fruta. Cada tipo de fruta tiene asociado un valor con su grado de “deliciosidad”, que
puede ser positivo, negativo o cero.


Nuestros dos amigos quieren probar algunas de las frutas y saber quién ha obtenido un
mayor grado de satisfacción global al finalizar la degustación. Cada uno solo puede
consumir una unidad de cada tipo de fruta, y para indicar cuáles han consumido, lo
especificarán en rangos.

Estos rangos irán desde 0 hasta N-1 (siendo N la cantidad de tipos distintos de fruta) y se
representarań mediante dos valores (el primero incluido, el segundo excluido).
Por ejemplo, suponemos que tenemos las siguientes frutas, con N=4 -> 10 0 -3 4

Si uno de los amigos ha comido en el rango 0 1 (que incluye la fruta en la posición 0) y en el
rango 2 4 (que incluye las frutas en posiciones 2 y 3) significa que su grado total de
satisfacción es 10 + (-3) + 4, siendo total 11.

Nuestra tarea es realizar un programa que determine cuál de los dos amigos ha obtenido un
mayor grado de satisfacción global, o indique empate en caso de que ambos hayan
conseguido el mismo.

Entrada
- Consistirá en varios juegos de pruebas. La entrada finalizará cuando el número de
tipos de frutas sea cero.

- Para cada caso de prueba
  - Número N indicando el número de distintos tipos de fruta 1 <= N <= 10000. En
    el caso de ser 0, indicará que el programa ha finalizado.
        La siguiente línea contendrá los N valores D de “deliciosidad” de cada
        tipo de fruta, siendo -1000 <= N <= 1000.
  - Número A1 indicando el número de rangos diferentes que degusta el amigo1.
        La siguiente línea contendrá dos números pares de números A y B
        por cada rango indicado en A1, siendo siempre A<B.
  - Número A2 indicando el número de rangos diferentes que degusta el amigo2.
        La siguiente línea contendrá dos números pares de números C y D
        por cada rango indicado en A2, siendo siempre C<D.

Salida
- Para cada caso de prueba se imprimirá una línea con el texto AMIGO1 si el primer
amigo es el que ha conseguido mayor grado de satisfacción global, AMIGO2 si ha
sido el segundo amigo o EMPATE si ambos han conseguir el mismo grado de
satisfacción.

Ejemplo de entrada

4
10 0 -3 4
2
0 1 2 4
2
0 1 3 4
4
10 0 -3 4
1
0 1
1
0 1
5
4 10 0 -3 4
1
0 1
2
3 4 4 5
0

Ejemplo de salida

AMIGO2
EMPATE
AMIGO1

*/

// Nacho Cabanes, 16-Mar-2020

using System;

class ProbandoFrutas
{
    static void Main()
    {
        int frutas;
        do
        {
            frutas = Convert.ToInt32(Console.ReadLine());
            
            if (frutas != 0)
            {
                // Leemos "deliciosidades"
                string[] delicSctring = Console.ReadLine().Split();
                int[] deliciosidad = new int[delicSctring.Length];                
                for (int i = 0; i < delicSctring.Length; i++)
                {
                    deliciosidad[i] = Convert.ToInt32(delicSctring[i]);
                }
                
                // Leemos rangos
                int pares1 = Convert.ToInt32(Console.ReadLine());
                string[] detalles1string = Console.ReadLine().Split();
                
                int pares2 = Convert.ToInt32(Console.ReadLine());
                string[] detalles2string = Console.ReadLine().Split();
                
                // Sumamos los valores en esos rangos
                int total1 = 0;
                for (int i = 0; i < pares1; i++)
                {
                    int limiteInferior = Convert.ToInt32(detalles1string[i*2]);
                    int limiteSuperior = Convert.ToInt32(detalles1string[i*2 + 1]);
                    for (int j = limiteInferior; j < limiteSuperior; j++)
                    {
                        total1 += deliciosidad[j];
                    }
                }
                
                int total2 = 0;
                for (int i = 0; i < pares2; i++)
                {
                    int limiteInferior = Convert.ToInt32(detalles2string[i*2]);
                    int limiteSuperior = Convert.ToInt32(detalles2string[i*2 + 1]);
                    for (int j = limiteInferior; j < limiteSuperior; j++)
                    {
                        total2 += deliciosidad[j];
                    }
                }
                
                // Y comparamos y respondemos
                if (total1 > total2)
                    Console.WriteLine("AMIGO1");
                else if (total1 < total2)
                    Console.WriteLine("AMIGO2");
                else
                    Console.WriteLine("EMPATE");
            }
        }
        while (frutas != 0);
    }
}
