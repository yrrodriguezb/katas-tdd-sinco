using Xunit;
using FluentAssertions;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator = new();

        [Fact] 
        public void Si_Sumo1y1_Debe_Retornar2()
        {
            // Arrange
            int a = 1;
            int b = 1;

            // Act
            int result = _calculator.Add(a, b);

            // Assert
            result.Should().Be(2);
        }

        [Fact] 
        public void Si_Sumo1y2_Debe_Retornar3()
        {
            // Arrange
            int a = 1;
            int b = 2;

            // Act
            int result = _calculator.Add(a, b);

            // Assert
            result.Should().Be(3);
        }
    }
}