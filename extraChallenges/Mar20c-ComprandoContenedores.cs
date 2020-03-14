/*

En el pueblo de Villa Healthy organizan comilonas saludables. Intentan ser lo más
sostenibles posibles, pero a pesar de ello se generan residuos y tienen que organizarse
para reciclarlos. El primer paso que se han planteado es comprar los contenedores
necesarios para los vecinos puedan tirar en ellos los desechos. Y para eso requieren tu
ayuda.

Para trabajar el Ayuntamiento te proporciona los siguientes datos:

- Tipos de contenedores:

  - Amarillo -> envases.
  - Marrón -> orgánico.
  - Azul -> cartón y papel.
  - Verde -> vidrio.
  - Negro -> pilas.
  - Gris -> resto.

- Datos sobre los residuos habituales generados tras las comilonas, expresados en
litros, indicando el volumen total del residuo, así como los volúmenes parciales de
materiales de los que hay contenedores. Por ejemplo: un residuo de 110 litros,
contiene 20 litros de cartón, 20 litros de vidrio y 70 litros de plástico.
En aquellos residuos que la suma de litros de los materiales no llegue al total del volumen
se da por hecho que ese resto debe ir al contenedor gris.

Entrada

- Número de casos de prueba 1 <= T <= 100. Por cada caso de prueba:

    - Una línea indicando los volúmenes en litros 1 <= L <= 1000 de cada contenedor
      separados por espacios en el orden: amarillo, marrón, azul, verde, negro,
      gris.

    - Otra línea indicando el número 1 <= N <= 100 de residuos a procesar.

    - Por cada residuo una línea que incluya, separados por espacios:

      - En primer lugar, el volumen total del residuo 1 <= V <= 2000.
      - A continuación los volúmenes de los materiales siguiendo el orden
        amarillo, marrón, azul, verde, negro.

Salida

- Para cada caso de prueba, se imprimirá una línea con 6 enteros indicando el número
mínimo de contenedores necesarios para cada recurso.

Ejemplo de entrada

2
10 10 5 10 20 30
1
100 10 20 0 20 20
10 10 5 10 20 30
2
100 10 20 0 20 20
2 0 0 1 0 0

Ejemplo de salida

1 2 0 2 1 1
1 2 1 2 1 2

*/

// Nacho Cabanes, 15-Mar-2020

using System;

class Contenedores
{
    static void Main()
    {
        int casos = Convert.ToInt32(Console.ReadLine());
        for (int c = 0; c < casos; c++)
        {
            long[] totales = new long[6];
            // Leemos datos
            string[] capacidades = Console.ReadLine().Split();
            int residuos = Convert.ToInt32(Console.ReadLine());
            for (int r = 0; r < residuos; r++)
            {
                string[] detallesResiduos = Console.ReadLine().Split();
                
                // Y calculamos los totales de los 5 colores
                int totalGlobal = 0;
                
                for (int i = 0; i < 5; i++)
                {
                    
                    int contenedorActual = Convert.ToInt32(detallesResiduos[i+1]);
                    totales[i] += contenedorActual;
                    totalGlobal += contenedorActual;
                }
                // Y el total del contenedor gris
                totales[5] += Convert.ToInt32(detallesResiduos[0]) - totalGlobal;
            }
            
            //Console.Write("Respuesta: ");
            int respuesta;
            for (int t = 0; t < 6; t++)
            {
                respuesta = (int) Math.Ceiling( (double) totales[t] / 
                    Convert.ToInt32(capacidades[t]));
                Console.Write(respuesta);
                
                if (t < 5)
                    Console.Write(" ");
                else
                    Console.WriteLine();
            }
        }
    }
}
