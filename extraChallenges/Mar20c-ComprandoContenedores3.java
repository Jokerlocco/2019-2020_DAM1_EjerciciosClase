import java.util.Scanner;

public class Programame {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        byte casos = sc.nextByte();
        for (byte i = 0; i < casos; i++) {
            int amarillo = sc.nextInt();
            int marron = sc.nextInt();
            int azul = sc.nextInt();
            int verde = sc.nextInt();
            int negro = sc.nextInt();
            int gris = sc.nextInt();
            byte numResiduos = sc.nextByte();

            byte numAmarillos = 0;
            byte numMarrones = 0;
            byte numAzules = 0;
            byte numNegros = 0;
            byte numVerdes = 0;
            byte numGris = 0;

            int totalResiduos = 0;
            int volAmarillo = 0;
            int volMarron = 0;
            int volAzul = 0;
            int volVerde = 0;
            int volNegro = 0;
            for (byte j = 0; j < numResiduos; j++) {
                totalResiduos += sc.nextInt();
                volAmarillo += sc.nextByte();
                volMarron += sc.nextByte();
                volAzul += sc.nextByte();
                volVerde += sc.nextByte();
                volNegro += sc.nextByte();
            }
            int volGris = totalResiduos - volAmarillo - volMarron - volAzul - volVerde - volNegro;

            numAmarillos += volAmarillo/amarillo;
            if (volAmarillo%amarillo != 0)
                numAmarillos++;

            numMarrones += volMarron/marron;
            if (volMarron%marron != 0)
                numMarrones++;

            numAzules += volAzul/azul;
            if (volAzul%azul != 0)
                numAzules++;

            numVerdes += volVerde/verde;
            if (volVerde%verde != 0)
                numVerdes++;

            numNegros += volNegro/negro;
            if (volNegro%negro != 0)
                numNegros++;

            numGris += volGris/gris;
            if (volGris%gris != 0)
                numGris++;

            System.out.println(numAmarillos + " " + numMarrones + " " + numAzules + " " + numVerdes + " " + numNegros + " " + numGris);
        }
    }
}
