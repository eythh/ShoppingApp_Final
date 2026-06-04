using System;

namespace ShoppingApp_Final
{
    internal class Cart // Class representing an item in the shopping cart
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int Quantity { get; set; }

        public Cart(int productID, string productName, decimal productPrice, int quantity) // Constructor to initialize cart item
        {
            ProductID = productID;
            ProductName = productName;
            ProductPrice = productPrice;
            Quantity = quantity;
        }//end of Cart constructor

        public decimal GetTotalPrice() // Method to calculate total price for the cart item
        {
            return ProductPrice * Quantity;
        }//end of GetTotalPrice method

        public void DisplayCartItem() // Method to display cart item details
        {
            Console.WriteLine(
                $"ID: {ProductID} | " +
                $"Product: {ProductName} | " +
                $"Price: ${ProductPrice} | " +
                $"Quantity: {Quantity} | " +
                $"Total: ${GetTotalPrice()}");
        }//end of DisplayCartItem method

    }//end of Cart class

}//end of namespace
