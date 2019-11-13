// Pablo Vigara Fernández
// "{}"

using System;

class rombo
{
    static void Main ()
    {
        long baktun, katun, tun, winnal, kin;
        long años = 2000, meses = 1, dias = 1;
        
        long [] maya = new long [5];
        
        for (int i = 0; i < 5; i++)
        {
            maya [i] = Convert.ToInt64(Console.ReadLine());
        }
        
        baktun = 20 * 20 * 18 * 20 * ( maya [0] - 13 );
        katun = 20 * 18 * 20 * (maya [1] - 20);
        tun = 18 * 20 * (maya [2] - 7);
        winnal = 20 * (maya [3] - 16);
        kin = (maya [4] - 3);
        
        long totalDias = baktun + katun + tun + winnal + kin;
        
        do
        {
            if (totalDias >= 31)
            {
                totalDias -=31;
                meses++;
            }
            /*if (años % 4 == 0) //Comprobación de bisiesto
            {
                if (totalDias >= 29)
                    {
                        totalDias -= 29;
                        meses++;
                    }
            }
            else*/ if ( totalDias >= 28)
            {
                totalDias -=28;
                meses++;
            }
            if ( totalDias >= 31) //Marzo
            {
                totalDias -= 31;
                meses++;
            }
            if ( totalDias >= 30) //Abril
            {
                totalDias -= 30;
                meses++;
            }
            if ( totalDias >= 31) //Mayo
            {
                totalDias -= 31;
                meses++;
            }
            if ( totalDias >= 30) //Junio
            {
                totalDias -= 30;
                meses++;
            }
            if ( totalDias >= 31) //Julio
            {
                totalDias -= 31;
                meses++;
            }
            if ( totalDias >= 31) //Agosto
            {
                totalDias -= 31;
                meses++;
            }
            if ( totalDias >= 30) //Septiembre
            {
                totalDias -= 30;
                meses++;
            }
            if ( totalDias >= 31) //Octubre
            {
                totalDias -= 31;
                meses++;
            }
            if ( totalDias >= 30) //Noviembre
            {
                totalDias -= 30;
                meses++;
            }
            if ( totalDias >= 31) //Diciembre
            {
                totalDias -= 31;
                meses = 1;
                años++;
            }
        }
        while (totalDias >= 31);
        
        dias = totalDias;
        
        Console.WriteLine("{0}/{1}/{2}", dias, meses, años);
    }
}
