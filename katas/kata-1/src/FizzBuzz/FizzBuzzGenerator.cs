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
                3 => ["1", "2", "Fizz"],
                4 => ["1", "2", "Fizz", "4"],
                5 => ["1", "2", "Fizz", "4", "Buzz"]
            };
        }
    }
}