namespace StringCalculator
{
    public class Calculator
    {
        public static int Calculate(string input)
        {
            var str = NormalizarEntrada(input);
            if (string.IsNullOrEmpty(str))
                return 0;

            var numbers = str.Split(',');
            
            return numbers.Sum(n => int.Parse(n));
        }

        private static string NormalizarEntrada(string input)
        {
            return input.Replace("\n", ",");
        }
    }
}