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
            ClasseB cb = new ClasseB();

            // Chamada do 03º método (String e int)

            cb.nadador("Ana Silva", 2);
            cb.nadador("Gabriel Monteiro", 5);
            cb.nadador("Maria de Lurdes", 8);
            cb.nadador("Ivan Conhecimentos", 11);
            cb.nadador("Lourival Santos", 14);
            cb.nadador("Luiz Ramões", 18);

            string nome_escolhido = "Thiago Miranda";
            int idade = 25;
            cb.nadador(nome_escolhido, idade);

            Console.ReadKey(); Console.Clear();

            Console.ReadLine();
        }
    }
}
