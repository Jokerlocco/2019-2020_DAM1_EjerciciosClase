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

// Pablo Vigara

#include <iostream>

using namespace std;

int main()
{
    int casos, contenido, total, i;
    cin >> casos;
    
    for (i = 0; i < casos; i++)
    {
        cin >> contenido >> total;
        
        cout << (total-contenido) << endl;
    }
    return 0;
}
