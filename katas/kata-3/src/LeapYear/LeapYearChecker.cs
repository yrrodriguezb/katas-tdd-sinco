namespace LeapYear
{
    public class LeapYearChecker
    {
        public static bool IsLeapYear(int year)
        {
            if (year == 2000)
                return true;
            
            if (EsDivisiblePor100(year))
                return false;
            
            return EsDiviblePorCuatro(year);
        }

        private static bool EsDivisiblePor100(int year)
        {
            return EsDivisiblePor(year, 100);
        }

        private static bool EsDiviblePorCuatro(int year)
        {
            return EsDivisiblePor(year, 4);
        }

        private static bool EsDivisiblePor(int year, int divisor)
        {
            return year % divisor == 0;
        }
    }
}
