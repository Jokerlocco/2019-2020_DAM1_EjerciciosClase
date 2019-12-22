/*
Reto Acepta533: La botella ganadora
Cantidad de botellas de 125 ml para alcanzar n litros

Entrada de ejemplo
4
1
8 10 12 0
2
9 9 0
10
8 8 80 5 5 0
10
1 1 1 1 1 0

Salida de ejemplo
1
2
3
SIGAMOS RECICLANDO
*/

//Pablo Miguel Climent Gonzálvez

import java.util.Scanner;

public class reto533
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);

        int c,n,p,contador;
        double suma;

        c = sc.nextInt();

        for (int i=0 ; i<c ; i++)
        {
            n = sc.nextInt();

            suma = 0;
            contador = 1;

            do
            {
                p = sc.nextInt();

                suma += p*0.125;

                if(suma<n)
                    contador++;
            }
            while(p!=0);

            if(suma>=n)
                System.out.println(contador);
            else
                System.out.println("SIGAMOS RECICLANDO");
        }
    }
}
