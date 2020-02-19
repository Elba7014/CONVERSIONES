using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones
{
    class Formula
    {
        public string[][] etiquetas =
       {
            new string [] {"Dolar","Colones(SV)","Yenes","Rupias","Lempiras", "Peso MX","BitCoin", "Quetzal", "Euro","Cordoba","Balboa","Peso Argentino", "Peso Chileno", "Peso Colombiano", "Soles(Peru)", "Dolar Canadiense", "Dolar Beliceño"}
           
        };
        double[][] valores =
      {
            new double[] { 1, 8.75, 111.26, 69.75, 24.36, 19.36, 0.00026, 7.69, 0.88,32.95,1.00,39.95, 667.65, 3126.73,3.30, 1.33, 2.02 }
            };
        public double convertir(int de, int a, double cantidad, int opcion)
        {
            return Math.Round(valores[opcion][a] / valores[opcion][de] * cantidad, 2);
        }
    }
}
