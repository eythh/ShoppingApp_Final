using System;
namespace ShoppingApp_Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mainChoice;

            do
            {
                Console.Clear();
                Console.WriteLine("====================================");
                Console.WriteLine("====Welcome to the Shopping App!====");
                Console.WriteLine("====================================");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Admin Login");
                Console.WriteLine("3. Register");
                Console.WriteLine("4. Exit");
                Console.Write("Please enter your choice: ");
                mainChoice = Convert.ToInt32(Console.ReadLine());

                switch (mainChoice)
                {
                    case 1:
                        Console.WriteLine("User Login"); // Placeholder for user login functionality
                        break;
                    case 2:
                        Console.WriteLine("Admin Login"); // Placeholder for admin login functionality
                        break;
                    case 3:
                        Console.WriteLine("Register"); // Placeholder for registration functionality
                        break;
                    case 4:
                        Console.WriteLine("Thank you for shopping with us! Goodbye!"); // Placeholder for exit functionality
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again."); // Placeholder for invalid choice handling
                        break;
                }//end of switch statement
            } while (mainChoice != 4); //end of do-while loop



        }//end of main method
    }//end of program class
}//end of system/namepsace