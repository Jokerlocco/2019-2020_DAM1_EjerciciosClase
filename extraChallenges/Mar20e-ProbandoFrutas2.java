import java.util.*;

//Team titanic

public class Programa3
{
    public static void main(String [] args)
    {
        Scanner sc = new Scanner(System.in);

         do {
             int casos = sc.nextInt();
             
             if (casos > 0) {
                 int[] array = new int[casos];
                 for (int i = 0; i < casos; i++) {
                     array[i] = sc.nextInt();
                 }

                 int suma1 = 0;
                 int suma2 = 0;

                 int amigo1 = sc.nextInt();
                 for (int i = 0; i < amigo1; i++) {
                     int cola = sc.nextInt();
                     int cabeza = sc.nextInt();

                     for (int j = cola; j < cabeza; j++) {
                         suma1 += array[j];
                     }
                 }

                 int amigo2 = sc.nextInt();
                 for (int i = 0; i < amigo2; i++) {
                     int cola2 = sc.nextInt();
                     int cabeza2 = sc.nextInt();

                     for (int j = cola2; j < cabeza2; j++) {
                         suma2 += array[j];
                     }
                 }

                 if (suma1 > suma2) {
                     System.out.println("AMIGO1");
                 } else if (suma1 < suma2)
                     System.out.println("AMIGO2");

                 else
                     System.out.println("EMPATE");


             }
         }while(casos> 0);
    }
}
