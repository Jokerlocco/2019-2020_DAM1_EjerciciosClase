using Microsoft.Xna.Framework.Content;
using System.Collections.Generic;

namespace MiniMiner
{
    class GestorDeNiveles
    {
        public Nivel NivelActual;
        private List<Nivel> niveles;
        private int numeroDeNivelActual;

        public GestorDeNiveles(ContentManager c)
        {
            niveles = new List<Nivel>();
            niveles.Add( new Nivel01(c) );
            niveles.Add( new Nivel02(c) );
            numeroDeNivelActual = 0;
            NivelActual = niveles[0];
        }

        public void AvanzarNivel()
        {
            numeroDeNivelActual++;
            if (numeroDeNivelActual >= niveles.Count)
                numeroDeNivelActual = 0;
            NivelActual = niveles[numeroDeNivelActual];
        }
    }
}
