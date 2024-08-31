using ConsoleCalculator.Converters;
using ConsoleCalculator.Enums;
using ConsoleCalculator.Handlers;
using ConsoleCalculator.Notifiers;
using ConsoleCalculator.Validator;

namespace ConsoleCalculator.Managers.OperatorManager
{
    internal class OperatorProcessingManager
    {
        public static CheckedAndConvertedOperator GetOperator()
        {
            ConsoleNotifier.NotifyToConsole(ConsoleNotifications.EnterOperation);
            var operationStringInput = UserInputHandler.GetUserInput();

            var operatorIsCorrect = StringOperationValidator.ValidateStringOperation(operationStringInput);
            if (!operatorIsCorrect)
            {
                ConsoleErrorNotifier.NotifyError(Errors.OperatorIsNotCorrect, operationStringInput);
                var invalidOperator = new CheckedAndConvertedOperator(default, false);

                return invalidOperator;
            }
            var convertedOperator = OperatorConverter.GetMathOperation(operationStringInput);
            var checkedAndCorvertedOperator = new CheckedAndConvertedOperator(convertedOperator, true);

            return checkedAndCorvertedOperator;
        }
    }
}
