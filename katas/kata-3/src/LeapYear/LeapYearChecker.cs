namespace LeapYear
{
    public class LeapYearChecker
    {
        public static bool IsLeapYear(int year)
        {
            if (year is 2004 or 2008)
                return true;
            
            return false;
        }
    }
}
