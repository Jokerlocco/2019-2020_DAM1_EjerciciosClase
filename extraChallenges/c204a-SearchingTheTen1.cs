//kiko 
using System;

class Notas
{
    static void Main()
    {
        string notas = Console.ReadLine();        
        int ejerciciosExtra = 0;
        float notaActual;
        string[] notasArray = notas.Split(',');

        do
        {
            int sumaDeNotas = 0;

            for (int i = 0; i < notasArray.Length; i++)
            {
                sumaDeNotas += Convert.ToInt32(notasArray[i]);
            }
            notaActual = sumaDeNotas * 1.0f / notasArray.Length;

            if (notaActual < 9.5)
            {
                notas += ",10";
                ejerciciosExtra ++;
                notasArray = notas.Split(',');
            }
        }
        while (notaActual < 9.5);
        Console.WriteLine(ejerciciosExtra);
    }   
}
