// Parking 01

using System;

class Parking01
{
    static void Main()
    {
        ushort entrada, salida;
        int horaEntrada, horaSalida, minutosEntrada, minutosSalida;
        
        while (1 == 1)
        {
        
            Console.Write("Entrada: ");
            string respuesta = Console.ReadLine();
            
            if (respuesta == "fin")
                break;
            
            entrada = Convert.ToUInt16( respuesta );
            Console.Write("Salida: ");
            salida = Convert.ToUInt16( Console.ReadLine() );
            
            horaEntrada = entrada / 100;
            minutosEntrada = entrada % 100;
            horaSalida = salida / 100;
            minutosSalida = salida % 100;
            
            int horas = horaSalida - horaEntrada;
            int minutos = minutosSalida - minutosEntrada;
            
            if (minutos > 0)
                horas++;
            
            Console.Write("Importe: {0}", horas * 2.2);
        }
    }
}
