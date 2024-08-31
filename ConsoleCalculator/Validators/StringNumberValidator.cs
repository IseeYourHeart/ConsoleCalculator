namespace ConsoleCalculator.Validator;

public class StringNumberValidator
{
    public static bool ValidateStringNumber(string? stringNumber)
    {
        if (string.IsNullOrWhiteSpace(stringNumber))
        {
            return false;
        }

        if (!stringNumber.All(char.IsDigit))
        {
            return false;
        }

        return true;
    }
}