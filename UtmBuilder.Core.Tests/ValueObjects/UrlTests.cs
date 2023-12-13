using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValueObjects
{
    [TestClass]
    public class UrlTests
    {
        private const string InvalidUrl = "xpto";
        private const string ValidUrl = "https://google.com";
        [TestMethod]
        public void Dado_uma_url_invalida_deve_retornar_uma_excecao()
        {
            try
            {
                new Url(InvalidUrl);
                Assert.Fail();
            }
            catch (InvalidUrlException e)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Dado_uma_url_valida_nao_deve_retornar_uma_excecao()
        {
            new Url(ValidUrl);
            Assert.IsTrue(true);

        }
    }
}
