namespace Cpsc370Final
{
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

                int input = GetValidInput();
                switch (input)
                {
                    case 1:
                        Display();
                        int choice = GetValidInput();
                        switch (choice)
                        {
                            case 1:
                                Console.Write("Race selected\n");
                                Pause();
                                break;
                            case 2:
                                Console.WriteLine("Spells selected\n");
                                Pause();
                                break;
                            case 3:
                                Console.WriteLine("Feats selected\n");
                                Pause();
                                break;
                            case 0:
                                Console.WriteLine("Exiting display menu...\n");
                                Pause();
                                break;
                            default:
                                Console.WriteLine("Invalid option, please try again.");
                                Pause();
                                break;
                        }
                        break;
                    case 2:
                        DataBase();
                        int option = GetValidInput();
                        switch (option)
                        {
                            case 1:
                                DataBaseAddMenu();
                                int subOption = GetValidInput();
                                switch (subOption)
                                {
                                    case 1:
                                        Console.Write("What spell would you like to add\n");
                                        Pause();
                                        break;
                                    case 2:
                                        Console.WriteLine("What Race would you like to add\n");
                                        Pause();
                                        break;
                                    case 3:
                                        Console.WriteLine("What Feat would you like to add\n");
                                        Pause();
                                        break;
                                    case 0:
                                        Console.WriteLine("Exiting Add menu...\n");
                                        Pause();
                                        break;
                                    default:
                                        Console.WriteLine("Invalid option, please try again.");
                                        Pause();
                                        break;
                                }
                                
                                // Call spell sub menu
                                break;
                            case 2:
                                // Call Race sub menu
                                break;
                            default:
                                Console.WriteLine("Invalid option, please try again.");
                                Pause();
                                break;
                        }
                        break;
                    case 0:
                        exit = Exit();
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        Pause();
                        break;
                }

                Console.WriteLine();
            }
        }

        private static int GetValidInput()
        {
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Invalid input, please enter a valid number.");
            }
            return result;
        }

        private static bool Exit()
        {
            Console.WriteLine("Exiting...");
            return true;
        }

        private static void DataBase()
        {
            Console.WriteLine("Database Menu\n");
            Console.WriteLine("1. Add\n");
            Console.WriteLine("0. Exit\n");
        }

        private static void DataBaseAddMenu()
        {
            Console.WriteLine("Welcome to the Database Add Menu\n");
            Console.WriteLine("1. Spell\n");
            Console.WriteLine("2. Race\n");
            Console.WriteLine("3. Feat\n");
            Console.WriteLine("0. Exit\n");
        }

        private static void Display()
        {
            Console.WriteLine("Welcome to the Display Menu\n");
            Console.WriteLine("What file information would you like to display?\n");
            Console.WriteLine("1. Race");
            Console.WriteLine("2. Spells");
            Console.WriteLine("3. Feats");
            Console.WriteLine("0. Exit");
        }

        private static void mainMenu(User user)
        {
            Console.WriteLine("DND Character Creator: \n");
            Console.WriteLine($"Welcome, {user.UserName}!\n");
            Console.WriteLine("1. User\n");
            Console.WriteLine("2. Database\n");
            Console.WriteLine("0. Exit\n");
            Console.Write("Select an option: ");
        }

        private static void Pause()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
