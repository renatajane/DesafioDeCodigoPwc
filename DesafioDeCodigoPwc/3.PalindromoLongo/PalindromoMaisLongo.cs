using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigoPwc._3.PalindromoLongo
{
    internal class PalindromoMaisLongo
    {
        public string IdentificarPalindromoMaisLongo(String palavra)
        {
            int maxLength = 1;
            int start = 0;

            for (int i = 0; i < palavra.Length; i++)
            {
                for (int j = i; j < palavra.Length; j++)
                {
                    bool isPalindrome = true;

                    for (int k = 0; k < (j - i + 1) / 2; k++)
                    {
                        if (palavra[i + k] != palavra[j - k])
                        {
                            isPalindrome = false;
                            break;
                        }
                    }

                    if (isPalindrome && (j - i + 1) > maxLength)
                    {
                        start = i;
                        maxLength = j - i + 1;
                    }
                }
            }
            return palavra.Substring(start, maxLength);
         }
    }
}
