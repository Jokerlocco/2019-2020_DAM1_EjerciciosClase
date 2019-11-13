//Pablo Conde
//Calendario Maya

/*
La civilización maya utilizó tres calendarios diferentes. En el 
calendario que se usó durante más tiempo, había 20 días (llamados kin) 
en un uinal, 18 uinales en un tun, 20 tuns en un katun y 20 katuns en 
un baktun. En nuestro calendario, especificamos una fecha con el día, 
el mes y, finalmente, el año. Los mayas especificaron las fechas al 
revés, dando el baktun (1-20), luego katun (1-20), luego tun (1-20), 
luego uinal (1-18) y finalmente el kin (1-20).

La fecha maya 13 20 7 16 3 corresponde a la fecha del 1 de enero de 
2000 (que fue un sábado).

Escriba un programa que, dada una fecha maya (entre 13 20 7 16 3 y 14 1 
15 12 3 inclusive), muestre la fecha correspondiente en nuestro 
calendario. Debes mostrar el mes como número.

Ejemplo de ejecución

13 20 9 2 9
22 3 2001
*/

using System;

class CalendarioMaya
{
    static void Main()
    {
        const int ORIGENTIEMPOS = 13*20*20*18*20 + 20*20*18*20 
            + 7*18*20 + 16*20 + 3;
        int [] factoresMaya = {20, 20, 18, 20};
        int [] meses = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        int [] datos = new int[5];
        
        //Pedimos datos en formato maya
        Console.WriteLine("Introduce una fecha en formato del calendario maya");
        for (int i = 0; i < datos.Length; i++)
        {
            Console.Write("Dime dato " + (i + 1) + ": ");    
            datos[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();
        
        //Convertimos a días
        int diasTotales = 0;
        for (int i = 0; i < datos.Length; i++)
        {
            int producto = datos[i];
            
            for (int j = i; j < factoresMaya.Length; j++)
            {
                producto *= factoresMaya[j];
            }
            diasTotales += producto;
        }
        
        //Días respecto al origen de los tiempos (1 enero 2000) 
        int numDias = diasTotales - ORIGENTIEMPOS;
    
        //Convertimos los días a años, meses y días
        int anyos = numDias / 365;
        //Si hay años bisiestos
        int diasDeBisiestos = anyos / 4;
        anyos = anyos + 2000;
        
        //Días restantes después de obtener los años
        numDias = numDias % 365 - diasDeBisiestos;
        
        int numMes = 0;
        while ( numDias >= 0)
        {
            numDias -= meses[numMes];
            numMes++;
        }
        
        //Días restantes después de obtener los meses
        numDias = meses[numMes-1] + numDias;
        if (numDias == 0)
            numDias++;
        
        Console.WriteLine("En nuestro calendario: " + numDias + "/" 
            + numMes + "/" + anyos);
    }
}
