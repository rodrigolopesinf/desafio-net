using ConsoleApp1;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void DeveTestarSeRetornaJWT()
        {
            MainClass mainClass = new MainClass();

            string retorno = mainClass.GenerateJwtWithFixedClains("your-secret-key-1234", "you-issuer", "your-audience", "sub-value-1", "jti-value-1", 16263000000);

            Assert.True(retorno != null);
        }
    }
}