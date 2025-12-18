using FluentAssertions;
using Xunit;

namespace LeapYear.Tests
{
    public class LeapYearCheckerTests
    {
        [Fact]
        public void Si_IngresoElAnio2001_Debe_RetornarFalso()
        {
            LeapYearChecker.IsLeapYear(2001).Should().BeFalse();
        }
        
        [Fact]
        public void Si_IngresoElAnio2004_Debe_RetornarVerdadero()
        {
            LeapYearChecker.IsLeapYear(2004).Should().BeTrue();
        }
        
        [Fact]
        public void Si_IngresoElAnio2008_Debe_RetornarVerdadero()
        {
            LeapYearChecker.IsLeapYear(2008).Should().BeTrue();
        }
        
        [Fact]
        public void Si_IngresoElAnio1900_Debe_RetornarFalso()
        {
            LeapYearChecker.IsLeapYear(1900).Should().BeFalse();
        }
    }
}
