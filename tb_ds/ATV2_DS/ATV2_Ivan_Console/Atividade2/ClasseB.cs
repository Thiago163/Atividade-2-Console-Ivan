using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV2_Ivan_Console
{
    class ClasseB
    {
        // Atividade 2

        public double calculo_media(double mes1, double mes2, double mes3, double mes4, double mes5, double mes6)
        {
            double res_media = (mes1 + mes2 + mes3 + mes4 + mes5 + mes6) / 6;

            res_media = (mes1 + mes2 + mes3 + mes4 + mes5 + mes6) / 6;


            if (res_media < 99.9)
            {
                Console.WriteLine("A média foi " + res_media + " Consumo normal");
            }

            if (res_media >= 100 && res_media <= 299.9)
            {
                Console.WriteLine("A média foi " + res_media + " Consumo alto");
            }

            if (res_media >= 300)
            {
                Console.WriteLine("A média foi " + res_media + " Consumo muito alto");
            }

            return res_media;
        }
    }
}
