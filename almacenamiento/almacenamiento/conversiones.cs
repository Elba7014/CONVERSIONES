using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace almacenamiento
{
    class conversiones
    {
        string[][] conversor = {
            new string[] { "Dolares", "Colones SV", " Yenes ", "Rupia ", "Peso (Chileno) ", "Peso (MX) ", "Peso (Argentino)", " Bitcoin " },
            new string[] { "Megabyte ", "bit ", " bite", "Kilobyte", "Gigabyte ", " Terabyte  " }

        };
        double[][] valor =
        {
            new double[] { 1, 8.75 , 111.27 , 69.75 , 667.08 , 19.36 , 39.69 , 0.00026 },
             new double[] { 8388608, 1048576, 1024, 0.0009765625, 0.00000095367431660625 }
        };
        public double convertir(int option, int de, int a, double cantidad)
        {
            return valor [option] [a]/valor[option][de] * cantidad;

        }
    }
}
