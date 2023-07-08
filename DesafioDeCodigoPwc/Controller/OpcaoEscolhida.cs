using DesafioDeCodigoPwc._1.Reverter;
using DesafioDeCodigoPwc._2.Remove;
using DesafioDeCodigoPwc.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigoPwc.Controller
{
    internal class OpcaoEscolhida
    {
        public void EscolherOpcao()
        {

            var opcaoEscolhida = new DesafioDeCodigoPwc.View.Menu();

            try
            {
               string opcao = opcaoEscolhida.MostrarOpcoes();

                Console.Clear();
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("----REVERTER ORDEM DA FRASE----");
                        Console.WriteLine("\n");
                        var reverte = new DesafioDeCodigoPwc._1.Reverter.ReverteOrdem();
                        Console.WriteLine(reverte.ReverterFrase("Hello, World! OpenAI is amazing."));
                        break;
                    case "2":
                        Console.WriteLine("----REMOVER CARACTERES DUPLICADOS DA STRING----");
                        Console.WriteLine("\n");
                        var remove = new DesafioDeCodigoPwc._2.Remove.RemoveCharDuplicado();
                        Console.WriteLine(remove.RemoverCaracteresDuplicados("Hello, World!"));
                        break;
                    case "3":
                        Console.WriteLine("----ENCONTRAR A SUBSTRING PALINDROMA MAIS LONGA DA STRING----");
                        Console.WriteLine("\n");
                        var identifica = new DesafioDeCodigoPwc._3.PalindromoLongo.PalindromoMaisLongo();
                        Console.WriteLine(identifica.IdentificarPalindromoMaisLongo("babad")); ;
                        break;
                    case "4":
                        Console.WriteLine("----CONVERTER PRIMEIRA LETRA EM MAIÚSCULA----");
                        Console.WriteLine("\n");
                        var aumentaLetra = new DesafioDeCodigoPwc._4.LetraMaiuscula.PrimeiraLetraMaiuscula();
                        Console.WriteLine(aumentaLetra.ConverterPrimeiraLetraEmMaiuscula("hello, how are you? i'm fine, thank you."));
                        break;
                    case "5":
                        Console.WriteLine("----VERIFICAR SE A STRING É ANAGRAMA DE UM PALÍNDROMO----");
                        Console.WriteLine("\n");
                        var identificaPalindromo = new DesafioDeCodigoPwc._5.ExistenciaPalindromo.ExistenciaDePalindromo();
                        Console.WriteLine(identificaPalindromo.IdentificarPalindromo("racecar"));
                        break;
                    case "6":
                        break;
                    default:
                        Console.WriteLine("Opcao não implementada.");
                        break;
                }
                if (opcao != "6")
                {
                    EscolherOpcao();
                }
             }
            catch (Exception excecao)
            {
                Console.WriteLine("Erro, não foi possível concluir a operação." + excecao.Message);
            }
        }
    }
}

