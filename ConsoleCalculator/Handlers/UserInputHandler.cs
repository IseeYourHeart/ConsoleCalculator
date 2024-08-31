namespace ConsoleCalculator.Handlers;

public class UserInputHandler
{
    public static string? GetUserInput()
    {
        var userStringInput = Console.ReadLine();
        return userStringInput;
    }
}