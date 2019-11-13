using System;
using System.IO;

class Repasador
{
    struct pregunta
    {
        public string enunciado;
        public string respuesta1;
        public string respuesta2;
        public string respuesta3;
        public string respuesta4;
        public int correcta;
    }

    static void Main()
    {
        pregunta[] preguntas;
        string[] datos = File.ReadAllLines("datos.txt");

        int cantidadDeDatos = datos.Length;
        int tamanyoArray = cantidadDeDatos / 7;
        preguntas = new pregunta[tamanyoArray];

        int lineaActual = 0;
        for (int i = 0; i < tamanyoArray; i++)
        {
            preguntas[i].enunciado = datos[lineaActual];
            preguntas[i].respuesta1 = datos[lineaActual + 1];
            preguntas[i].respuesta2 = datos[lineaActual + 2];
            preguntas[i].respuesta3 = datos[lineaActual + 3];
            preguntas[i].respuesta4 = datos[lineaActual + 4];
            preguntas[i].correcta = 
                Convert.ToInt32( datos[lineaActual + 5] );
            lineaActual += 7;
        }

        int cantidadDePreguntas = 10;
        double puntos = 0;
        for (int i = 0; i < cantidadDePreguntas; i++)
        {
            // Saco una pregunta al azar
            int azar = DateTime.Now.Millisecond % cantidadDePreguntas;
            
            // Muestro enunciado y respuestas
            Console.WriteLine(preguntas[azar].enunciado);
            Console.WriteLine("1. " + preguntas[azar].respuesta1);
            Console.WriteLine("2. " + preguntas[azar].respuesta2);
            Console.WriteLine("3. " + preguntas[azar].respuesta3);
            Console.WriteLine("4. " + preguntas[azar].respuesta4);
            Console.WriteLine("-> " + preguntas[azar].correcta);

            // Pido al usuario
            Console.Write("> ");
            string respuesta = Console.ReadLine();

            // Compruebo y actualizo puntuación
            if ((respuesta == "1") && (preguntas[azar].correcta == 1))
            {
                // ...
            }
        }

    }
}
