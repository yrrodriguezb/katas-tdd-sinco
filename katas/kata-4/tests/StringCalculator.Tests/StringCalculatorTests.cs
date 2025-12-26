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
        
        [Fact]
        public void Si_Ingreso1y2SeparadosPorComa_Debe_Retornar3()
        {
            var result = Calculator.Calculate("1,2");
            
            result.Should().Be(3);
        }
        
        [Fact]
        public void Si_IngresoTresNumerosSeparadosPorComa_Debe_Sumarlos()
        {
            var result = Calculator.Calculate("1,2,3");
    
            result.Should().Be(6);
        }
        
        [Fact]
        public void Si_IngresoTresNumerosSeparadoPorSaltoDeLineaYComa_Debe_Sumarlos()
        {
            var result = Calculator.Calculate("1\n2,3");
            
            result.Should().Be(6);
        }
    }
}