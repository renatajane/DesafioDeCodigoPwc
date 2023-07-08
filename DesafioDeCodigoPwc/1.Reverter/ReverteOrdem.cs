using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigoPwc._1.Reverter
{
    public class ReverteOrdem
    {
        public string ReverterFrase (string frase)
        {
            string[] palavras = frase.Split(' ');
            Array.Reverse(palavras);

            string fraseInversa = string.Join(" ", palavras);

            return fraseInversa;
        }
    }
}
