using System;
using System.Collections.Generic;

namespace ShoppingApp_Final
{
    internal class Program
    {
        static List<string> userName = new List<string>(); // List to store user names
        static List<string> userPassword = new List<string>(); // List to store user passwords
        static List<string> fullName = new List<string>(); // List to store full names

        static int userCount = 0; // Tracks amount of registered users
        static int loggedInUserIndex = -1; // Index of logged-in user in the lists (-1 = not logged in)

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

                string mainChoiceInput = Console.ReadLine()?.Trim() ?? "";

                if (!int.TryParse(mainChoiceInput, out mainChoice))
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 4.");
                    Console.WriteLine("Press Enter to return to the main menu...");
                    Console.ReadLine();
                    continue;
                }

                switch (mainChoice)
                {
                    case 1:
                        UserLogin(); // Calls the UserLogin method to handle user login functionality
                        break;

                    case 2:
                        AdminMenu(); // Calls the AdminMenu method to display the admin menu and handle admin functionality
                        break;

                    case 3:
                        RegisterScreen(); // Calls the RegisterScreen method to display the registration screen and handle new user registration functionality
                        break;

                    case 4:
                        Console.WriteLine("Thank you for shopping with us! Goodbye!"); // Displays a goodbye message to the user before exiting the application
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number from 1 to 4.");
                        Console.WriteLine("Press Enter to return to the main menu...");
                        Console.ReadLine();
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
        }//end of FindRegisteredUser method

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
        }//end of IsUsernameTaken method

        static bool UserLogin()
        {
            Console.Clear();

            Console.WriteLine("======== User Login ========");

            if (userCount == 0)
            {
                Console.WriteLine("No accounts registered yet. Please register first (option 3). Press Enter to return to the main menu.");
                Console.ReadLine();
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

                Console.ReadLine();
                return true;
            }

            loggedInUserIndex = -1;
            Console.WriteLine("Invalid username or password.");
            Console.ReadLine();

            return false;

        }//end of UserLogin method

        public static void AdminMenu()
        {
            int adminChoice;

            do
            {
                Console.Clear();
                Console.WriteLine("====================================");
                Console.WriteLine("======== Welcome, Admin! ==========");
                Console.WriteLine("====================================");
                Console.WriteLine("============ Admin Menu ============");
                Console.WriteLine("====================================");
                Console.WriteLine("1. Display Products");
                Console.WriteLine("2. Add Product");
                Console.WriteLine("3. Update Product");
                Console.WriteLine("4. Remove Product");
                Console.WriteLine("5. Search Product");
                Console.WriteLine("6. Logout");

                Console.Write("Please enter your choice: ");

                string adminChoiceInput = Console.ReadLine()?.Trim() ?? ""; // Trim() removes whitespace from the beginning and end of the string same as strip in python

                if (!int.TryParse(adminChoiceInput, out adminChoice)) // TryParse attempts to convert the input to an integer and returns true if successful, false otherwise. The result is stored in adminChoice.
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 6.");
                    Console.WriteLine("Press Enter to return to the Admin Menu...");
                    Console.ReadLine();
                    continue; // Skip the rest of the loop and start the next iteration, which will re-display the admin menu
                }

                switch (adminChoice)
                {
                    case 1:
                        Console.WriteLine("Display Products screen will go here.");
                        Console.WriteLine("Press Enter to return to the Admin Menu...");
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.WriteLine("Add Product screen will go here.");
                        Console.WriteLine("Press Enter to return to the Admin Menu...");
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.WriteLine("Update Product screen will go here.");
                        Console.WriteLine("Press Enter to return to the Admin Menu...");
                        Console.ReadLine();
                        break;

                    case 4:
                        Console.WriteLine("Remove Product screen will go here.");
                        Console.WriteLine("Press Enter to return to the Admin Menu...");
                        Console.ReadLine();
                        break;

                    case 5:
                        Console.WriteLine("Search Product screen will go here.");
                        Console.WriteLine("Press Enter to return to the Admin Menu...");
                        Console.ReadLine();
                        break;

                    case 6:
                        Console.WriteLine("Logging out and returning to the main menu...");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please choose between 1 and 6.");
                        Console.WriteLine("Press Enter to return to the Admin Menu...");
                        Console.ReadLine();
                        break;
                }

            } while (adminChoice != 6); // Continue showing the admin menu until the admin chooses to logout (option 6)

        }//end of AdminMenu method

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
                Console.ReadLine();
                return;
            }

            if (IsUsernameTaken(username))
            {
                Console.WriteLine("That username is already taken. Please choose another.");
                Console.ReadLine();
                return;
            }

            fullName.Add(fullNameInput);
            userName.Add(username);
            userPassword.Add(password);

            userCount++;

            Console.Clear();

            Console.WriteLine("Registration successful. You can now log in with your new account.");
            Console.WriteLine("Press Enter to return to the main menu...");

            Console.ReadLine();

        }//end of RegisterScreen method

    }//end of program class

}//end of system/namespace
