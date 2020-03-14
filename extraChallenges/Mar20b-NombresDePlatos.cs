/*

En Villa Healthy son expertos en crear nuevos platos saludables y sabrosos y 
añadirlos a las cartas de sus restaurantes. Lo hacen constantemente y con mucha 
facilidad :)

Pero las cartas de Villa Healthy no solo deben ser saludables sino que deben 
tener nombres molones… y aquí es cuando llega el trabajo duro, el momento de 
poner nombre a un nuevo plato: que si el nombre que quieren ya esta cogido, que 
si no es original, que si no es representativo, que si no mantiene la identidad 
del pueblo…

Una de las señas de identidad de Villa Healthy que hace complicado el elegir 
nombres es que se pide que todos los nombres tengan al menos una palabra 
palíndroma (es decir, aquellas que al revés se escriben igual que al derecho). 
De ahí han salido nombres de platos como “El radar del paladar” (radar) o 
“Sumus de sabor” (sumus).

Para facilitar la tarea de elegir un nombre, nos han pedido que realicemos un 
programa que, dado un conjunto de letras, nos diga cual es el tamaño del mayor 
palíndromo posible que se pueda formar con esas letras.

Cada letra aparecida podrá ser usada como máximo 1 vez. No es obligatorio 
utilizar todas las letras del caso de prueba.

Entrada
- Cada caso de prueba consistirá en una línea con un conjunto de letras mayúsculas
de la A-Z, sin espacios. Cada línea no contendrá más de 1000 caracteres.
- El programa finalizará cuando el caso de prueba leído este formado por la palabra
STOP, palabra que no será procesada.

Salida
- Para cada caso de prueba, se imprimirá una línea indicando el tamaño del mayor
palíndromo posible que se pueda formar con el caso de prueba

Ejemplo de entrada

HOLA
RADAR
ROTO
SOMOS
LOLO
OTTOOTTO
STOP

Ejemplo de salida

1
5
3
5
4
8

*/

// Nacho Cabanes, 14-Mar-2020

using System;

class NombresDePlatos
{
    static void Main()
    {
        string nombre = Console.ReadLine();
        while (nombre != "STOP")
        {
            // Contamos la cantidad de cada letra
            int[] cantidadLetras = new int[30];
            foreach (char letra in nombre)
            {
                byte posicion = (byte) (letra - 'A');
                cantidadLetras[posicion]++;
            }
            
            // Sumamos las repeticiones pares y las impares
            int pares = 0;
            int impares = 0;
            for (int i = 0; i < 30; i++)
            {
                if (cantidadLetras[i] % 2 == 1)
                    impares ++;
                if ((cantidadLetras[i] != 0) && (cantidadLetras[i] % 2 == 0))
                    pares += cantidadLetras[i];
            }
            
            // Y nos sirven las pares y (si la hay) una impar (pero sólo una)
            int respuesta = pares;
            if (impares > 0) 
                respuesta ++;
            Console.WriteLine(respuesta);
            
            // Y tomar el siguiente dato
            nombre = Console.ReadLine();
        }
    }
}
