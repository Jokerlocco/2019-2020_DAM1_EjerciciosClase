// Reto Acepta532: Reduciendo envases
// Peso del envase: Peso total - peso neto

/*
Entrada de ejemplo
2
300 330
150 250
Salida de ejemplo
30
100
*/

// Nacho

#include <stdio.h>

int main()
{
    int casos, pesoNeto, pesoTotal, i;
    scanf("%d", &casos);
    
    for(i = 0; i < casos; i++)
    {
        scanf("%d", &pesoNeto);
        scanf("%d", &pesoTotal);
        printf("%d\n", pesoTotal-pesoNeto);
    }
        
    return 0;
}
