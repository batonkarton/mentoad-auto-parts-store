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

    private static void ShowOptions()
    {
        Console.WriteLine("What do you want to buy.Please enter number of your choice");
        Console.WriteLine(" 1. Buy detail \n 2. Buy service \n 3. Buy accessory");
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
                    Console.WriteLine($"You selected option {choice}");
                    break;
                }

                Console.WriteLine("Number out of range. Please enter 1, 2, or 3.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }

    private void ValidateUser()
    {
        while (true)
        {
            Console.WriteLine("What's your name?");
            _currentUser.Name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(_currentUser.Name)
                || _currentUser.Name.Any(char.IsDigit)
                || _currentUser.Name.Any(char.IsPunctuation))
                Console.WriteLine("Please, enter your name (only letters)");
            else
            {
                break;
            }
        }
    }
}