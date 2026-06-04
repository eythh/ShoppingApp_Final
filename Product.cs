using System;

namespace ShoppingApp_Final
{
    internal class Product // Class representing a product in the store
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = "";
        public string Category { get; set; } = "";
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public Product(int productId, string name, string category, decimal price, int stock) // Constructor to initialize product details
        {
            ProductId = productId;
            Name = name;
            Category = category;
            Price = price;
            Stock = stock;
        }//end of Product constructor

                public void DisplayProductDetails() // Method to display product details
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Product ID: {ProductId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Price: ${Price}");
            Console.WriteLine($"Stock: {Stock}");
        }//end of DisplayProductDetails method

        public void UpdateProductDetails(string name, string category, decimal price, int stock)
        {
            Name = name;
            Category = category;
            Price = price;
            Stock = stock;
        }//end of UpdateProductDetails method

    }//end of Product class

}//end of namespace
