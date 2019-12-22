/*
Reto Acepta533: La botella ganadora
Cantidad de botellas de 125 ml para alcanzar n litros

Entrada de ejemplo
4
1
8 10 12 0
2
9 9 0
10
8 8 80 5 5 0
10
1 1 1 1 1 0

Salida de ejemplo
1
2
3
SIGAMOS RECICLANDO
*/

// Nacho

#include <stdio.h>

int main()
{
    int casos, botellas, actual, total, respuesta, contador, encontrado, i;
    scanf("%d", &casos);
    
    for(i = 0; i < casos; i++)
    {
        scanf("%d", &botellas);
        botellas *= 8;
        total = 0;
        respuesta = 0;
        contador = 0;
        encontrado = 0;
        do
        {
            contador ++;
            scanf("%d", &actual);
            total += actual;
            if ((encontrado == 0) && (total >= botellas))
            {
                encontrado = 1;
                respuesta = contador;
            }
        }
        while (actual != 0);
        
        if (respuesta == 0)
            printf("SIGAMOS RECICLANDO\n");
        else
            printf("%d\n", respuesta);
    }
        
    return 0;
}
