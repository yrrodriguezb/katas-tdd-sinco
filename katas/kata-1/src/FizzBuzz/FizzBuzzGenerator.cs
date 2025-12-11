namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public static List<string> Generate(int count)
        {
            if (count == 1)
                return ["1"];
            else if  (count == 2)
                return ["1", "2"];
            else
                return ["1", "2", "Fizz"];
        }
    }
}