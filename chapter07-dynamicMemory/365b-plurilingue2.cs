//DAVID BERENGUER ANTON

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diccionarioTriple
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dic= new Dictionary<string, string>();
            Dictionary<string, string> dic2 = new Dictionary<string, string>();

            dic.Add("uno", "one");
            dic.Add("dos", "two");
            dic.Add("tres", "tjree");

            dic2.Add("uno", "un");
            dic2.Add("dos", "deux");
            dic2.Add("tres", "trois");

            
            Console.WriteLine("1. español a ingles");
            Console.WriteLine("4. español a frances");

            Console.Write("elige una opcion");
            string opcion = Console.ReadLine();
            string palabra;
            do
            {
                Console.Write("¿Palabra?: ");
                palabra = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        if (dic.ContainsKey(palabra))
                        {
                            Console.WriteLine("Traduccion: " + dic[palabra]);
                        }
                        else
                        {
                            Console.WriteLine("Traduccion: [No encontrado]");
                        }
                        break;
                        
                    case "4":
                        if (dic.ContainsKey(palabra))
                        {
                            string valorIngles = dic[palabra];
                            if (dic2.ContainsKey(valorIngles))
                            {
                                Console.WriteLine(dic2[valorIngles]);
                            }
                            else
                            {
                                Console.WriteLine("Traduccion: [No encontrado]");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Traduccion: [No encontrado]");
                        }
                        break;
                }
            }
            while (palabra != "");
            

        }
    }
}
