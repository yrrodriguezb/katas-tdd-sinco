namespace LeapYear
{
    public class LeapYearChecker
    {
        public static bool IsLeapYear(int year)
        {
            if (EsDivisiblePor400(year))
                return true;
            else if (EsDivisiblePor100(year))
                return false;
            else
                return EsDivisiblePorCuatro(year);
        }

        private static bool EsDivisiblePor400(int year) => EsDivisiblePor(year, 400);

        private static bool EsDivisiblePor100(int year) => EsDivisiblePor(year, 100);

        private static bool EsDivisiblePorCuatro(int year) => EsDivisiblePor(year, 4);

        private static bool EsDivisiblePor(int year, int divisor) => year % divisor == 0;
    }
}
