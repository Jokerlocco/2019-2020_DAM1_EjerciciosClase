/*
Acepta 536: Huerto ecológico
Ordenar por 4 criterios

Entrada de ejemplo
2
25 5 10 30 Amapola Grande
20 10 15 40 Rosa Espinosa
3
30 20 25 35 Col & Flor
30 10 30 45 Ramon Omeol Vides
30 15 20 55 Nemesio Labrador

Salida de ejemplo
Amapola Grande
Nemesio Labrador
*/

// Pablo Vigara, retocado por Nacho

#include <iostream>
using namespace std;

struct terrenos
{
    int tamanyo;
    int agua;
    int distancia;
    int abono;
    string nombre;
};

int main()
{
    while(cin)
    {
        int nterrenos;
        cin >> nterrenos;
        terrenos actual, mejor;
        
        // Primer dato como mejor provisional
        cin >> mejor.tamanyo >> mejor.abono >> mejor.agua >> mejor.distancia;
        cin.ignore();
        getline(cin, mejor.nombre);
        
        // Leo los demás y voy comparando
        for(int i = 1; i < nterrenos; i++)
        {
            cin >> actual.tamanyo >> actual.abono >> actual.agua >> actual.distancia;
            cin.ignore();
            getline(cin, actual.nombre);
            
            if (actual.tamanyo > mejor.tamanyo 
                
                || (actual.tamanyo == mejor.tamanyo 
                && actual.agua < mejor.agua)
                
                
                || (actual.tamanyo == mejor.tamanyo 
                && actual.agua == mejor.agua
                && actual.distancia < mejor.distancia) 
                
                
                || (actual.tamanyo == mejor.tamanyo 
                && actual.agua == mejor.agua
                && actual.distancia == mejor.distancia
                && actual.abono < mejor.abono))
            {
                mejor = actual;
            }
        }
        
        if (mejor.nombre.length() > 0)
            cout << mejor.nombre << endl;
    }
    
    return 0;
}
