using Microsoft.Xna.Framework.Content;

namespace MiniMiner
{
    class Nivel02 : Nivel
    {
        public Nivel02(ContentManager c)
            : base(c)
        {
            nombre = "The cold room";
            datosNivel = new string[] {
                "L                  LLLLLLLLLLLLL",
                "L      V                V     TL",
                "L                              L",
                "L                    FFFF      L",
                "L                              L",
                "LSSSSSSSSSSSSSSSSSSS        L  L",
                "L                    SSSSLFFL  L",
                "LSFFFFF                  LV L  L",
                "L                        LFFL  L",
                "L  V     SSSSSSS         LFFL  L",
                "L                  FFFF  LFFL  L",
                "L  DDDD                  LFFL  L",
                "L             SSSS V     LFFL  L",
                "L       FFFF                 PPL",
                "L                            PPL",
                "LSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSL"
            };
            Reiniciar();
        }
    }
}
