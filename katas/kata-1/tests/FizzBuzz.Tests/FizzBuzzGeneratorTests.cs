using FizzBuzz;
using FluentAssertions;

namespace FizzBuzz.Tests
{
    public class FizzBuzzGeneratorTests
    {
        [Fact]
        public void Si_Ingreso1_Debe_RetornarLaListaCorrespondiente()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(1);
            
            // Assert
            result.Should().HaveCount(1);
            result[0].Should().Be("1");
        }
        
        [Fact]
        public void Si_Ingreso2_Debe_RetornarLaListaCorrespondiente()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(2);
            
            // Assert
            result.Should().HaveCount(2);
            result[0].Should().Be("1");
            result[1].Should().Be("2");
        }
        
        [Fact]
        public void Si_Ingreso3_Debe_RetornarLaListaCorrespondiente()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(3);
            
            // Assert
            result.Should().HaveCount(3);
            result[0].Should().Be("1");
            result[1].Should().Be("2");
            result[2].Should().Be("Fizz");
        }
        
        [Fact]
        public void Si_Ingreso4_Debe_RetornarLaListaCorrespondiente()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(4);
            
            // Assert
            result.Should().HaveCount(3);
            result[0].Should().Be("1");
            result[1].Should().Be("2");
            result[2].Should().Be("Fizz");
            result[3].Should().Be("4");
        }
    }
}