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
            result.Should().HaveCount(4);
            result[0].Should().Be("1");
            result[1].Should().Be("2");
            result[2].Should().Be("Fizz");
            result[3].Should().Be("4");
        }
        
        [Fact]
        public void Si_Ingreso5_Debe_RetornarLaListaCorrespondiente()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(5);
            
            // Assert
            result.Should().HaveCount(5);
            result[0].Should().Be("1");
            result[1].Should().Be("2");
            result[2].Should().Be("Fizz");
            result[3].Should().Be("4");
            result[4].Should().Be("Buzz");
        }
        
        [Fact]
        public void Si_Ingreso15_Debe_RetornarLaListaCorrespondiente()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(15);
            
            // Assert
            result.Should().HaveCount(15);
            result[0].Should().Be("1");
            result[1].Should().Be("2");
            result[2].Should().Be("Fizz");
            result[3].Should().Be("4");
            result[4].Should().Be("Buzz");
            result[5].Should().Be("Fizz");
            result[6].Should().Be("7");
            result[7].Should().Be("8");
            result[8].Should().Be("Fizz");
            result[9].Should().Be("Buzz");
            result[10].Should().Be("11");
            result[11].Should().Be("Fizz");
            result[12].Should().Be("13");
            result[13].Should().Be("14");
            result[14].Should().Be("FizzBuzz");
        }
    }
}