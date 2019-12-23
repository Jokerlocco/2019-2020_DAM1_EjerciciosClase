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

//Pablo Miguel Climent Gonzálvez

import java.util.Scanner;

import java.util.Arrays;

public class reto534
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);

        int c,min,x;
        int[] p,dif;

        do
        {
            c = sc.nextInt();
            if(c!=0)
            {
                p = new int[c];
                dif = new int[c/2];
                for(int i=0; i<c; i++)
                {
                    p[i] = sc.nextInt();
                }

                Arrays.sort(p);

                x = 0;
                for(int i=0; i<c/2; i++)
                {
                    dif[i] = p[x+1] - p[x];
                    x+=2;
                }

                Arrays.sort(dif);

                System.out.println(dif[c/2-1]);
            }
        }
        while(c!=0);
    }
}
