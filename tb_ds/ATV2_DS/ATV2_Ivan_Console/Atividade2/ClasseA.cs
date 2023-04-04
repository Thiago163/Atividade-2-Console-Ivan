using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV2_Ivan_Console
{
    class ClasseA
    {
        static void Main(string[] args)
        {
           // Atividade 2

            ClasseB dadada = new ClasseB();

            Console.WriteLine(
                "\n\n\t Chamada dos métodos com retorno e com parametro \n");

            Console.Write("Digite o mês 1: ");
            double mes1 = Double.Parse(Console.ReadLine());

            Console.Write("Digite o mês 2: ");
            double mes2 = Double.Parse(Console.ReadLine());

            Console.Write("Digite o mês 3: ");
            double mes3 = Double.Parse(Console.ReadLine());

            Console.Write("Digite o mês 4: ");
            double mes4 = Double.Parse(Console.ReadLine());

            Console.Write("Digite o mês 5: ");
            double mes5 = Double.Parse(Console.ReadLine());

            Console.Write("Digite o mês 6: ");
            double mes6 = Double.Parse(Console.ReadLine());

            Console.WriteLine("O resultado da média é: " + dadada.calculo_media(mes1, mes2, mes3, mes4, mes5, mes6));


            Console.ReadKey();
        }
    }
}
