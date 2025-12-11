using FizzBuzz;
using FluentAssertions;

namespace FizzBuzz.Tests
{
    public class FizzBuzzGeneratorTests
    {
        [Fact]
        public void Si_Ingreso1_Debe_Retornar1()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(1);
            
            // Assert
            result.Should().HaveCount(1);
            result[0].Should().Be("1");
        }
        
        
    }
}