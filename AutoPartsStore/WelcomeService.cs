namespace AutoPartsStore;

public class WelcomeService
{
    private readonly User _currentUser = new();

    public void Welcome()
    {
        Console.WriteLine("Welcome to Auto Part Store!");
        
        ValidateUser();
        ShowOptions();
    }

    //TODO: Implement buying service and accessory options
    private static void ShowOptions()
    {
        ConsoleHighlighter.ColorPrint("What do you want to buy.Please enter number of your choice",
            ConsoleColor.Yellow);
        ConsoleHighlighter.ColorPrint(" 1. Buy detail \n 2. Buy service (Not implemented) \n 3. Buy accessory (Not implemented)", ConsoleColor.Cyan);
        
        GetUserInput();
    }

    private static void GetUserInput()
    {
        while (true)
        {
            var inputChoiceUser = Console.ReadLine();
            if (int.TryParse(inputChoiceUser, out int choice))
            {
                if (choice >= 1 && choice <= 3)
                {
                    ConsoleHighlighter.ColorPrint($"You selected option {choice}", ConsoleColor.Green);

                    break;
                }
                
                Console.WriteLine("Number out of range. Please enter 1, 2, or 3.");
            } else Console.WriteLine("Invalid input. Please enter a number.");
        }
    }

    private void ValidateUser()
    {
        while (true)
        {
            ConsoleHighlighter.ColorPrint("What's your name?", ConsoleColor.Yellow);

            _currentUser.Name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(_currentUser.Name)
                || _currentUser.Name.Any(char.IsDigit)
                || _currentUser.Name.Any(char.IsPunctuation))
                Console.WriteLine("Please, enter your name (only letters)");
            
            break;
        }
    }
}