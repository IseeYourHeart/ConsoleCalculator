using ConsoleCalculator.Enums;

namespace ConsoleCalculator.Converters
{
    internal class OperatorConverter
    {
        public static MathOperations GetMathOperation(string? stringOperation)
        {
            var operation = Enum.Parse<MathOperations>(stringOperation);
            return operation;
        }
    }
}
