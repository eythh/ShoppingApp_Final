using System;

namespace ShoppingApp_Final
{
    internal class Cart
    {
        // Properties
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int Quantity { get; set; }

        // Constructor
        public Cart(int productID, string productName, decimal productPrice, int quantity)
        {
            ProductID = productID;
            ProductName = productName;
            ProductPrice = productPrice;
            Quantity = quantity;
        } // End of constructor

        // Method to calculate total price
        public decimal GetTotalPrice()
        {
            return ProductPrice * Quantity;
        } // End of GetTotalPrice method

        // Method to display cart item details
        public void DisplayCartItem()
        {
            Console.WriteLine(
                $"ID: {ProductID} | " +
                $"Product: {ProductName} | " +
                $"Price: ${ProductPrice} | " +
                $"Quantity: {Quantity} | " +
                $"Total: ${GetTotalPrice()}");
        }// End of DisplayCartItem method

    }// End of Cart class
} // This class represents an item in the shopping cart, containing properties for product details and methods to calculate total price and display item information.
