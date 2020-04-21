// kiko

// Nota: esta versión es "casi correcta",
// a falta de diagonales y de eliminar
// código repetitivo

/*
Olimpiada Informatica 2017

Problema 3: Sopa de letras (4 puntos)

Dada una matriz de m * n letras y una lista de palabras, realizar un programa 
que encuentre la ubicación en la matriz en la que se puede encontrar cada una 
de las palabras de la lista.

Una palabra debe coincidir con una línea recta e ininterrumpida de letras en la 
matriz. Las letras mayúsculas y minúsculas se consideran equivalentes. Es 
decir, si buscamos sopa, podemos considerar Sopa o sOPa como coincidencias 
válidas. La coincidencia se puede dar en cualquiera de las cuatro direcciones 
horizontales y verticales (las coincidencias diagonales no se deben tener en 
cuenta).

El programa recibirá una entrada con el siguiente formato:

- La primera línea incluirá un par de números enteros m y n, donde m>=i y n<=50

- Las siguientes m líneas contendrán n letras cada una, representando la matriz 
  de letras donde deben buscarse las palabras. Las letras en la matriz pueden 
  estar en mayúsculas o minúsculas

- A continuación de la matriz de letras, aparecerá un número entero k, donde 
  i<=k<=20

- Las siguientes k líneas de entrada contienen la lista de palabras a buscar, 
  una por cada línea. Estas palabras sólo pueden contener letras mayúsculas y 
  minúsculas (sin espacios, guiones u otros caracteres no alfabéticos)

Para cada palabra, el programa generará un par de números enteros que 
representen su ubicación en la matriz. Los números enteros estarán separados 
por un solo espacio:

- El primer entero es la línea de la matriz donde se puede encontrar la primera 
  letra de la palabra dada (1 representa la fila superior de la matriz y m 
  representa la fila inferior)

- El segundo entero es la columna de la matriz donde se puede encontrar la 
  primera letra de la palabra dada (1 representa la columna más a la izquierda 
  de la matriz y n representa la columna más a la derecha)

Si una palabra se puede encontrar más de una vez en la matriz, se debe devolver 
la ubicación de la ocurrencia más alta de la palabra, es decir, aquella que 
sitúa la primera letra de la palabra más cerca de la parte superior izquierda 
de la matriz. Se asumirá que todas las palabras de la lista de entrada se 
encuentran al menos una vez en la matriz.

Ejemplo de funcionamiento

Entrada al programa 
8 11 
abcDEFGhigg 
hEbkWalDorf 
FtaAwaldORm 
FtmimrLqsrc
byBArBeTTYv
Kllbqwikomk
strEBGadhrb
yUiqlxcnBjk 
4
Waldorf
Bambi
Betty
Dagbert

Salida generada por el programa
2 5
2 3
1 2
7 8

*/

using System;

class WordsSoup
{
    static void Main()
    {
        //Chars Read
        string size = Console.ReadLine();
        int rows = Convert.ToInt32(size.Split(' ')[0]);
        int columns = Convert.ToInt32(size.Split(' ')[1]);


        char[,] chars = new char[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            string line = Console.ReadLine().ToUpper();
            for (int j = 0; j < columns; j++)
            {
                chars[i, j] = line[j];
            }
        }

        //Words Read
        int words = Convert.ToInt32(Console.ReadLine());
        string[] palabras = new string[words];
        for (int i = 0; i < words; i++)
        {
            palabras[i] = Console.ReadLine().ToUpper();
        }

        //Checking word by word if its in
        for (int i = 0; i < words; i++)
        {
            {
                int charsToFind = palabras[i].Length;
                int charsFound = 0;
                int c = 0;
                int c2 = 0;
                int aux = 0;
                int aux2 = 0;
                bool found = false;
                while (c < rows && c2 < columns && !found)
                {
                    aux = c;
                    aux2 = c2;
                    //When it finds the first character of the current word
                    if (palabras[i][charsFound] == chars[c, c2])
                    {
                        charsFound++;
                        bool mayHere = true;
                        //If the size is enough to fir in the word it will check character by character
                        if (palabras[i].Length + c2 <= columns)
                        {
                            //Horizontal -> right way
                            while (mayHere)
                            {
                                if (aux2 < columns)
                                    aux2++;

                                if (palabras[i][charsFound] == chars[c, aux2])
                                {
                                    charsFound++;
                                }
                                else
                                {
                                    mayHere = false;
                                    charsFound = 1;
                                    aux2 = c2;
                                }
                                if (charsToFind == charsFound)
                                {
                                    found = true;
                                    mayHere = false;
                                    Console.WriteLine((c + 1) + " " + (c2 + 1));
                                }

                                if (aux2 == columns - 1)
                                {
                                    mayHere = false;
                                    charsFound = 1;
                                    aux2 = c2;
                                }
                            }
                        }

                        mayHere = true;
                        if (c2 - palabras[i].Length >= 0)
                        {
                            //Horizontal <- left way
                            while (!found && mayHere)
                            {
                                if (aux2 > 0)
                                    aux2--;

                                if (palabras[i][charsFound] == chars[c, aux2])
                                {
                                    charsFound++;
                                }
                                else
                                {
                                    mayHere = false;
                                    charsFound = 1;
                                }
                                if (charsToFind == charsFound)
                                {
                                    found = true;
                                    mayHere = false;
                                    Console.WriteLine((c + 1) + " " + (c2 + 1));
                                }

                                if (aux2 == 0)
                                {
                                    mayHere = false;
                                    charsFound = 1;
                                    aux2 = c2;
                                }
                            }
                        }

                        mayHere = true;
                        if (c - palabras[i].Length >= 0)
                        {
                            //Vertical down v
                            while (!found && mayHere)
                            {
                                if (aux > 0)
                                    aux--;

                                if (palabras[i][charsFound] == chars[aux, c2])
                                {
                                    charsFound++;
                                }

                                else
                                {
                                    mayHere = false;
                                    charsFound = 1;
                                    aux = c;
                                }

                                if (charsToFind == charsFound)
                                {
                                    found = true;
                                    mayHere = false;
                                    Console.WriteLine((c + 1) + " " + (c2 + 1));
                                }

                                if (aux == 0)
                                {
                                    mayHere = false;
                                    charsFound = 1;
                                    aux = c;
                                }
                            }
                        }

                        mayHere = true;
                        //Vertical up ^                   
                        while (!found && mayHere)
                        {
                            if (aux < rows-1)
                                aux++;

                            if (palabras[i][charsFound] == chars[aux, c2])
                            {
                                charsFound++;
                            }

                            else
                            {
                                mayHere = false;
                                charsFound = 0;
                            }

                            if (charsToFind == charsFound)
                            {
                                found = true;
                                mayHere = false;
                                Console.WriteLine((c + 1) + " " + (c2 + 1));
                            }

                            if (aux == rows)
                            {
                                mayHere = false;
                                charsFound = 0;
                            }
                        }
                    }

                    if (c2 < columns)
                    {
                        c2++;
                    }
                    if (c2 == columns - 1)
                    {
                        c++;
                        c2 = 0;
                    }
                }

            }
        }

    }
}
