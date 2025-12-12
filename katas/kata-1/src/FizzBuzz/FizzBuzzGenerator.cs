namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public static List<string> Generate(int count)
        {
            if (count < 1)
            {
                throw new ArgumentException("Debe ingresar un numero mayor a cero");
            }
            
            var lista =  new List<string>();

            for (var numero = 1; numero <= count; numero++)
            {
                if (EsDivisiblePorQuince(numero))
                    lista.Add("FizzBuzz");
                else if (EsDivisibleTres(numero))
                    lista.Add("Fizz");
                else if (EsDivisiblePorCinco(numero))
                    lista.Add("Buzz");
                else
                    lista.Add($"{numero}");
            }
            
            return lista;
        }

        private static bool EsDivisiblePorQuince(int numero) => EsDivisiblePor(numero, 15);

        private static bool EsDivisiblePorCinco(int numero) => EsDivisiblePor(numero,5);

        private static bool EsDivisiblePor(int numero, int divisor) => numero % divisor == 0;

        private static bool EsDivisibleTres(int numero) => EsDivisiblePor(numero, 3);
    }
}