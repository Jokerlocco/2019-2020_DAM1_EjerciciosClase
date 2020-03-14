// Alberto, Kiko, JoseCar

import java.util.Scanner;

public class ComprandoContenedores {

    public static void main (String[] args)
    {
        Scanner sc = new Scanner(System.in);
        int numeroCasos = sc.nextByte();
        for (int i = 0; i < numeroCasos; i++) {
            int [] volCont = new int[6];
            for (int j = 0; j < volCont.length; j++)
                volCont[j] = sc.nextInt();
            sc.nextLine();
            int numResiduos = sc.nextInt();
            sc.nextLine();
            int [] volRes = new int[6];
            int cont = 0;
            int volTot = 0;
            for (int j = 0; j < numResiduos; j++){

                volTot += sc.nextInt();
                for (int k = 0; k < 5; k++){
                    int o = sc.nextInt();
                    volRes[k] += o;
                    cont += o;
                }

                sc.nextLine();
            }
            volRes[5] += (volTot - cont);
            for (int j = 0; j < 6; j++){
                if (volRes[j] % volCont[j] == 0){
                    if (j == 5)
                        System.out.println(volRes[j] / volCont[j]);
                    else
                        System.out.print("" + volRes[j] / volCont[j] + " ");
                }
                else{
                    if (j == 5)
                        System.out.println("" + (volRes[j] / volCont[j] + 1));
                    else
                        System.out.print("" + (volRes[j] / volCont[j] + 1) + " ");
                }
            }
        }
    }

}
