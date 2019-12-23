/*
Reto Acepta534: Tras el festival
Mayor diferencia entre dos cubos, tras colocarlos para minimizar diferencias

Entrada de ejemplo
4
43 40 41 42
6
22 22 20 25 26 27
0

Salida de ejemplo
1
3
*/

// Nacho

#include <stdio.h>
#include <stdlib.h> /* Para qsort */

int funcionComparacion(const void * a, const void * b)
{
     return ( *(int*)a - *(int*)b );
}

void nSort(int datos[], int cant) 
{
    qsort (datos, cant, sizeof(int), funcionComparacion);
}

int main()
{
    int datos, i;
    
    do
    {
        scanf("%d", &datos);
        
        if (datos > 0)
        {
            int pesos[datos];
            for(i = 0; i < datos; i++)
            {
                scanf("%d", &pesos[i]);
            }
            nSort(pesos, datos);
            
            int diferencia = 0;
            for(i = 0; i < datos-1; i+=2)
            {
                if (pesos[i+1] - pesos[i] > diferencia) 
                    diferencia = pesos[i+1] - pesos[i];
            }
            
            printf("%d\n", diferencia);
        }
    }
    while (datos > 0);
        
    return 0;
}
