//Pablo Conde - Buscando el diez
//Primera Olimpiada de Computación Boliviana, Nivel 3, Tipo 1, Problema 1

using System;
using System.Collections.Generic;
using System.Linq;

class BuscandoElDiez
{
    static void Main()
    {
        string datosEntrada = Console.ReadLine();

        string[] arrayNotas = datosEntrada.Split(',');
        List<int> notas = new List<int>();

        for (int i = 0; i < arrayNotas.Length; i++)
            notas.Add(Convert.ToInt32(arrayNotas[i]));
        
        int tareasNecesarias = 0;

        while(notas.Average() < 9.5)
        {
            notas.Add(10);
            tareasNecesarias++;
        }
        Console.WriteLine(tareasNecesarias);
    }
}
