using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigoPwc._4.LetraMaiuscula
{
    public class PrimeiraLetraMaiuscula
    {
        public string ConverterPrimeiraLetraEmMaiuscula(string frase)
        {
            frase = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(frase);
            return frase;
        }
    }
}
