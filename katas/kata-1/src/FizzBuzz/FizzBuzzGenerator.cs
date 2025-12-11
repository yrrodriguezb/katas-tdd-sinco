namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public static List<string> Generate(int count)
        {
            var lista =  new List<string>();

            for (var numero = 1; numero <= count; numero++)
            {
                if (EsDivisibleTres(numero))
                    lista.Add("Fizz");
                else if (EsDivisiblePorCinco(numero))
                    lista.Add("Buzz");
                else
                    lista.Add($"{numero}");
            }
            
            return lista;
        }

        private static bool EsDivisiblePorCinco(int numero)
        {
            return EsDivisiblePor(numero,5);
        }

        private static bool EsDivisiblePor(int numero, int divisor)
        {
            return numero % divisor == 0;
        }

        private static bool EsDivisibleTres(int numero)
        {
            return EsDivisiblePor(numero, 3);
        }
    }
}