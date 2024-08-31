
namespace ConsoleCalculator.Converters
{
    internal class NumberConverter
    {
        public static int GetNumber(string? stringNumber)
        {
            var number = Convert.ToInt32(stringNumber);
            return number;
        }
    }
}
