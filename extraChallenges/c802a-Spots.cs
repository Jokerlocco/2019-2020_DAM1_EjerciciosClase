/*

XanDi es el nuevo producto quitamanchas creado por los concursantes de 
ProgramaMe. Todo friki informático sabe que es inevitable mancharse 
mientras se come y se programa a la vez. Y al hacer un concurso de 
programación debe hacerse todo a la vez, ya que el tiempo es muy 
ajustado.

Para ayudar a XanDi, debemos primero saber cuántas manchas hay. Veremos 
una matriz de MxN donde el carácter ‘-’ indicará que un punto no está 
manchado, y ‘#’ indicará que sí lo está.

Cuando varios puntos manchados están en contacto (ya sea en horizontal, 
vertical o diagonal), forman una única mancha. Si esa mancha toca otros 
puntos manchados, esos también forman parte de la misma mancha.

Debemos realizar un programa que cuente el número de manchas 
existentes.

Entrada

En primer lugar, un número MxN indicando el tamaño de la tela.
1 ≤ M ≤ 50
1 ≤ N ≤ 50

Las N siguientes líneas contendrán cada una M caracteres que podrán ser 
‘-’ o ‘#’

Salida

El programa deberá imprimir cuántas manchas diferentes existen.

Ejemplo de entrada
1 1
-

Ejemplo de salida
0

Ejemplo de entrada
5 4
-----
#-#--
---#-
---#-

Ejemplo de salida
2

Ejemplo de entrada
5 4
##-##
##-##
-----
#####

Ejemplo de salida
3
*/

using System;
class Spots
{
    static void Main()
    {
        string[] tamanyo = Console.ReadLine().Split();
        int ancho = Convert.ToInt32(tamanyo[0]);
        int alto = Convert.ToInt32(tamanyo[1]);

        char[,] mapa = new char[ancho, alto];

        // Leemos mapa
        for (int fila = 0; fila < alto; fila++)
        {
            string linea = Console.ReadLine();
            for (int columna = 0; columna < ancho; columna++)
            {
                mapa[columna, fila] = linea[columna];
            }
        }

        // Mostramos mapa
        bool depurando = true;
        if (depurando)
            MostrarMapa(mapa);

        // Recorro todo, borrando y contando
        int manchas = 0;
        for (int fila = 0; fila < alto; fila++)
        {
            for (int columna = 0; columna < ancho; columna++)
            {
                if (mapa[columna, fila] == '#')
                {
                    manchas++;
                    LimpiarMapa(mapa, fila, columna);
                    if (depurando)
                        MostrarMapa(mapa);
                }
            }
        }
        Console.WriteLine(manchas);

    }

    static void MostrarMapa(char[,] m)
    {
        Console.WriteLine();
        int filas = m.GetLength(1);
        int cols = m.GetLength(0);
        for (int fila = 0; fila < filas; fila++)
        {
            for (int col = 0; col < cols; col++)
                Console.Write(m[col, fila]);
            Console.WriteLine();
        }
    }

    static void LimpiarMapa(char[,] m, int filaIni, int colIni)
    {
        // Primero compruebo si esta posición ya está fuera de límites, y corto
        if (filaIni < 0) return;
        if (filaIni > m.GetLength(1) - 1) return;
        if (colIni < 0) return;
        if (colIni > m.GetLength(0) - 1) return;

        // Si es válida, pero no hay mancha en ella, puedo salir
        if (m[colIni, filaIni] != '#') return;

        // Y si hay mancha, la borro y paso a las 4 que la rodean
        m[colIni, filaIni] = '-';
        LimpiarMapa(m, filaIni + 1, colIni);
        LimpiarMapa(m, filaIni, colIni + 1);
        LimpiarMapa(m, filaIni - 1, colIni);
        LimpiarMapa(m, filaIni, colIni - 1);
    }
}
