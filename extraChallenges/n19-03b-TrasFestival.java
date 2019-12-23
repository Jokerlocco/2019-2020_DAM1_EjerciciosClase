/*
Reto Acepta534: Tras el festival
Mayor diferencia entre dos cubos, tras colocarlos para minimizar diferencias

Entrada de ejemplo
4
43 40 41 42
6
22 22 20 25 26 27
0

Salida de ejemplo
1
3
*/

// Pablo Vigara

import java.util.Scanner;
import java.util.Arrays; 

public class e534
{ 
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        int casos;

        do
        {
            casos = sc.nextInt();
            
            if (casos != 0)
            {
                int[] a = new int[casos];
                
                for (int i = 0; i < casos; i++)
                {
                    a[i] = sc.nextInt();
                }
                
                Arrays.sort(a);
                int diferencia = a[1] - a[0];
                
                for (int i = 2; i < casos; i += 2)
                {
                     if ((a[i + 1] - a[i]) > diferencia)
                        diferencia = (a[i + 1] - a[i]);
                }
                System.out.println(diferencia);
            }
        }
        while (casos != 0);
    
    }
}
