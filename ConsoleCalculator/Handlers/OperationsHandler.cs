using ConsoleCalculator.Enums;
using ConsoleCalculator.Notifiers;

namespace ConsoleCalculator.Handlers;

public class OperationsHandler
{
    public static int CalculateOperationResult(int firstNumber, int secondNumber, MathOperations operation)
    {
        var result = operation switch
        {
            MathOperations.Addition => Addition(firstNumber, secondNumber),
            MathOperations.Subtraction => Subtraction(firstNumber, secondNumber),
            MathOperations.Multiplication => Multiplication(firstNumber, secondNumber),
            MathOperations.Division => Division(firstNumber, secondNumber),
        };

        return result;
    }
    
    private static int Addition(int firstNumber, int secondNumber)
    {
        var result = firstNumber + secondNumber;
        
        return result;
    }

    private static int Subtraction(int firstNumber, int secondNumber)
    {
        var result = firstNumber - secondNumber;
        
        return result;
    }

    private static int Multiplication(int firstNumber, int secondNumber)
    {
        var result = firstNumber * secondNumber;
        
        return result;
    }

    private static int Division(int firstNumber, int secondNumber)
    {
        if (secondNumber == 0)
        {
            ConsoleErrorNotifier.NotifyError(Errors.CantDivideByZero);
            return 0;
        }
        var result = firstNumber / secondNumber;

        return result;
        
    }
}