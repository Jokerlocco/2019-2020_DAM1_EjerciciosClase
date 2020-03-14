// Alberto, Kiko, JoseCar
import java.util.Arrays;
import java.util.Scanner;

public class NombresParaPlatos {

    public static void main (String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = "";
        do {
            input = sc.nextLine().toUpperCase();
            if (!input.equals("STOP")){
                int cont = 0;
                char [] inputChar = new char[input.length()];
                for (int i = 0; i < input.length(); i++) {
                    inputChar [i] = input.charAt(i);
                }
                Arrays.sort(inputChar);
                boolean prev = false;
                for (int i = 0; i < inputChar.length-1; i++){
                    if (inputChar[i] == inputChar[i+1] && !prev) {
                        cont ++;
                        prev = true;
                    }
                    else
                        prev = false;
                }

                if (cont*2 == input.length())
                    System.out.println(cont*2);
                else
                    System.out.println(cont*2 + 1);
            }
        } while (!input.equals("STOP"));
    }

}
