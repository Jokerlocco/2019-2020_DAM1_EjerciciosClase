/*

Los habitantes de Villa Healthy, aunque comen saludablemente de forma habitual, saben
que a nadie le amarga un dulce y que de manera moderada puede comerlos.

Eso sí, hay dulces y dulces... y cada uno tiene una serie de características, por lo cual los
habitantes de Villa Healthy quieren ordenar los dulces que conocen según los siguientes
parámetros: en primer lugar su menor contenido de azúcares añadidos, en segundo lugar
su menor contenido en azúcares naturales y por último su mayor grado de apetencia (es
decir, un número que indica cuánto de bueno está :D)

Eso sí, mientras ordenan estos dulces, quieren eliminar aquellos que tengan una cantidad
de azúcares totales (suma de azúcares naturales y añadidos) mayor que un límite de azúcar
dado, por ser extremadamente dañinos para la salud.

Realiza un programa que dado un conjunto de dulces, los ordene según los criterios
establecidos y elimine aquellos con un valor de azúcares totales mayor que el límite de
azúcar especificado.

Entrada

- Una línea con dos números:

  - El número de pasteles a ordenar 2 <= T <= 100000.
  - El nivel de azúcar límite 10 <= AL <= 10000.

- Le seguirán T líneas, cada una formada por 3 enteros:

  - AA, indicando la cantidad de azúcares añadidos.
  - AN, indicando la cantidad de azúcares naturales.
  - AP, indicando el nivel de apetencia de ese dulce

Salida

- Cada línea incluirá un dulce, según el orden indicado y sin mostrar aquellos
  elementos que hayan sobrepasado el límite de azucar.

Ejemplo de entrada

5 100
0 100 22
50 20 3
100 100 2000
20 50 2
50 20 4

Ejemplo de salida

0 100 22
20 50 2
50 20 4
50 20 3

*/

// Nacho Cabanes, 15-Mar-2020

using System;
using System.Collections.Generic;

class Pastel : IComparable<Pastel>
{
    public int AA;
    public int AN;
    public int AP;

    public Pastel(int a, int n, int p)
    {
        AA = a;
        AN = n;
        AP = p;
    }

    public int CompareTo(Pastel otro)
    {
        if (this.AA != otro.AA)
            return this.AA - otro.AA;

        if (this.AN != otro.AN)
            return this.AN - otro.AN;

        return otro.AP - this.AP;
    }
}


class NombresDePlatos
{
    static void Main()
    {
        List<Pastel> pasteles = new List<Pastel>();

        string[] pastelesAzucar = Console.ReadLine().Split();
        int cantidadPasteles = Convert.ToInt32(pastelesAzucar[0]);
        int azucarLimite = Convert.ToInt32(pastelesAzucar[1]);

        for (int i = 0; i < cantidadPasteles; i++)
        {
            string[] detallesPastel = Console.ReadLine().Split();
            int aa = Convert.ToInt32(detallesPastel[0]);
            int an = Convert.ToInt32(detallesPastel[1]);
            int ap = Convert.ToInt32(detallesPastel[2]);
            if (aa + an <= azucarLimite)
            {
                Pastel pastel = new Pastel(aa, an, ap);
                pasteles.Add(pastel);
            }
        }

        pasteles.Sort();
        int p;
        // Console.WriteLine("Respuesta: ");
        for (p = 0; p < pasteles.Count; p++)
        {
            Console.WriteLine(pasteles[p].AA + " " +
                pasteles[p].AN + " " +
                pasteles[p].AP);
        }
    }
}
