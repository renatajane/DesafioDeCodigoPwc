using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigoPwc._2.Remove
{
    public class RemoveCharDuplicado
    {
        public string RemoverCaracteresDuplicados(string frase)
        {

            string fraseSemRepeticao = string.Join("", frase.ToCharArray().Distinct());

            return fraseSemRepeticao;
        }
    }
}
