using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_DS_Metodos_Csharp.Atividade1
{
    internal class ClasseA
    {
        static void Main(string[] args)
        {
            // Atividade 1
            string categoria;

            ClasseB cb = new ClasseB();

            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o idade: ");
            int idade_pessoa = Int32.Parse(Console.ReadLine());

            if (idade_pessoa < 5)
            {
                Console.WriteLine("Desculpe, mas você é muito jovem");
            }

            else if (idade_pessoa < 8)
            {
                categoria = "Infantil A";

                cb.verificar_idade( nome, idade_pessoa);
                Console.WriteLine("Sua categoria é " + categoria);
            }

            else if (idade_pessoa < 11)
            {
                categoria = "Infantil B";

                cb.verificar_idade( nome, idade_pessoa);
                Console.WriteLine("Sua categoria é " + categoria);
            }

            else if (idade_pessoa < 14)
            {
                categoria = "Juvenil A";

                cb.verificar_idade( nome, idade_pessoa);
                Console.WriteLine("Sua categoria é " + categoria);
            }

            else if (idade_pessoa < 18)
            {
                categoria = "Juvenil B";

                cb.verificar_idade( nome, idade_pessoa);
                Console.WriteLine("Sua categoria é " + categoria);
            }

            else
            {
                categoria = "Adulto B";

                cb.verificar_idade( nome, idade_pessoa);
                Console.WriteLine("Sua categoria é " + categoria);
            }

            Console.ReadKey();
        }
    }
}
