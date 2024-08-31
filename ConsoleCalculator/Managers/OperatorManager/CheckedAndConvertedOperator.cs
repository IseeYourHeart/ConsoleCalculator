using ConsoleCalculator.Enums;

namespace ConsoleCalculator.Managers.OperatorManager
{
    internal record class CheckedAndConvertedOperator(MathOperations Operation, bool IsConverted);
}
