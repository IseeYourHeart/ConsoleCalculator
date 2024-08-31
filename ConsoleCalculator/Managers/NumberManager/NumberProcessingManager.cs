using ConsoleCalculator.Converters;
using ConsoleCalculator.Enums;
using ConsoleCalculator.Handlers;
using ConsoleCalculator.Notifiers;
using ConsoleCalculator.Validator;

namespace ConsoleCalculator.Managers.NumberManager
{
    internal class NumberProcessingManager
    {
        public static CheckedAndConvertedNumber GetNumber(ConsoleNotifications ordinalNumber)
        {
            ConsoleNotifier.NotifyToConsole(ordinalNumber);
            var firstNumberStringInput = UserInputHandler.GetUserInput();

            var firstNumberIsCorrect = StringNumberValidator.ValidateStringNumber(firstNumberStringInput);
            if (!firstNumberIsCorrect)
            {
                ConsoleErrorNotifier.NotifyError(Errors.NumberIsNotCorrect, firstNumberStringInput);
                var NotCorrectNumber = new CheckedAndConvertedNumber(default, false);

                return NotCorrectNumber;
            }
            var firstNumberConverted = NumberConverter.GetNumber(firstNumberStringInput);
            var ConvertedNumber = new CheckedAndConvertedNumber(firstNumberConverted, true);

            return ConvertedNumber;
        }
    }
}
