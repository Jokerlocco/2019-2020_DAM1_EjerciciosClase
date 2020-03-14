import java.util.Scanner;

public class NombresDePlatos {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String cadena;
        do{
            cadena = sc.nextLine();
            if (!cadena.equals("STOP")) {
                byte[] letras = new byte[26];
                for (int i = 0; i < cadena.length(); i++) {
                    letras[i] = 0;
                }

                for (int i = 0; i < cadena.length(); i++) {
                    if (cadena.charAt(i) == 'A') {
                        letras[0]++;
                    }
                    if (cadena.charAt(i) == 'B') {
                        letras[1]++;
                    }
                    if (cadena.charAt(i) == 'C') {
                        letras[2]++;
                    }
                    if (cadena.charAt(i) == 'D') {
                        letras[3]++;
                    }
                    if (cadena.charAt(i) == 'E') {
                        letras[4]++;
                    }
                    if (cadena.charAt(i) == 'F') {
                        letras[5]++;
                    }
                    if (cadena.charAt(i) == 'G') {
                        letras[6]++;
                    }
                    if (cadena.charAt(i) == 'H') {
                        letras[7]++;
                    }
                    if (cadena.charAt(i) == 'I') {
                        letras[8]++;
                    }
                    if (cadena.charAt(i) == 'J') {
                        letras[9]++;
                    }
                    if (cadena.charAt(i) == 'K') {
                        letras[10]++;
                    }
                    if (cadena.charAt(i) == 'L') {
                        letras[11]++;
                    }
                    if (cadena.charAt(i) == 'M') {
                        letras[12]++;
                    }
                    if (cadena.charAt(i) == 'N') {
                        letras[13]++;
                    }
                    if (cadena.charAt(i) == 'O') {
                        letras[14]++;
                    }
                    if (cadena.charAt(i) == 'P') {
                        letras[15]++;
                    }
                    if (cadena.charAt(i) == 'Q') {
                        letras[16]++;
                    }
                    if (cadena.charAt(i) == 'R') {
                        letras[17]++;
                    }
                    if (cadena.charAt(i) == 'S') {
                        letras[18]++;
                    }
                    if (cadena.charAt(i) == 'T') {
                        letras[19]++;
                    }
                    if (cadena.charAt(i) == 'U') {
                        letras[20]++;
                    }
                    if (cadena.charAt(i) == 'V') {
                        letras[21]++;
                    }
                    if (cadena.charAt(i) == 'W') {
                        letras[22]++;
                    }
                    if (cadena.charAt(i) == 'X') {
                        letras[23]++;
                    }
                    if (cadena.charAt(i) == 'Y') {
                        letras[24]++;
                    }
                    if (cadena.charAt(i) == 'Z') {
                        letras[25]++;
                    }
                }

                int countFinal = 0;
                boolean uno = false;
                for (int i = 0; i < letras.length; i++) {
                    if (letras[i] > 1) {
                        countFinal += letras[i];
                    }
                    if (!uno && letras[i] == 1) {
                        countFinal++;
                        uno = true;
                    }
                }

                System.out.println(countFinal);
            }
        }while (!cadena.equals("STOP"));
    }
}
