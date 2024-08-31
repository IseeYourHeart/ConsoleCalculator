using ConsoleCalculator.Enums;

namespace ConsoleCalculator.Notifiers;

public class ConsoleErrorNotifier
{
    public static void NotifyError(Errors error, string? userInput = "")
    {
        switch (error)
        {
            case Errors.NumberIsNotCorrect:
                Console.WriteLine($"Number {userInput} is not correct ");
                break;

            case Errors.OperatorIsNotCorrect:
                Console.WriteLine($"Operator {userInput} is not correct");
                break;

            case Errors.CantDivideByZero:
                Console.WriteLine("You can't divide by zero");
                break;
        }
    }
        
}