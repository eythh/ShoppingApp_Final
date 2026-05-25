using System;

namespace ShoppingApp_Final
{
    internal class Program
    {
        static string[] userName = new string[10]; // Array to store user names, can be expanded as needed
        static string[] userPassword = new string[10]; // Array to store user passwords, can be expanded as needed
        static string[] fullName = new string[10]; // Array to store full names, can be expanded as needed

        static int userCount = 0; // Tracks amount of registered users
        static int loggedInUserIndex = -1; // Index of logged-in user in the arrays (-1 = not logged in)

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

        static int FindRegisteredUser(string username, string password)
        {
            for (int i = 0; i < userCount; i++)
            {
                if (userName[i] == username && userPassword[i] == password)
                {
                    return i;
                }
            }

            return -1;
        }

        static bool IsUsernameTaken(string username)
        {
            for (int i = 0; i < userCount; i++)
            {
                if (userName[i] == username)
                {
                    return true;
                }
            }

            return false;
        }

        static bool UserLogin()
        {
            Console.Clear();

            Console.WriteLine("======== User Login ========");

            if (userCount == 0)
            {
                Console.WriteLine("No accounts registered yet. Please register first (option 3). Press enter to return to the main menu.");
                Console.ReadKey();
                return false;
            }

            Console.Write("Username: ");
            string username = Console.ReadLine()?.Trim() ?? ""; // Trim() removes whitespace from the beginning and end of the string

            Console.Write("Password: ");
            string password = Console.ReadLine()?.Trim() ?? ""; // Trim() removes whitespace from the beginning and end of the string

            int matchedIndex = FindRegisteredUser(username, password);

            if (matchedIndex >= 0)
            {
                loggedInUserIndex = matchedIndex;

                Console.WriteLine("Login successful.");
                Console.WriteLine($"Welcome {fullName[loggedInUserIndex]} ({userName[loggedInUserIndex]})");

                Console.ReadKey();
                return true;
            }

            loggedInUserIndex = -1;
            Console.WriteLine("Invalid username or password.");
            Console.ReadKey();

            return false;

        }//end of UserLogin method

        public static void RegisterScreen()
        {
            Console.Clear();

            Console.WriteLine("======== Register New Account ========");

            Console.Write("Full Name: ");
            string fullNameInput = Console.ReadLine()?.Trim() ?? ""; // Trim() removes whitespace from the beginning and end of the string

            Console.Write("Username: ");
            string username = Console.ReadLine()?.Trim() ?? ""; // Trim() removes whitespace from the beginning and end of the string

            Console.Write("Password: ");
            string password = Console.ReadLine()?.Trim() ?? ""; // Trim() removes whitespace from the beginning and end of the string

            if (string.IsNullOrEmpty(fullNameInput) ||
                string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password))
            {
                Console.WriteLine("All fields are required. Registration terminated (◣ _ ◢).");
                Console.ReadKey();
                return;
            }

            if (IsUsernameTaken(username))
            {
                Console.WriteLine("That username is already taken. Please choose another.");
                Console.ReadKey();
                return;
            }

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
