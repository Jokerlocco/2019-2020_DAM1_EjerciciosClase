//Pablo Conde
//Fibonacci

/*
La sucesión de Fibonacci se define de la forma siguiente: el elemento 0 vale 0 
y el elemento 1 vale 1. Cualquier elemento posterior n+1 es la suma de los que 
le preceden, (el tercer elemento es 0+1=1, el cuarto es 1+1=2, el quinto es 
1+2=3 y así sucesivamente) por lo que se obtiene la secuencia.0, 1, 1, 2, 3, 5, 
8, 13, 21, 34, 55, 89...    Además, esta sucesión tiene muchas propiedades 
curiosas, como por ejemplo que el término n+1 dividido por el término n se 
acerca cada vez más al valor de la "proporción áurea", (1+Raíz(5))/2 = 
1,6180339887...

Deberás crear un programa en C# que pregunte al usuario un número entero n y 
muestre el término n-simo de sucesión de Fibonacci y el resultado de dividir 
ese término entre el anterior. Por ejemplo, si el usuario introduce 8, las 
respuestas serían 21 (que es el término 8) y 1,615384615384615  (que es el 
resultado de dividir 21/13).
*/

using System;

class Fibonacci
{
    static void Main()
    {
        int terms;
        double resultPrev, resultMid, resultPost = 0;
        
        Console.Write("Enter a number of term (n >= 0): ");
        terms = Convert.ToInt32(Console.ReadLine());
        
        if (terms < 0)
            Console.WriteLine("Must be a zero or a positive number");
        
        else
        {
            if (terms == 0)
                Console.WriteLine(0);
            else if (terms == 1)
                Console.WriteLine(1);
            else
            {
                resultPrev = 0.0;
                resultMid = 1.0;
                for (int element = 2; element <= terms; element++)
                {
                    resultPost = resultMid + resultPrev;
                    resultPrev = resultMid;
                    resultMid = resultPost;
                }
                Console.WriteLine("Value of this term: " + resultPost);
                Console.WriteLine("Golden ratio so far: " + 
                    resultPost / resultPrev);
            }
        }
    }
}
