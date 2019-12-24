// Acepta537: Movilidad sostenible
// ¿Se puede alcanzar todos los puntos desde el 1?
// Entrada: Puntos, rutas y detalles de las rutas

/*
Entrada de ejemplo
3 2
1 2
3 2
5 3
4 2
3 5
1 2
Salida de ejemplo
BICI
A PIE
*/
 
//Pablo Miguel Climent Gonzálvez

import java.util.Scanner;

public class reto537
{
    public static void trazar(byte[][] matrix,int p)
    {
        for(int i=0; i<p; i++)
        {
            for(int j=0; j<p; j++)
            {
                if(matrix[i][j]==1)
                {
                    for(int k=0; k<p; k++)
                    {
                        if(matrix[j][k]==1 && i!=k)
                        {
                            matrix[i][k] = 1;
                            matrix[k][i] = 1;
                        }
                        if(matrix[i][k]==1 && j!=k)
                        {
                            matrix[j][k] = 1;
                            matrix[k][j] = 1;
                        }
                    }
                }
            }
        }
    }


    public static boolean trayecto(byte[][] matrix,int p)
    {
        int count;
        for(int i=0; i<p; i++)
        {
            count = 0;
            for(int j=0; j<p; j++)
            {
                if(matrix[i][j]==1)
                    count++;
            }
            if(count==p-1)
                return true;
        }
        return false;
    }
    
    
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);

        byte[][] matrix;
        int input1,input2;
        int p,c;

        while(sc.hasNextLine())
        {
            p = sc.nextInt();

            c = sc.nextInt();

            matrix = new byte[p][p];
            
            for(int i=0; i<c; i++)
            {
                input1 = sc.nextInt()-1;

                input2 = sc.nextInt()-1;

                matrix[input1][input2] = 1;
                matrix[input2][input1] = 1;
            }

            trazar(matrix,p);

            if(trayecto(matrix,p))
                System.out.println("BICI");
            else
                System.out.println("A PIE");

            sc.nextLine();
        }
    }
}
