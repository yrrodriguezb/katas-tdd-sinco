using Xunit;
using FluentAssertions;

namespace StringCalculator.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Si_SeIngresaUnTextoVacio_Debe_RetornarCero()
        {
            var result = Calculator.Calculate("");
            
            result.Should().Be(0);
        }
    }
}