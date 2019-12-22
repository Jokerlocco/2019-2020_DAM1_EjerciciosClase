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

// Pablo Vigara

#include <iostream>

using namespace std;

int main()
{
    int casos, cantidad, num, contador, actual, total;
    cin >> casos;
    
    for (int i = 0; i < casos; i++)
    {
        cin >> cantidad;
        cantidad *= 1000;
        contador = actual = 0;
        bool end = false;
        
        do
        {
            cin >> num;
            
            if (end!= true)
            {
                actual += num * 125;
                contador++;
                
                if (actual >= cantidad)
                {
                    total = contador;
                    end = true;
                }
            }
            if (num == 0 && actual < cantidad)
                cout << "SIGAMOS RECICLANDO" << endl;
        }
        while (num != 0);
        
        if (end)
            cout << total << endl;
    }
    return 0;
}
