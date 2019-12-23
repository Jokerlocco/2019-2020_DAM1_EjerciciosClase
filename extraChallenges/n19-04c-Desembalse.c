/*
Reto Acepta535: Desembalse
Diferencia con el último dato

Entrada de ejemplo

3
0 1 2
5
8 3 4 2 8
0

Salida de ejemplo
3
15
*/

// Nacho

#include <stdio.h>

int main()
{
    int datos, i;
    int detalles[10001];
    
    do
    {
        scanf("%d", &datos);
        if (datos > 0)
        {
            for (i = 0; i < datos; i++)
            {
                scanf("%d", &detalles[i]);
            }
            
            int total = 0;
            for (i = 0; i < datos-1; i++)
            {
                total += detalles[datos-1] - detalles[i];
            }
            
            printf("%d\n", total);
        }
    }
    while (datos > 0);
        
    return 0;
}
