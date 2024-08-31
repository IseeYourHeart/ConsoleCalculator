using ConsoleCalculator.Notifiers;
using ConsoleCalculator.Enums;
using ConsoleCalculator.Handlers;
using ConsoleCalculator.Managers.NumberManager;
using ConsoleCalculator.Managers.OperatorManager;

namespace ConsoleCalculator.Models;

public class Calculator
{
    public static void Run()
    {
        var isContinue = true;
        while (isContinue)
        {
            ConsoleNotifier.NotifyToConsole(ConsoleNotifications.Hello);

            var firstNumber = NumberProcessingManager.GetNumber(ConsoleNotifications.EnterFirstNumber);
            if (!firstNumber.IsConverted)
            {
                continue;
            }

            var operation = OperatorProcessingManager.GetOperator();
            if (!operation.IsConverted)
            {
                continue;
            }

            var secondNumber = NumberProcessingManager.GetNumber(ConsoleNotifications.EnterSecondNumber);
            if (!secondNumber.IsConverted)
            {
                continue;
            }

            var result = OperationsHandler.CalculateOperationResult(firstNumber.Number, secondNumber.Number, operation.Operation);
            ConsoleNotifier.NotifyToConsole(ConsoleNotifications.ShowResult, result.ToString());

            ConsoleNotifier.NotifyToConsole(ConsoleNotifications.RepeatCalculations);
            var isContinueStringInput = UserInputHandler.GetUserInput();
            if (isContinueStringInput != "y" && isContinueStringInput != "Y")
            {
                isContinue = false;
            }
        }
    }
}