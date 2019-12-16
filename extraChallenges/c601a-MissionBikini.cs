//Francisco Jimenez Velasco

/*
Challenge 6.01 - Mission... bikini

Se acerca el verano y comienzan los nervios y desesperación por mantener una línea adecuada. Para ello muchas personas quieren ponerse en forma y se ponen en manos del experto nutricionista Dr Ácula.

El Dr Ácula es un doctor muy solicitado y debe ordenar la lista de pacientes en función de quien tiene que atender antes. Este aconsejará a los pacientes según mayor urgencia tengan. Para ello los ordenará por mayor peso y en caso de empate lo hará según una menor altura.

Entrada

En la primera línea un entero P indicando el número de pacientes.
1 <= C <= 10000
Las siguientes P líneas indicarán de cada paciente el peso w y la altura h.
1 <= h <= 100000
1 <= w <= 100000

Salida

Se nos mostrará los pacientes ordenados de mayor a menor, en base a su peso y 
altura según la urgencia de atención.

Ejemplo de entrada
5
90 150
100 120
100 110
77 170
110 161

Ejemplo de salida
110 161
100 110
100 120
90 150
77 170
*/

using System;
class dieta
{
    struct imc
    {
        public int altura;
        public int peso;
    }
    
    static void Main()
    {
        int casos =0;
        casos = Convert.ToInt32(Console.ReadLine());
        
        imc[]array = new imc[casos];
        
        for(int i = 0; i < casos; i++)
        {
            string caso = Console.ReadLine();
            
            string [] datos = caso.Split(' ');
            
            array[i].peso = Convert.ToInt32(datos[0]);
            array[i].altura = Convert.ToInt32(datos[1]);
        }
        Console.WriteLine();
        for(int i = 0; i < array.Length-1;i++)
        {
            for(int j = i+1; j < array.Length;j++ )
            {
                if(array[j].peso > array[i].peso)
                {
                     imc aux = array[j];
                     array[j]=array[i];
                     array[i]= aux;
                }
                else if(array[j].peso == array[i].peso &&
                    array[j].altura < array[j].altura)
                {
                     imc aux = array[j];
                     array[j]=array[i];
                     array[i]= aux;
                }
            }
        }
        for(int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i].peso+ " "+ array[i].altura);
        }
    }
}
