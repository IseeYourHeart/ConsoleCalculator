using ConsoleCalculator.Enums;

namespace ConsoleCalculator.Notifiers;

public class ConsoleNotifier
{
    public static void NotifyToConsole(ConsoleNotifications notify, string message = "")
    {
        switch (notify)
        {
            case ConsoleNotifications.Hello:
                Console.WriteLine("Welcome to Console Calculator!");
                break;

            case ConsoleNotifications.EnterFirstNumber:
                Console.WriteLine("Enter first number:" );
                break;
            
            case ConsoleNotifications.EnterSecondNumber:
                Console.WriteLine("Enter second number: ");
                break;
            
            case ConsoleNotifications.EnterOperation:
                Console.WriteLine("Enter operation (1 = `+`, 2 = `-`, 3 = `*`, 4 = `/`): ");
                break;
                
            case ConsoleNotifications.RepeatCalculations:
                Console.WriteLine("Do you want to repeat calculations?");
                break;

            case ConsoleNotifications.ShowResult:
                Console.WriteLine($"Result: {message}");
                break;
        }
    }
}