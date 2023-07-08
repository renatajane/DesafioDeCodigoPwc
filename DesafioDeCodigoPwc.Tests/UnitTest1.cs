namespace DesafioDeCodigoPwc.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestarReverterFrase()
        {
            var objeto = new DesafioDeCodigoPwc._1.Reverter.ReverteOrdem();
            var resultado = objeto.ReverterFrase("Hello, World! OpenAI is amazing.");

            Assert.Equal("amazing. is OpenAI World! Hello,", resultado);
        }

        [Fact]
        public void TestarRemoverCharDuplicado()
        {
            var objeto = new DesafioDeCodigoPwc._2.Remove.RemoveCharDuplicado();
            var resultado = objeto.RemoverCaracteresDuplicados("Hello, World!");

            Assert.Equal("Helo, Wrd!", resultado);
        }

        [Fact]
        public void TestarPalindromoMaisLongo()
        {
            var objeto = new DesafioDeCodigoPwc._3.PalindromoLongo.PalindromoMaisLongo();
            var resultado = objeto.IdentificarPalindromoMaisLongo("babad");
            Assert.Equal("bab", resultado);
        }

        [Fact]
        public void TestarPrimeiraLetraMaiuscula()
        {
            var objeto = new DesafioDeCodigoPwc._4.LetraMaiuscula.PrimeiraLetraMaiuscula();
            var resultado = objeto.ConverterPrimeiraLetraEmMaiuscula("hello, how are you? i'm fine, thank you.");
            Assert.Equal("Hello, How Are You? I'm Fine, Thank You.", resultado);
        }

        [Fact]
        public void TestarExistenciaDePalindromo()
        {
            var objeto = new DesafioDeCodigoPwc._5.ExistenciaPalindromo.ExistenciaDePalindromo();
            var resultado = objeto.IdentificarPalindromo("racecar");

            Assert.True(resultado);
        }
    }
}