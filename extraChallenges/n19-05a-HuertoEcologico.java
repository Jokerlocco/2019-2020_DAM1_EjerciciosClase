/*
Acepta 536: Huerto ecológico
Ordenar por 4 criterios

Entrada de ejemplo
2
25 5 10 30 Amapola Grande
20 10 15 40 Rosa Espinosa
3
30 20 25 35 Col & Flor
30 10 30 45 Ramon Omeol Vides
30 15 20 55 Nemesio Labrador

Salida de ejemplo
Amapola Grande
Nemesio Labrador
*/

//Pablo Miguel Climent Gonzálvez

import java.util.Scanner;

public class reto536
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);

        int n;
        int[][] matrix,mejor;
        String mejorS,nombre;

        while(sc.hasNextInt())
        {
            n = sc.nextInt();

            matrix = new int[1][4];
            mejor = new int[1][4];
            mejorS = "";

            mejor[0][0] = 0;

            for(int i=0; i<n; i++)
            {
                matrix[0][0] = sc.nextInt();

                matrix[0][1] = sc.nextInt();

                matrix[0][2] = sc.nextInt();

                matrix[0][3] = sc.nextInt();

                nombre = sc.nextLine().trim();

                if(matrix[0][0]>mejor[0][0])
                {
                    mejor[0][0] = matrix[0][0];
                    mejor[0][1] = matrix[0][1];
                    mejor[0][2] = matrix[0][2];
                    mejor[0][3] = matrix[0][3];
                    mejorS = nombre;
                }
                else if(matrix[0][0]==mejor[0][0])
                {
                    if(matrix[0][2]<mejor[0][2])
                    {
                        mejor[0][0] = matrix[0][0];
                        mejor[0][1] = matrix[0][1];
                        mejor[0][2] = matrix[0][2];
                        mejor[0][3] = matrix[0][3];
                        mejorS = nombre;
                    }
                    else if(matrix[0][2]==mejor[0][2])
                    {
                        if(matrix[0][3]<mejor[0][3])
                        {
                            mejor[0][0] = matrix[0][0];
                            mejor[0][1] = matrix[0][1];
                            mejor[0][2] = matrix[0][2];
                            mejor[0][3] = matrix[0][3];
                            mejorS = nombre;
                        }
                        else if(matrix[0][3]==mejor[0][3])
                        {
                            if(matrix[0][1]<mejor[0][1])
                            {
                                mejor[0][0] = matrix[0][0];
                                mejor[0][1] = matrix[0][1];
                                mejor[0][2] = matrix[0][2];
                                mejor[0][3] = matrix[0][3];
                                mejorS = nombre;
                            }
                        }
                    }
                }
            }
            System.out.println(mejorS);
        }
    }
}
