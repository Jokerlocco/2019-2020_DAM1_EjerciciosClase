/*
Reto 3.01 - Tienda de Botas
Primera Olimpiada Boliviana de Informática

Problema - Tienda de Botas

Una tienda de botas ha recibido un embarque de una fábrica. Consiste en 
N botas izquierdas y N botas para el pie derecho. Una bota izquierda 
con otra derecha harán un par si son del mismo tamaño.

Cada bota solo puede pertenecer a un solo par. Los empleados de la 
tienda de botas quiere crear N pares de botas. Afortunadamente la 
fábrica ha prometido cambiar cualquier numero de botas en el embarque 
por nuevas en diferentes tamaños.

Se tiene todas las botas izquierdas y derechas con sus números. Escriba 
un programa que devuelva el mínimo número de botas que deben ser 
intercambiadas.

Input

Los datos de entrada consiste de varias líneas, la primera línea 
contiene el número N de botas izquierdas. Las botas derechas son la 
misma cantidad. La segunda línea contiene N números que representan los 
tamaños de las botas izquierdas. La tercera línea contiene N números 
con los tamaños de las botas derechas.

Output

Escriba en una línea con el mínimo numero de botas a ser intercambiadas.

Ejemplos de entrada

Ejemplo de entrada 1

3
1 3 1
2 1 3

Ejemplo de entrada 2

2
1 3
2 2

Ejemplo de entrada 3

7
1 2 3 4 5 6 7
2 4 6 1 3 7 5

Ejemplos de salida

Salida para el ejemplo 1
1

Salida para el ejemplo 2
2

Salida para el ejemplo 3
0

Problema

Para el dato de entrada siguiente escriba un programa que halle la respuesta.
10
5 2 1 4 7 9 1 1 3 4
2 5 1 3 4 6 3 2 2 5
    
La respuesta que debes entregar es:

5
*/

//Pablo Miguel Climent Gonzálvez

using System;

class TiendaDeBotas3
{
    static void Main()
    {
        int nBotas,contador,posicion=0,nPosDistintos;
        bool encontrado;
        int[] registro;
        string inputTallaI,inputTallaD;
        string[] tallaI,tallaD;

        nBotas = Convert.ToInt32(Console.ReadLine());

        registro = new int[nBotas];

        inputTallaI = Console.ReadLine();
        tallaI = inputTallaI.Split();

        inputTallaD = Console.ReadLine();
        tallaD = inputTallaD.Split();

        for(int i=0 ; i<nBotas ; i++)
        {
            encontrado = false;
            contador = 0;
            while(!encontrado && contador<nBotas)
            {
                if(tallaI[i]==tallaD[contador])
                {
                    nPosDistintos = 0;
                    for(int n=0 ; n<posicion ;n++)
                    {
                        if(registro[n] != contador)
                            nPosDistintos++;
                    }
                    if(nPosDistintos==posicion)
                    {
                        registro[posicion] = contador;
                        posicion++;
                        encontrado = true;
                    }
                }
                contador++;
            }
        }
        Console.WriteLine(nBotas-posicion);
    }
}
