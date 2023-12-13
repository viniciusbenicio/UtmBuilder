using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValueObjects
{
    [TestClass]
    public class UrlTests
    {
        [TestMethod]
        public void Dado_uma_url_invalida_deve_retornar_uma_excecao()
        {
            try
            {
                var url = new Url("xpto");
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
            Assert.Fail();
        }
    }
}
