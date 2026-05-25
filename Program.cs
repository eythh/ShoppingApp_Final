using System;

namespace ShoppingApp_Final
{
    internal class Program
    {
        static string[] userName = new string[10]; // Array to store user names, can be expanded as needed
        static string[] userPassword = new string[10]; // Array to store user passwords, can be expanded as needed
        static string[] fullName = new string[10]; // Array to store full names, can be expanded as needed

        static int userCount = 0; // Tracks amount of registered users

        static void Main(string[] args)
        {
            int mainChoice;
           
            do
            {
                Console.Clear();

                Console.WriteLine("====================================");
                Console.WriteLine("====Welcome to the Shopping App!====");
                Console.WriteLine("====================================");

                Console.WriteLine("1. User Login");
                Console.WriteLine("2. Login as Admin");
                Console.WriteLine("3. Register New Account");
                Console.WriteLine("4. Exit");

                Console.Write("Please enter your choice: ");

                mainChoice = Convert.ToInt32(Console.ReadLine());

                switch (mainChoice)
                {
                    case 1:
                        UserLogin();
                        break;

                    case 2:
                        Console.WriteLine("Admin Login"); // Placeholder for admin login functionality
                        break;

                    case 3:
                        RegisterScreen();
                        break;

                    case 4:
                        Console.WriteLine("Thank you for shopping with us! Goodbye!"); // Placeholder for exit functionality
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again."); // Placeholder for invalid choice handling
                        break;

                }//end of switch statement

            } while (mainChoice != 4); //end of do-while loop

        }//end of main method

        static bool UserLogin()
        {
            Console.Clear();

            Console.WriteLine("======== User Login ========");

            Console.Write("Username: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            // Search arrays for matching account
            for (int i = 0; i < userCount; i++)
            {
                if (userName[i] == username &&
                    userPassword[i] == password)
                {
                    Console.WriteLine("Login successful.");
                    Console.WriteLine($"Welcome {fullName[i]}");

                    Console.ReadKey();
                    return true;
                }
            }

            Console.WriteLine("Invalid username or password.");
            Console.ReadKey();

            return false;

        }//end of UserLogin method

        public static void RegisterScreen()
        {
            Console.Clear();

            Console.WriteLine("======== Register New Account ========");

            Console.Write("Full Name: ");
            string fullNameInput = Console.ReadLine();

            Console.Write("Username: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            fullName[userCount] = fullNameInput;
            userName[userCount] = username;
            userPassword[userCount] = password;

            userCount++;

            Console.Clear();

            Console.WriteLine("Registration successful. You can now log in with your new account.");
            Console.WriteLine("Press any key to return to the main menu...");

            Console.ReadKey();

        }//end of RegisterScreen method

    }//end of program class

}//end of system/namespace
