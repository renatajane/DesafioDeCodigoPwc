using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigoPwc._5.ExistenciaPalindromo
{
    internal class ExistenciaDePalindromo
    {
        public bool IdentificarPalindromo(string palavra)
        {
            string palavraDecrescente = "";

            for (int i = palavra.Length - 1; i >= 0; i--)
            {
                palavraDecrescente += palavra[i].ToString();

            }
            if (palavraDecrescente.Equals(palavra,StringComparison.OrdinalIgnoreCase))
            {
                
                return true;
            }
            return false;
        }
    }
}
