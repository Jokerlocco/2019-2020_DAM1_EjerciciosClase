using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace MiniMiner
{
    class Nivel
    {
        private const int altoMapa = 16, anchoMapa = 32;
        private int anchoTile = 32, altoTile = 32;
        private int margenIzqdo = 0, margenSuperior = 0;

        private Sprite ladrillo, suelo, arbol, llave;
        protected List<Sprite> paredesSuelos;
        protected List<Sprite> llaves;
        protected List<Sprite> obstaculos;

        protected string[] datosNivel =
            new string[altoMapa];
        protected string nombre = "(Sin nombre)";

        public Nivel(ContentManager c)
        {
            ladrillo = new Sprite(0, 0, "paredNivel1", c);
            arbol = new Sprite(0, 0, "obstaculoNivel1", c);
            suelo = new Sprite(0, 0, "sueloNivel1", c);
            llave = new Sprite(0, 0, "itemNivel1", c);
        }

        public void Reiniciar()
        {
            paredesSuelos = new List<Sprite>();
            llaves = new List<Sprite>();
            obstaculos = new List<Sprite>();

            for (int fila = 0; fila < altoMapa; fila++)
            {
                for (int colum = 0; colum < anchoMapa; colum++)
                {
                    int posX = colum * anchoTile + margenIzqdo;
                    int posY = fila * altoTile + margenSuperior;
                    switch (datosNivel[fila][colum])
                    {
                        // Paredes y suelos
                        case 'D':
                        case 'S':
                        case 'F':
                            paredesSuelos.Add(new Sprite(posX, posY, suelo)); break;
                        case 'L': paredesSuelos.Add(new Sprite(posX, posY, ladrillo)); break;

                        // Obstáculos "que matan"
                        case 'A': obstaculos.Add(new Sprite(posX, posY, arbol)); break;

                        // Puertas
                        case 'P': /* ... */ break;

                        // Llaves y premios que permiten obtener puntos y pasar de nivel
                        case 'V': llaves.Add(new Sprite(posX, posY, llave)); break;
                    }
                }
            }

        }
        public void Dibujar(SpriteBatch listaSprites)
        {
            foreach (Sprite paredSuelo in paredesSuelos)
                paredSuelo.Dibujar(listaSprites);

            foreach (Sprite obtstaculo in obstaculos)
                obtstaculo.Dibujar(listaSprites);

            foreach (Sprite llave in llaves)
                llave.Dibujar(listaSprites);
        }

        public int ComprobarPuntosPorItems(Sprite personaje)
        {
            int puntos = 0;
            for (int i = 0; i < llaves.Count; i++)
            {
                if (llaves[i].ColisionaCon(personaje))
                {
                    llaves.RemoveAt(i);
                    puntos += 10;
                    break;
                }
            }
            return puntos;
        }

        public bool HayColisionesMortales(Sprite personaje)
        {
            bool tocaAlgoNocivo = false;
            for (int i = 0; i < obstaculos.Count; i++)
            {
                if (personaje.ColisionaCon(obstaculos[i]))
                {
                    tocaAlgoNocivo = true;
                }
            }
            return tocaAlgoNocivo;
        }

        public bool EsPosibleMover(Sprite personaje, float incremX, float incremY)
        {
            Sprite personajeDesplazado = new Sprite(
                (int) (personaje.X + incremX),
                (int) (personaje.Y + incremY),
                personaje);

            bool hayColisiones = false;
            for (int i = 0; i < paredesSuelos.Count; i++)
            {
                if (personajeDesplazado.ColisionaCon(paredesSuelos[i]))
                {
                    hayColisiones = true;
                }
            }
            return ! hayColisiones;
        }


        public string GetNombre()
        {
            return nombre;
        }
    }
}
