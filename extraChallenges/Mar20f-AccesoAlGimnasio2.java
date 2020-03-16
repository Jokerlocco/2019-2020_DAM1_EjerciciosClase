import java.util.*;
//Team titanic
public class Programa2
{
    public static void main(String [] args)
    {
        Scanner sc = new Scanner(System.in);
        int casos = sc.nextInt();
        int filas = 0;
        int columnas= 0;
        int[][]array = new int[0][0];
            
        for(int i = 0; i < casos; i++)
        {
            filas = sc.nextInt();
            columnas = sc.nextInt();
            
            array = new int[filas][columnas];
            
            for( int f = 0; f < filas ; f++)
            {
                for(int c = 0; c < columnas;c++)
                {
                    array[f][c]= sc.nextInt();
                }
            }

            boolean correctoF=true;
            boolean correctoC=true;

            for( int f = 0; f < filas ; f++)
            {
                for(int c = 0; c < columnas-1;c++)
                {
                    if(array[f][c]>array[f][c+1])
                        correctoC = false;
                }
            }

            for( int f = 0; f < filas-1 ; f++)
            {
                for(int c = 0; c < columnas;c++)
                {
                    if(array[f][c]<array[f+1][c])
                        correctoF = false;
                }
            }

            if(correctoC&&correctoF) System.out.println("VALIDA");

            else System.out.println("INVALIDA");
        }
            
    }
        
        
       
}
