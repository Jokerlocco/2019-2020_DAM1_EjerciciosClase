//Francisco Jimenez Velasco

/*
Challenge 4.01 - Figuritas intocables

Nuestro amigo Maniatiquez tiene una extraña afición. Resulta que tiene un patio 
de baldosas cuadradas de N (Ancho) por M (largo) baldosas. En cada una de esas 
baldosas él puede o no poner una figura decorativa de animales. Pero nuestro 
amigo impone una serie de restricciones para poner dichas figuras. Las figuras 
no pueden estar tocando ninguno de los bordes de su patio. Además, las figuras 
no pueden tener una figura en alguna baldosa contigua en cualquiera de las 8 
direcciones posibles (Vertical, horizontal y diagonal). Tampoco será válida una 
configuración que no tenga ninguna figura.

Nuestra tarea es realizar un programa que indique si una propuesta de 
colocación de figuras es válida para nuestro amigo Maniatiquez.

Entrada

En la primera línea un entero C indicando el número de casos de prueba. Cada 
caso de prueba tendrá una línea que indicará las dimensiones del patio de N por 
M.

1 <= C <= 100
3 <= N <= 15
3 <= M <= 15

En las restantes M lineas, se representará el estado del patio. Cada baldosa 
vacía se representará por una letra X. Cada figura colocada, se representará 
mediante una letra F.

Salida

Por cada juego de prueba, se escribirá VALIDA si la configuración es válida, o 
INVALIDA en caso contrario.

Ejemplo de entrada

5
4 4
XXXX
XXXX
XXXX
XXXX
3 3
XXX
XFX
XXX
3 3
XXX
FXX
XXX
4 3
XXXX
FXFX
XXXX
6 6
XXXXXX
XFXXFX
XXXXXX
XFXFXX
XXXXXX
XXXXXX

Ejemplo de salida
INVALIDA
VALIDA
INVALIDA
INVALIDA
VALIDA

*/

using System;
class figuritas
{

    static void Main()
    {

        int casos = Convert.ToInt32(Console.ReadLine());
        bool contacto = false;
        for (int i = 0; i < casos; i++)
        {
            string[] columnaFila = Console.ReadLine().Split(); // <-----
            int columnas = Convert.ToInt32(columnaFila[0]);
            int filas = Convert.ToInt32(columnaFila[1]);

            char[,] figura = new char[filas, columnas];
            for (int fila = 0; fila < filas; fila++)
            {
                string filaString = Console.ReadLine();
                for (int caracter = 0; caracter < filaString.Length; caracter++)
                {
                    figura[fila, caracter] = Convert.ToChar(filaString[caracter]);
                }

            }

            // Buscamos contactos
            contacto = false;
            for (int fila = 0; fila < filas; fila++)
            {
                for (int columna = 0; columna < columnas; columna++)
                {
                    if (figura[fila, columna] == 'F')
                    {
                        if (fila == 0 ||
                            columna == 0 ||
                            fila == filas - 1 ||
                        columna == columnas - 1)

                        {
                            contacto = true;
                        }

                        else if (figura[fila - 1, columna - 1] == 'F' ||
                        figura[fila - 1, columna] == 'F' ||
                        figura[fila - 1, columna + 1] == 'F' ||
                        figura[fila, columna - 1] == 'F' ||
                        figura[fila, columna + 1] == 'F' ||
                        figura[fila + 1, columna - 1] == 'F' ||
                        figura[fila + 1, columna] == 'F' ||
                        figura[fila + 1, columna + 1] == 'F')
                        {
                            contacto = true;
                        }
                    }
                }

            }

            // Si hasta ahora todo va bien, también hay
            // que comprobar que al menos hay un enanito
            if (! contacto)
            {
                int cantidad = 0;
                for (int fila = 0; fila < filas; fila++)
                {
                    for (int columna = 0; columna < columnas; columna++)
                    {
                        if (figura[fila, columna] == 'F')
                            cantidad++;
                    }
                }
                if (cantidad == 0)
                    contacto = true;
            }
            
            // Y finalmente respondemos
            if (contacto)
                Console.WriteLine("INVALIDA");
            else
                Console.WriteLine("VALIDA");
        }
    }
}
