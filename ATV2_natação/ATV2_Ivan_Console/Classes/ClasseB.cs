using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV2_Ivan_Console
{
    class ClasseB
    {
        // 03º Exemplo - método com 2 ou + paramêtros (String e int)

        public void nadador(String nome, int idade)
        {

            if (idade < 5)
            {
                Console.WriteLine(nome + " você infelizmente não se enquadra");
            }

            if (idade >= 5 && idade <= 7)
            {
                Console.WriteLine(nome + " você está no Infantil A");
            }

            if (idade >= 8 && idade <= 10)
            {
                Console.WriteLine(nome + " você está no Infantil B");
            }

            if (idade >= 11 && idade <= 13)
            {
                Console.WriteLine(nome + " você está no Juvenil A");
            }

            if (idade >= 14 && idade <= 17)
            {
                Console.WriteLine(nome + " você está no Juvenil B");
            }

            if (idade >= 18)
            {
                Console.WriteLine(nome + " você está no Adulto");
            }
        }
    }
}
