using System.Collections.Generic;

namespace ShoppingApp_Final
{
    internal class Customer // Class representing a registered customer account
    {
        public string FullName { get; set; } = "";
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
        public List<Cart> CartItems { get; set; } = new List<Cart>();

        public Customer(string fullName, string username, string password) // Constructor to initialize customer details
        {
            FullName = fullName;
            Username = username;
            Password = password;
        }//end of Customer constructor

    }//end of Customer class

}//end of namespace
