/*
Reto Acepta535: Desembalse
Diferencia con el último dato

Entrada de ejemplo

3
0 1 2
5
8 3 4 2 8
0

Salida de ejemplo
3
15
*/

//Pablo Miguel Climent Gonzálvez

import java.util.Scanner;

public class reto535
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);

        int c;
        int[] p;
        long suma;

        do
        {
            c = sc.nextInt();
            if(c!=0)
            {
                p = new int[c];
                for(int i=0; i<c; i++)
                {
                    p[i] = sc.nextInt();
                }

                suma = 0;
                for(int i=c-2; i>=0; i--)
                {
                    suma += p[c-1] - p[i];
                }

                System.out.println(suma);
            }
        }
        while(c!=0);
    }
}
