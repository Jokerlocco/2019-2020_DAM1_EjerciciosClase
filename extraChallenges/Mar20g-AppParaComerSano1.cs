/*
En Villa Healthy, se han propuesto crear una pequeña aplicación para comer sano y nos ha
pedido ayuda para este propósito. Antes de ponerla en marcha, nos han pedido hacer un
pequeño prototipo. Este prototipo leerá dos listas, una primera lista con aquellos elementos
que se considere poco saludables por ser ultraprocesados y una segunda lista con aquellos
clasificados como saludables.

Usando esas listas, nuestro prototipo se encargará de comprobar si un alimento es
ultraprocesado, saludable o indicar si no está en la lista. En dicha comprobación no se
tendrán en cuenta mayúsculas o minúsculas.

Entrada

- En la primera línea, un número U indicando el número de elementos de la lista de
ultraprocesados 1 <= U <= 100.
- El las siguientes U líneas, una cadena de texto indicando el nombre del alimento
ultraprocesado. Cada línea nunca poseerá más de 100 caracteres.
- Tras ello, una línea con un número S indicando el número de elementos saludables
tal que 1 <= U <= 100

- El las siguientes W líneas, una cadena de texto indicando el nombre del alimento
saludable. Cada línea nunca poseerá más de 100 caracteres.
- IMPORTANTE: no aparecerán alimentos iguales en ambas listas.
- Finalmente, una línea con un número T indicando el número de casos de prueba.

Por cada caso de prueba habrá una cadena de texto indicando el nombre del
alimento a comprobar

Salida

- Para cada caso de prueba comprobado sin distinguir maýuculas y minúsculas,
indicar si es ULTRAPROCESADO, SALUDABLE o en el caso de que no esté en
ninguna lista, indicar NO ENCONTRADO.

Ejemplo de entrada

3
Patatas fritas
Chuches
Pizza congelada
2
Naranja
Pescado azul
4
PATATAS FRITAS
Pescado
Pescado AZUL
Chuches

Ejemplo de salida

ULTRAPROCESADO
NO ENCONTRADO
SALUDABLE
ULTRAPROCESADO
*/

// Nacho Cabanes, 17-Mar-2020
// V1: Comparando arrays

using System;

class AppComerSano
{
    static void Main()
    {
        // Leemos datos
        int cantidadProcesados = Convert.ToInt32(Console.ReadLine());
        string[] procesados = new string[cantidadProcesados];
        for (int i = 0; i < cantidadProcesados; i++)
            procesados[i] = Console.ReadLine().ToUpper();

        int cantidadSaludables = Convert.ToInt32(Console.ReadLine());
        string[] saludables = new string[cantidadSaludables];
        for (int i = 0; i < cantidadSaludables; i++)
            saludables[i] = Console.ReadLine().ToUpper();

        int cantidadPruebas = Convert.ToInt32(Console.ReadLine());
        string[] pruebas = new string[cantidadPruebas];
        for (int i = 0; i < cantidadPruebas; i++)
            pruebas[i] = Console.ReadLine().ToUpper();

        // Y analizamos para responder
        foreach (string p in pruebas)
        {
            bool esSaludable = false;
            bool esProcesado = false;

            foreach (string s in saludables)
            {
                if (p == s)
                    esSaludable = true;
            }

            if (!esSaludable)
                foreach (string pro in procesados)
                {
                    if (p == pro)
                        esProcesado = true;
                }

            if (esSaludable)
                Console.WriteLine("SALUDABLE");
            else if (esProcesado)
                Console.WriteLine("ULTRAPROCESADO");
            else
                Console.WriteLine("NO ENCONTRADO");
        }
    }
}
