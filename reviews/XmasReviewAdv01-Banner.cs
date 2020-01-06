//Pablo Conde 
/*Crea un programa en C# que imite la apariencia la de la 
*utilidad "banner" de los UNIX System V, mostrando textos 
* grandes como éste, a partir de una frase que indique 
* el usuario:*/
/*código adaptado de https://www.exercisescsharp.com/2013/04/416-banner.html*/

using System;
public class Banner
{
    static void Main()
    {
        string[] esqueleto =  {  
        "         ###  ### ###  # #   ##### ###   #  ##     ###  ", 
        "         ###  ### ###  # #  #  #  ## #  #  #  #    ###  ", 
        "         ###   #   # ########  #   ### #    ##      #   ", 
        "          #            # #   #####    #    ###     #    ", 
        "                     #######   #  #  # ####   # #       ", 
        "         ###           # #  #  #  # #  # ##    #        ", 
        "         ###           # #   ##### #   ### #### #       ", 
        "   ##    ##                                            #", 
        "  #        #   #   #    #                             # ", 
        " #          #   # #     #                            #  ", 
        " #          # ####### #####   ###   #####           #   ", 
        " #          #   # #     #     ###           ###    #    ", 
        "  #        #   #   #    #      #            ###   #     ", 
        "   ##    ##                   #             ###  #      ", 
        "  ###     #    #####  ##### #      ####### ##### #######", 
        " #   #   ##   #     ##     ##    # #      #     ##    # ", 
        "#     # # #         #      ##    # #      #          #  ", 
        "#     #   #    #####  ##### #    # ###### ######    #   ", 
        "#     #   #   #            ########      ##     #  #    ", 
        " #   #    #   #      #     #     # #     ##     #  #    ", 
        "  ###   ##### ####### #####      #  #####  #####   #    ", 
        " #####  #####    #     ###      #           #     ##### ", 
        "#     ##     #  ###    ###     #             #   #     #", 
        "#     ##     #   #            #     #####     #        #", 
        " #####  ######         ###   #                 #     ## ", 
        "#     #      #   #     ###    #     #####     #     #   ", 
        "#     ##     #  ###     #      #             #          ", 
        " #####  #####    #     #        #           #       #   ", 
        " #####    #   ######  ##### ###### ############## ##### ", 
        "#     #  # #  #     ##     ##     ##      #      #     #", 
        "# ### # #   # #     ##      #     ##      #      #      ", 
        "# # # ##     ####### #      #     ######  #####  #  ####", 
        "# #### ########     ##      #     ##      #      #     #", 
        "#      #     ##     ##     ##     ##      #      #     #", 
        " ##### #     #######  ##### ###### ########       ##### ", 
        "#     #  ###        ##    # #      #     ##     ########", 
        "#     #   #         ##   #  #      ##   ####    ##     #", 
        "#     #   #         ##  #   #      # # # ## #   ##     #", 
        "#######   #         ####    #      #  #  ##  #  ##     #", 
        "#     #   #   #     ##  #   #      #     ##   # ##     #", 
        "#     #   #   #     ##   #  #      #     ##    ###     #", 
        "#     #  ###   ##### #    # ########     ##     ########", 
        "######  ##### ######  ##### ########     ##     ##     #", 
        "#     ##     ##     ##     #   #   #     ##     ##  #  #", 
        "#     ##     ##     ##         #   #     ##     ##  #  #", 
        "###### #     #######  #####    #   #     ##     ##  #  #", 
        "#      #   # ##   #        #   #   #     # #   # #  #  #", 
        "#      #    # #    # #     #   #   #     #  # #  #  #  #", 
        "#       #### ##     # #####    #    #####    #    ## ## ", 
        "#     ##     ######## ##### #       #####    #          ", 
        " #   #  #   #      #  #      #          #   # #         ", 
        "  # #    # #      #   #       #         #  #   #        ", 
        "   #      #      #    #        #        #               ", 
        "  # #     #     #     #         #       #               ", 
        " #   #    #    #      #          #      #               ", 
        "#     #   #   ####### #####       # #####        #######", 
        "  ###                                                   ", 
        "  ###     ##   #####   ####  #####  ###### ######  #### ", 
        "   #     #  #  #    # #    # #    # #      #      #    #", 
        "        ###### #    # #      #    # #      #      #  ###", 
        "    #   #    # #####  #      #    # #####  #####  #     ", 
        "        #    # #    # #    # #    # #      #      #    #", 
        "        #    # #####   ####  #####  ###### #       #### ", 
        "                                                        ", 
        " #    #    #        # #    # #      #    # #    #  #### ", 
        " #    #    #        # #   #  #      ##  ## ##   # #    #", 
        " ######    #        # ####   #      # ## # # #  # #    #", 
        " #    #    #        # #  #   #      #    # #  # # #    #", 
        " #    #    #   #    # #   #  #      #    # #   ## #    #", 
        " #    #    #    ####  #    # ###### #    # #    #  #### ", 
        "                                                        ", 
        " #####   ####  #####   ####   ##### #    # #    # #    #", 
        " #    # #    # #    # #         #   #    # #    # #    #", 
        " #    # #    # #    #  ####     #   #    # #    # #    #", 
        " #####  #  # # #####       #    #   #    # #    # # ## #", 
        " #      #   #  #   #  #    #    #   #    #  #  #  ##  ##", 
        " #       ### # #    #  ####     #    ####    ##   #    #", 
        "                       ###     #     ###   ##    # # # #", 
        " #    #  #   # ###### #        #        # #  #  # # # # ", 
        "  #  #    # #      #  #        #        #     ## # # # #", 
        "   ##      #      #  ##                 ##        # # # ", 
        "   ##      #     #    #        #        #        # # # #", 
        "  #  #     #    #     #        #        #         # # # ", 
        " #    #    #   ######  ###     #     ###         # # # #"
        };

        Console.Write("Escribe el texto del banner:");
        string texto = Console.ReadLine();

        char letra;
        int[] CodigoAscii = new int[texto.Length];

        //Convierto la cadena en enteros 
        for (int i = 0; i < texto.Length; i++)
        {
            letra = Convert.ToChar(texto.Substring(i, 1));
            CodigoAscii[i] = Convert.ToInt32(letra);
        }

        int AnchoLetras = 7,AltoLetra = 7;
        int numeroAscii = 32;
        int countLineas = 0, countLetras = 0,countPosiciones = 0;
        bool LetraEncontrada = false;
        string[] cadena = new string[AltoLetra];

        // Recorro todas las letras
        for (int i = 0; i < CodigoAscii.Length; i++)
        { 
            // Recorro todas las filas del esqueleto de letras
            for (int row = 0; row < esqueleto.Length; row++)
            {
                if (countLetras == 8) //Tenemos 8 letras por fila en esqueleto
                {
                    row += AltoLetra-1;
                    countLetras = 0;
                    countPosiciones = 0;
                }
                //Si no la encuentro, aumento la posicion y el numero ascii 
                while ((!LetraEncontrada) && (countLetras < 8))
                {
                    if (CodigoAscii[i] == numeroAscii)
                        LetraEncontrada = true;
                    else
                    {
                        numeroAscii++;
                        countPosiciones += AnchoLetras;
                        countLetras++;
                    }   
                }
                //Si la he encontrado y no tengo las 7 lineas de la letra
                if ((LetraEncontrada) && (countLineas < 7) )
                {
                    if (i > 0)
                    {
                        cadena[countLineas] = cadena[countLineas] 
                        + esqueleto[row].Substring(countPosiciones, AnchoLetras);
                    }   
                    else
                        cadena[countLineas] = esqueleto[row]
                        .Substring(countPosiciones, AnchoLetras);
                    countLineas++;
                }
            }
            
            countLineas = 0;
            numeroAscii = 32;
            LetraEncontrada = false;
            countPosiciones = 0;
            countLetras = 0;
        }  

        //Muestro
        for (int i = 0; i < cadena.Length; i++)
            Console.WriteLine(cadena[i]); 
    }
}
