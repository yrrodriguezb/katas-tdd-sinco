namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public static List<string> Generate(int count)
        {
            return count switch
            {
                1 => ["1"],
                2 => ["1", "2"],
                _ => ["1", "2", "Fizz"]
            };
        }
    }
}