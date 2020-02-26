using Microsoft.Xna.Framework.Content;

namespace MiniMiner
{
    class Nivel01 : Nivel
    {
        public Nivel01(ContentManager c)
            : base(c)
        {
            nombre = "Central Cavern";
            datosNivel = new string[] {
                "L        V T    T            V L",
                "L               V              L",
                "L                              L",
                "L                              L",
                "L                      VA  A   L",
                "LSS  SSSSSSSSSFFFFSFFFFSSSSSSSSL",
                "L                             VL",
                "LSSS                           L",
                "L                LLL A         L",
                "LSSSS   DDDDDDDDDDDDDDDDDDDD   L",
                "L                            SSL",
                "L                              L",
                "L            A      LLL  FFFSSSL",
                "L    SSSSSSSSSSSSSSS         PPL",
                "L                            PPL",
                "LSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSL"
            };
            Reiniciar();
        }
    }
}
