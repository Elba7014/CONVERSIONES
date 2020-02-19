using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones
{
    class Formula
    {
        public string[] Tipo = {"Almacenamiento", "Longitud", "Monedas", "Peso", "Volumenes" };
        public string[][] etiquetas =
       {
            //Almacenamiento
            new string  []{"MegaBytes", "KiloBytes", "GigaBytes", "TeraBytes", "PentaBytes", "ExaBytes", "Bit", "Byte", "Zettabyte", "Kilobit", "Megabit", "Megabibit", "Gigabit", "Gigabibit", "Terabit", "Terabibit","Petabit", "Petabibit" },
            //longitud
            new string  []{"Metro", "Cm", "Pulgada", "pie", "Varas","Yardas","Km","Millas", "Milimetro","MicroMetro", "NanoMetro", "Decametro" },
            //monedas
            new string [] {"Dolar","Colones(SV)","Yenes","Rupias","Lempiras", "Peso Mexicano","BitCoin", "Quetzal", "Euro","Cordoba","Balboa","Peso Argentino", "Peso Chileno", "Peso Colombiano", "Soles(Peru)", "Dolar Canadiense", "Dolar Beliceño", "Dolar australiano","Pula", "Real brasileño", "Riel cambo"},
            //peso
            new string  []{"Kilogramo","Gramo","Miligramo","MicroGramo","Libra","Onza", "Tonelada", "Stone"  },
            //volumenes
            new string  []{ "Litro", "MiliLitro", "Metro Cubico", "Galon", "Pie Cubico", "Taza Americana", "Galon estadounidense", "Cuarto estadounidense", "Galon imperial", "Cuarto imperial" }
        };
        double[][] valores =
      {
            //almacenamiento
            new double[] {1, 1024, 9.77e-4, 9.54e-7, 9.31e-10, 9.09e-13, 8e+6, 1e+6, 1e-15, 8, 7.62939, 8000, 0.008, 0.00745058, 8e-6, 7.276e-6, 8e-9, 7.1054e-9 },
            //longitud
            new double[]{ 1, 100, 39.3701, 3.28084, 1.1963081929167, 1.09361, 0.001, 0.000621371, 1000, 1e+6, 1e+9 },
            //monedas
            new double[] { 1, 8.75, 111.26, 69.75, 24.36, 19.36, 0.00026, 7.69, 0.88,32.95,1.00,39.95, 667.65, 3126.73,3.30, 1.33, 2.02, 1.49, 11.04, 4.36, 4104.86 },
            //peso
            new double[]{1, 1000, 1e+6 , 1e+9, 2.20462, 35.274, 0.001, 0.157473  },
            //volumenes
            new double[]{ 1, 1000, 0.001, 0.264172, 0.0353147, 4.167, 0.264172, 1.05669, 0.219969, 0.879877 }
            };
        public double convertir(int de, int a, double cantidad, int opcion)
        {
            return Math.Round(valores[opcion][a] / valores[opcion][de] * cantidad, 2);
        }
    }
}
