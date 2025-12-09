
namespace calculadoraApp.Tests
{
    public class CalculadoraAppTests
    {
        [Fact]
        public void Sumar_DosNumeros_VerificaSumaCorrecta()
        {
            // Arrange
            var calc = new CalculadoraApp.calculadoraApp();
            var resultado = calc.Sumar(2, 3);
            Assert.Equal(5, resultado);
        }
    }
}