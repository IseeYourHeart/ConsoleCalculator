namespace ConsoleCalculator.Validator;

public class StringOperationValidator
{
    private static readonly string[] OperationsArray = ["1", "2", "3", "4"];
    
    public static bool ValidateStringOperation(string stringOperation)
    {
        if (string.IsNullOrWhiteSpace(stringOperation))
        {
            return false;
        }

        if (!OperationsArray.Contains(stringOperation))
        {
            return false;
        }

        return true;
    }
}