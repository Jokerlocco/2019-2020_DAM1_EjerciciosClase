//DAVID BERENGUER ANTON
using System;
using System.Collections.Generic;
using System.IO;


class DictionaryMultiLanguage
{
    static void Main()
    {
        string[] espIngLineas = File.ReadAllLines("es-en");
        string[] espFranLineas = File.ReadAllLines("es-fr");

        Dictionary<string, string> dicEspIng = 
                    new Dictionary<string, string>();
        Dictionary<string, string> dicEspFra = 
                    new Dictionary<string, string>();

        for (int i = 0; i < espIngLineas.Length; i++)
        {
            string[] palabras = espIngLineas[i].Split("=");
            dicEspIng.Add(palabras[0], palabras[1]);
        }

        for (int i = 0; i < espFranLineas.Length; i++)
        {
            string[] palabras = espFranLineas[i].Split("=");
            dicEspFra.Add(palabras[0], palabras[1]);
        }

        int opcionTraduc;
        do
        {
            Console.WriteLine("1.- español al ingles");
            Console.WriteLine("2.- ingles a español");
            Console.WriteLine("3.- frances a ingles");
            Console.WriteLine("4.- ingles a frances");
            Console.WriteLine("5.- español a frances");
            Console.WriteLine("6.- frances a español");
            Console.WriteLine("Elija una opcion");
            opcionTraduc = Convert.ToInt32(Console.ReadLine());
            if (opcionTraduc < 1 || opcionTraduc > 6)
            {
                Console.WriteLine("opcion incorrecta, vuelva a elegir");
            }
        }
        while (opcionTraduc < 1 || opcionTraduc > 6);

        string traduccion = "[no encontrado]";
        //string traduccion  = "";
        
        //bool encontrado = false;
        switch (opcionTraduc)
        {
            case 1: // espanol a ingles
                TraduccionDirectaDesdeClave(dicEspIng, traduccion);
                break;
            case 2: // ingles a espanol
                TraduccionDirectaDesdeValor(dicEspIng, traduccion);
                break;
            case 3: // frances ingles
                TraduccionClaveClave(dicEspIng, dicEspFra, traduccion);
                break;
            case 4: //ingles frances
                TraduccionClaveClave(dicEspFra, dicEspIng, traduccion);
                break;
            case 5: //espanol a frances
                TraduccionDirectaDesdeClave(dicEspFra, traduccion);
                break;
            case 6: // frances a espanol
                TraduccionDirectaDesdeValor(dicEspFra, traduccion);
                break;
        }
    }

    private static void TraduccionClaveClave(
            Dictionary<string, string> primerDic, 
            Dictionary<string, string> segundoDic, 
            string traduccion)
    {
        string palabra, intermedio;
        do
        {
            Console.Write("¿Palabra? ");
            palabra = Console.ReadLine();
            foreach (KeyValuePair<string, string> pair in primerDic)
            {
                if (pair.Value == palabra)
                {
                    intermedio = pair.Key;
                    if (segundoDic.ContainsKey(intermedio))
                    {
                        traduccion = segundoDic[intermedio];
                    }
                }
            }
            Console.WriteLine("Traduccion: " + traduccion);
        }
        while (palabra != "");
    }

    private static void TraduccionDirectaDesdeValor(
            Dictionary<string, string> dic, string traduccion)
    {
        string palabra;
        do
        {
            Console.Write("¿Palabra? ");
            palabra = Console.ReadLine();
            foreach (KeyValuePair<string, string> pair in dic)
            {
                if (pair.Value == palabra)
                {
                    traduccion = pair.Key;
                    //encontrado = true;
                }
            }
            /*
            if(!encontrado)
            {
                traduccion = "[no encontrado]";
            }
            */
            Console.WriteLine("Traduccion: " + traduccion);
        }
        while (palabra != "");
    }

    private static void TraduccionDirectaDesdeClave(
                Dictionary<string, string> dic, string traduccion)
    {
        string palabra;
        do
        {
            Console.Write("¿Palabra? ");
            palabra = Console.ReadLine();
            if (dic.ContainsKey(palabra))
            {
                traduccion = dic[palabra];
            }
            /*
            else
            {
                traduccion = "[no encontrado]";
            }
            */
            Console.WriteLine("Traduccion: " + traduccion);
        }
        while (palabra != "");
    }
}
