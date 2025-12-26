namespace StringCalculator
{
    public class Calculator
    {
        public static int Calculate(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            var numbers = input.Split(',');
            return numbers.Sum(n => int.Parse(n));
        }
    }
}