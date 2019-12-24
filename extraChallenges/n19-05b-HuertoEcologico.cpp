/*
Acepta 536: Huerto ecológico
Ordenar por 4 criterios

---=====--- 
Nota: esta solución es correcta en cuanto a planteamiento
pero da error MLE (Memory Limit Exceeded) por guardar todos
los datos en memoria
---=====--- 

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

// Pablo Vigara

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
        terrenos ter[nterrenos];
        
        for(int i = 0; i < nterrenos; i++)
        {
            cin >> ter[i].tamanyo >> ter[i].abono >> ter[i].agua >> ter[i].distancia;
            cin.ignore();
            getline(cin, ter[i].nombre);
        }
        
        for (int i = 0; i < nterrenos-1; i++)
        {
            for(int j = i + 1; j < nterrenos; j++)
            {
                if (ter[i].tamanyo < ter[j].tamanyo 
                || (ter[i].tamanyo == ter[j].tamanyo 
                && ter[i].agua > ter[j].agua)
                
                
                || (ter[i].tamanyo == ter[j].tamanyo 
                && ter[i].agua == ter[j].agua
                && ter[i].distancia > ter[j].distancia) 
                
                
                || (ter[i].tamanyo == ter[j].tamanyo 
                && ter[i].agua == ter[j].agua
                && ter[i].distancia == ter[j].distancia
                && ter[i].abono > ter[j].abono))
                {
                    terrenos aux = ter[i];
                    ter[i] = ter[j];
                    ter[j] = aux;
                }
            }
        }
        cout << ter[0].nombre <<endl;
    }
    
    return 0;
}
