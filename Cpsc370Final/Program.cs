namespace Cpsc370Final;
using System;

class Program 
{ 
    static void Main(string[] args) 
    { 
        Console.Write("Enter your username: ");
        string userName = Console.ReadLine();
        User user = new User(userName);
        bool exit = false;

        while (!exit)
        {
            mainMenu(user);

            string input = Console.ReadLine();
            Console.Clear(); // Clear the screen before showing the next menu
            switch (input)
            {
                case "1":
                    characterCreation();
                    break;
                case "2":
                    DataBase();
                    break;
                case "0":
                    exit = Exit();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid option, please try again.");
                    Pause();
                    break;
            }

            Console.WriteLine();
        }
    }

    private static bool Exit()
    {
        Console.WriteLine("Exiting...");
        return true;
    }

    private static void DataBase()
    {
        Console.WriteLine("Search\n");
        // Add your code for Option 5 here
        Pause();
    }
    
    private static void characterCreation()
    {
        Console.WriteLine("User Menu\n");
        Console.WriteLine("1. Character Creation\n");
        Console.WriteLine("0. Exit\n");
        Pause();
    }

    private static void mainMenu(User user)
    {
        Console.WriteLine("DND Character Creator: \n");
        Console.WriteLine($"Welcome, {user.UserName}!\n");
        Console.WriteLine("1. User Options\n");
        Console.WriteLine("2. DataBase\n");
        Console.WriteLine("0. Exit\n");
        Console.Write("Select an option: ");
    }

    private static void Pause()
    {
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
