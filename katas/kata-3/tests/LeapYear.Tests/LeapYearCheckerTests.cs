using FluentAssertions;
using Xunit;

namespace LeapYear.Tests
{
    public class LeapYearCheckerTests
    {
        [Fact]
        public void Si_IngresoElAnio2001_Debe_RetornarFalso()
        {
            // Ejemplo: 2001 no es año bisiesto
            LeapYearChecker.IsLeapYear(2001).Should().BeFalse();
        }
        
        [Fact]
        public void Si_IngresoElAnio2004_Debe_RetornarVerdadero()
        {
            LeapYearChecker.IsLeapYear(2004).Should().BeTrue();
        }
    }
}
