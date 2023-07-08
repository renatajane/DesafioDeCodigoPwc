using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigoPwc.View
{
    internal class Menu
    {
        public string MostrarOpcoes()
        {
            Console.WriteLine("===============MENU=====================");
            Console.WriteLine("OLÁ, ");
            Console.WriteLine("ESCOLHA UMA DAS OPÇÕES A SEGUIR:\n");
            Console.WriteLine("1 - Reverter ordem da frase");
            Console.WriteLine("2 - Remover caracteres duplicados da string");
            Console.WriteLine("3 - Encontrar a substring palíndroma mais longa da string");
            Console.WriteLine("4 - Converter primeira letra em maiúscula");
            Console.WriteLine("5 - Verificar se a string é anagrama de um palíndromo");
            Console.WriteLine("6 - Sair");
            Console.WriteLine("=========================================");
            var opcao = Console.ReadLine();
            return opcao;
        }
    }
}
