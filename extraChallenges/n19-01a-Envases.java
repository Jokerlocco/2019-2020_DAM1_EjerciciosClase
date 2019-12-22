// Reto Acepta532: Reduciendo envases
// Peso del envase: Peso total - peso neto

/*
Entrada de ejemplo
2
300 330
150 250
Salida de ejemplo
30
100
*/

//Pablo Miguel Climent Gonzálvez

import java.util.Scanner;

public class reto532
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);

        int c,n,p;

        c = sc.nextInt();

        for (int i=0 ; i<c ; i++)
        {
            n = sc.nextInt();
            
            p = sc.nextInt();
            
            System.out.println(p-n);
        }
    }
}
