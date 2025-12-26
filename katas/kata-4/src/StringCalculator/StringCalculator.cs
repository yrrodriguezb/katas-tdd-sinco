namespace StringCalculator
{
    public class Calculator
    {
        public static int Calculate(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            var delimitadorNumeros = ResolverDelimitadorYNumeros(input);

            return SumarNumeros(delimitadorNumeros);
        }

        private static int SumarNumeros(DelimitadorNumeros delimitadorNumeros)
        {
            return delimitadorNumeros.Numeros
                .Split(delimitadorNumeros.Delimitador)
                .Select(int.Parse)
                .Sum();
        }


        private static DelimitadorNumeros ResolverDelimitadorYNumeros(string input)
        {
            var delimitador = ",";
            var numerosTexto = input;

            if (input.StartsWith("//"))
            {
                var partes = input.Split('\n');
                delimitador = partes[0].Substring(2);
                numerosTexto = partes[1];
            }

            numerosTexto = numerosTexto.Replace("\n", delimitador);

            return new DelimitadorNumeros(delimitador, numerosTexto);
        }
    }

    public record DelimitadorNumeros(string Delimitador, string Numeros);
}