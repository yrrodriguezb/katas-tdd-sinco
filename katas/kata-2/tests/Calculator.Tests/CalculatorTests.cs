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
        
        [Fact] 
        public void Si_Sumo1y3_Debe_Retornar4()
        {
            // Arrange
            int a = 1;
            int b = 3;

            // Act
            int result = _calculator.Add(a, b);

            // Assert
            result.Should().Be(4);
        }
        
        [Fact] 
        public void Si_Resto1de1_Debe_Retornar0()
        {
            // Arrange
            int a = 1;
            int b = 1;

            // Act
            int result = _calculator.Subtract(a, b);

            // Assert
            result.Should().Be(0);
        }
        
        [Fact] 
        public void Si_Resto1de2_Debe_Retornar1()
        {
            // Arrange
            int a = 2;
            int b = 1;

            // Act
            int result = _calculator.Subtract(a, b);

            // Assert
            result.Should().Be(1);
        }
        
        [Fact] 
        public void Si_Resto1de3_Debe_Retornar2()
        {
            // Arrange
            int a = 3;
            int b = 1;

            // Act
            int result = _calculator.Subtract(a, b);

            // Assert
            result.Should().Be(2);
        }
        
        [Fact] 
        public void Si_Multiplico1por1_Debe_Retornar1()
        {
            // Arrange
            int a = 1;
            int b = 1;

            // Act
            int result = _calculator.Multiply(a, b);

            // Assert
            result.Should().Be(1);
        }
        
        [Fact] 
        public void Si_Multiplico1por2_Debe_Retornar2()
        {
            // Arrange
            int a = 1;
            int b = 2;

            // Act
            int result = _calculator.Multiply(a, b);

            // Assert
            result.Should().Be(2);
        }
        
        [Fact] 
        public void Si_Multiplico1por3_Debe_Retornar3()
        {
            // Arrange
            int a = 1;
            int b = 3;

            // Act
            int result = _calculator.Multiply(a, b);

            // Assert
            result.Should().Be(3);
        }
        
        [Fact] 
        public void Si_Divido2Entre1_Debe_Retornar2()
        {
            // Arrange
            int a = 2;
            int b = 1;

            // Act
            int result = _calculator.Divide(a, b);

            // Assert
            result.Should().Be(2);
        }
        
        [Fact] 
        public void Si_Divido2Entre2_Debe_Retornar1()
        {
            // Arrange
            int a = 2;
            int b = 2;

            // Act
            int result = _calculator.Divide(a, b);

            // Assert
            result.Should().Be(1);
        }
    }
}