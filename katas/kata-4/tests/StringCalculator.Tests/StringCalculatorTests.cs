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
        
        [Fact]
        public void Si_Ingreso1_Debe_Retornar1()
        {
            var result = Calculator.Calculate("1");
            
            result.Should().Be(1);
        }
    }
}