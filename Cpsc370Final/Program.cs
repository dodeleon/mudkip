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
                    databaseManipulation();
                    break;
                case "3":
                    userFavorites();
                    break;
                case "4":
                    userDefinedClassification();
                    break;
                case "5":
                    search();
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

    private static void search()
    {
        Console.WriteLine("Search\n");
        // Add your code for Option 5 here
        Pause();
    }

    private static void userDefinedClassification()
    {
        Console.WriteLine("User-defined classifications\n");
        // Add your code for Option 4 here
        Pause();
    }

    private static void userFavorites()
    {
        Console.WriteLine("Favorites\n");
        // Add your code for Option 3 here
        Pause();
    }

    private static void databaseManipulation()
    {
        Console.WriteLine("Database Manipulation\n");
        // Add your code for Option 2 here
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
        Console.WriteLine("1. User\n");
        Console.WriteLine("2. Database Manipulation\n");
        Console.WriteLine("3. Favorites\n");
        Console.WriteLine("4. User-Defined Classifications\n");
        Console.WriteLine("5. Search\n");
        Console.WriteLine("0. Exit\n");
        Console.Write("Select an option: ");
    }

    private static void Pause()
    {
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
