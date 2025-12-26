namespace StringCalculator
{
    public class Calculator
    {
        public static int Calculate(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            var delimitador = ",";
            var entrada = input;

            if (input.StartsWith("//"))
            {
                var subCadena = input.Split('\n');
                delimitador = subCadena[0].Substring(2);
                entrada = subCadena[1];
            }

            entrada = entrada.Replace("\n", ",");

            var numbers = entrada.Split(delimitador);
            return numbers.Sum(n => int.Parse(n));
        }
    }
}