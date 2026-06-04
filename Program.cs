using System;
using System.Collections.Generic;

namespace ShoppingApp_Final
{
    internal class Program
    {
        static List<Customer> customers = new List<Customer>(); // List to store registered customers
        static string adminUsername = "admin"; // Stores the admin username
        static string adminPassword = "admin"; // Stores the admin password

        static List<Product> products = new List<Product>
        {
            new Product(1, "Beanie", "Clothing", 19.99m, 25),
            new Product(2, "Hoodie", "Clothing", 69.99m, 15),
            new Product(3, "Shirt", "Clothing", 34.99m, 30),
            new Product(4, "Long Sleeve", "Clothing", 44.99m, 20),
            new Product(5, "Pants", "Clothing", 59.99m, 18),
            new Product(6, "Shorts", "Clothing", 39.99m, 22),
            new Product(7, "Socks", "Clothing", 12.99m, 40),
            new Product(8, "Hat", "Clothing", 24.99m, 25),
            new Product(9, "Dress", "Clothing", 79.99m, 10),
            new Product(10, "Sweatpants/Joggers", "Clothing", 64.99m, 16)
        }; // List to store products

        static int nextProductId = 11; // Next ID to assign when adding a product

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
                        if (UserLogin()) // Opens the customer menu after a successful customer login
                        {
                            CustomerMenu();
                        }
                        break;

                    case 2:
                        if (AdminLogin()) // Only opens the admin menu when the admin username and password are correct
                        {
                            AdminMenu(); // Calls the AdminMenu method to display the admin menu and handle admin functionality
                        }
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
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].Username == username && customers[i].Password == password)
                {
                    return i;
                }
            }

            return -1;
        }//end of FindRegisteredUser method

        static bool IsUsernameTaken(string username)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].Username == username)
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

            if (customers.Count == 0)
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
                Console.WriteLine($"Welcome {customers[loggedInUserIndex].FullName} ({customers[loggedInUserIndex].Username})");
                return true;
            }

            loggedInUserIndex = -1;
            Console.WriteLine("Invalid username or password.");
            Console.ReadLine();

            return false;

        }//end of UserLogin method

        static bool AdminLogin()
        {
            Console.Clear();

            Console.WriteLine("======== Admin Login ========");

            Console.Write("Username: ");
            string username = Console.ReadLine()?.Trim() ?? ""; // Trim() removes whitespace from the beginning and end of the string

            Console.Write("Password: ");
            string password = Console.ReadLine()?.Trim() ?? ""; // Trim() removes whitespace from the beginning and end of the string

            if (username == adminUsername && password == adminPassword)
            {
                Console.WriteLine("Admin login successful.");
                return true;
            }

            Console.WriteLine("Invalid admin username or password.");
            Console.WriteLine("Press Enter to return to the main menu...");
            Console.ReadLine();

            return false;
        }//end of AdminLogin method

        public static void CustomerMenu()
        {
            int customerChoice;

            do
            {
                Console.Clear();
                Console.WriteLine("====================================");
                Console.WriteLine("=== Welcome to the Customer Menu ===");
                Console.WriteLine("====================================");
                Console.WriteLine("1. Display Products");
                Console.WriteLine("2. Search Product");
                Console.WriteLine("3. Add Product to Cart");
                Console.WriteLine("4. View Cart");
                Console.WriteLine("5. Logout");

                Console.Write("Please enter your choice: ");

                string customerChoiceInput = Console.ReadLine()?.Trim() ?? "";

                if (!int.TryParse(customerChoiceInput, out customerChoice))
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 5.");
                    Console.WriteLine("Press Enter to return to the Customer Menu...");
                    Console.ReadLine();
                    continue;
                }

                switch (customerChoice)
                {
                    case 1:
                        DisplayProducts();
                        Console.WriteLine("Press Enter to return to the Customer Menu...");
                        Console.ReadLine();
                        break;

                    case 2:
                        SearchProduct();
                        Console.WriteLine("Press Enter to return to the Customer Menu...");
                        Console.ReadLine();
                        break;

                    case 3:
                        AddProductToCart();
                        Console.WriteLine("Press Enter to return to the Customer Menu...");
                        Console.ReadLine();
                        break;

                    case 4:
                        ViewCart();
                        Console.WriteLine("Press Enter to return to the Customer Menu...");
                        Console.ReadLine();
                        break;

                    case 5:
                        loggedInUserIndex = -1;
                        Console.WriteLine("Logging out and returning to the main menu...");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please choose between 1 and 5.");
                        Console.WriteLine("Press Enter to return to the Customer Menu...");
                        Console.ReadLine();
                        break;
                }

            } while (customerChoice != 5);

        }//end of CustomerMenu method

        public static void AdminMenu()
        {
            int adminChoice;

            do
            {
                Console.Clear();
                Console.WriteLine("====================================");
                Console.WriteLine("==== Welcome to the Admin Menu =====");
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
                        DisplayProducts();
                        Console.WriteLine("Press Enter to return to the Admin Menu...");
                        Console.ReadLine();
                        break;

                    case 2:
                        AddProduct();
                        Console.WriteLine("Press Enter to return to the Admin Menu...");
                        Console.ReadLine();
                        break;

                    case 3:
                        UpdateProduct();
                        Console.WriteLine("Press Enter to return to the Admin Menu...");
                        Console.ReadLine();
                        break;

                    case 4:
                        RemoveProduct();
                        Console.WriteLine("Press Enter to return to the Admin Menu...");
                        Console.ReadLine();
                        break;

                    case 5:
                        SearchProduct();
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

            Customer newCustomer = new Customer(fullNameInput, username, password);
            customers.Add(newCustomer);

            Console.Clear();

            Console.WriteLine("Registration successful. You can now log in with your new account.");
            Console.WriteLine("Press Enter to return to the main menu...");

            Console.ReadLine();

        }//end of RegisterScreen method

        static int FindProductIndex(int productId)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].ProductId == productId)
                {
                    return i;
                }
            }

            return -1;
        }//end of FindProductIndex method

        static void DisplayProducts()
        {
            Console.Clear();
            Console.WriteLine("======== Display Products ========");

            if (products.Count == 0)
            {
                Console.WriteLine("No products in the catalog yet.");
                return;
            }

            for (int i = 0; i < products.Count; i++)
            {
                products[i].DisplayProductDetails();
            }
        }//end of DisplayProducts method

        static void AddProduct()
        {
            Console.Clear();
            Console.WriteLine("======== Add Product ========");

            Console.Write("Product Name: ");
            string name = Console.ReadLine()?.Trim() ?? "";

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Product name cannot be blank.");
                return;
            }

            Console.Write("Category: ");
            string category = Console.ReadLine()?.Trim() ?? "";

            if (string.IsNullOrEmpty(category))
            {
                Console.WriteLine("Category cannot be blank.");
                return;
            }

            Console.Write("Price: ");
            string priceInput = Console.ReadLine()?.Trim() ?? "";

            if (!decimal.TryParse(priceInput, out decimal price) || price <= 0)
            {
                Console.WriteLine("Invalid price. Please enter a number greater than 0.");
                return;
            }

            Console.Write("Stock: ");
            string stockInput = Console.ReadLine()?.Trim() ?? "";

            if (!int.TryParse(stockInput, out int stock) || stock < 0)
            {
                Console.WriteLine("Invalid stock. Please enter a whole number of 0 or more.");
                return;
            }

            Product newProduct = new Product(nextProductId, name, category, price, stock);

            products.Add(newProduct);
            nextProductId++;

            Console.WriteLine($"Product added successfully (ID: {newProduct.ProductId}).");
        }//end of AddProduct method

        static void AddProductToCart()
        {
            Console.Clear();
            Console.WriteLine("======== Add Product to Cart ========");

            if (loggedInUserIndex < 0 || loggedInUserIndex >= customers.Count)
            {
                Console.WriteLine("No customer is logged in.");
                return;
            }

            if (products.Count == 0)
            {
                Console.WriteLine("No products are available to add to cart.");
                return;
            }

            Console.Write("Enter Product ID to add to cart: ");
            string idInput = Console.ReadLine()?.Trim() ?? "";

            if (!int.TryParse(idInput, out int productId))
            {
                Console.WriteLine("Invalid product ID. Please enter a valid number.");
                return;
            }

            int index = FindProductIndex(productId);

            if (index < 0)
            {
                Console.WriteLine($"No product found with ID {productId}.");
                return;
            }

            Product product = products[index];

            if (product.Stock <= 0)
            {
                Console.WriteLine($"{product.Name} is out of stock.");
                return;
            }

            Console.Write("Quantity: ");
            string quantityInput = Console.ReadLine()?.Trim() ?? "";

            if (!int.TryParse(quantityInput, out int quantity) || quantity <= 0)
            {
                Console.WriteLine("Invalid quantity. Please enter a whole number greater than 0.");
                return;
            }

            if (quantity > product.Stock)
            {
                Console.WriteLine($"Not enough stock. Only {product.Stock} available.");
                return;
            }

            Customer customer = customers[loggedInUserIndex];
            Cart existingCartItem = null;

            for (int i = 0; i < customer.CartItems.Count; i++)
            {
                if (customer.CartItems[i].ProductID == product.ProductId)
                {
                    existingCartItem = customer.CartItems[i];
                    break;
                }
            }

            if (existingCartItem != null && existingCartItem.Quantity + quantity > product.Stock)
            {
                Console.WriteLine($"Not enough stock. You already have {existingCartItem.Quantity} in your cart and only {product.Stock} are available.");
                return;
            }

            if (existingCartItem != null)
            {
                existingCartItem.Quantity += quantity;
            }
            else
            {
                Cart cartItem = new Cart(product.ProductId, product.Name, product.Price, quantity);
                customer.CartItems.Add(cartItem);
            }

            Console.WriteLine($"{quantity} {product.Name}(s) added to cart.");
        }//end of AddProductToCart method

        static void ViewCart() // Displays the contents of the customer's cart, calculates the total price, and offers the option to proceed to checkout
{
    Console.Clear();
    Console.WriteLine("===========================");
    Console.WriteLine("======== View Cart ========");
    Console.WriteLine("===========================");

    if (loggedInUserIndex < 0 || loggedInUserIndex >= customers.Count) // Checks if a customer is logged in by verifying that the loggedInUserIndex is in the customers list. If not, it displays a message and returns to the Customer Menu.
    {
        Console.WriteLine("No customer is logged in.");
        return;
    } 

    Customer customer = customers[loggedInUserIndex]; // Retrieves the currently logged-in customer from the customers list using the loggedInUserIndex. This lets the method access the customer's cart items and display them.

    if (customer.CartItems.Count == 0)
    {
        Console.WriteLine("Your cart is currently empty.");
        return;
    }

    decimal cartTotal = 0;

    for (int i = 0; i < customer.CartItems.Count; i++) // Loops through each item in the customer's cart and displays its details using the DisplayCartItem method. It also calculates the total price of the cart by summing the total price of each cart item using the GetTotalPrice method.
    {
        customer.CartItems[i].DisplayCartItem();
        cartTotal += customer.CartItems[i].GetTotalPrice();
    }

    Console.WriteLine("------------------------------");
    Console.WriteLine($"Cart Total: ${cartTotal}");
    Console.WriteLine();
    Console.Write("Would you like to checkout? (yes/no): ");

    string checkoutChoice = Console.ReadLine()?.Trim().ToLower() ?? ""; // Reads the user's input for whether they want to proceed to checkout, trims any whitespace, converts it to lowercase for easier comparison, and checks if the input is "yes" or "y". 

    if (checkoutChoice == "yes" || checkoutChoice == "y")
    {
        Checkout();
    }
    else
    {
        Console.WriteLine("Checkout cancelled. Returning to the Customer Menu.");
    }
}//end of ViewCart method

static void Checkout() // Checkout method that processes the customer's order, checks for stock availability, updates product stock, clears the cart, and displays confirmation message
{
    Console.Clear();
    Console.WriteLine("==========================");
    Console.WriteLine("======== Checkout ========");
    Console.WriteLine("==========================");

    if (loggedInUserIndex < 0 || loggedInUserIndex >= customers.Count) // Checks if a customer is logged in by verifying that the loggedInUserIndex is in the customers list. If not, it displays a message and returns to the Customer Menu.
    {
        Console.WriteLine("No customer is logged in.");
        return;
    }

    Customer customer = customers[loggedInUserIndex]; // Retrieves the currently logged-in customer from the customers list using the loggedInUserIndex. This lets the method access the customer's cart items and process the checkout.

    if (customer.CartItems.Count == 0) // Checks if the customer's cart is empty. If it is, it displays a message and returns to the Customer Menu.
    {
        Console.WriteLine("Your cart is empty. There is nothing to checkout.");
        return;
    }

    decimal orderTotal = 0;

    for (int i = 0; i < customer.CartItems.Count; i++) // Loops through each item in the customer's cart to check if the products are still available and if there is enough stock to fulfill the order. If any product is not available or does not have enough stock, it cancels the checkout process and returns to the Customer Menu.
    {
        Cart cartItem = customer.CartItems[i];
        int productIndex = FindProductIndex(cartItem.ProductID);

        if (productIndex < 0) 
        {
            Console.WriteLine($"Product {cartItem.ProductName} is no longer available.");
            Console.WriteLine("Checkout cancelled.");
            return;
        }

        Product product = products[productIndex];

        if (cartItem.Quantity > product.Stock) // Checks if the quantity of the cart item exceeds the available stock of the product. If it does, it displays a message indicating that there is not enough stock, shows how many items are in the cart and how many are available, cancels the checkout process, and returns to the Customer Menu.
        {
            Console.WriteLine($"Not enough stock for {product.Name}.");
            Console.WriteLine($"In cart: {cartItem.Quantity}");
            Console.WriteLine($"Available stock: {product.Stock}");
            Console.WriteLine("Checkout cancelled.");
            return;
        }

        orderTotal += cartItem.GetTotalPrice();
    }

    for (int i = 0; i < customer.CartItems.Count; i++) // If all products are available and have enough stock, it loops through the cart items again to deduct the purchased quantities from the product stock. After updating the stock, it clears the customer's cart and displays a confirmation message with the order total.
    {
        Cart cartItem = customer.CartItems[i];
        int productIndex = FindProductIndex(cartItem.ProductID);

        products[productIndex].Stock -= cartItem.Quantity;
    }

    customer.CartItems.Clear(); // Clears the customer's cart after successfully processing the order

    Console.WriteLine("Order confirmed.");
    Console.WriteLine($"Order Total: ${orderTotal}");
    Console.WriteLine("Thank you for your purchase.");
}//end of Checkout method
        static void UpdateProduct()
        {
            Console.Clear();
            Console.WriteLine("======== Update Product ========");

            if (products.Count == 0)
            {
                Console.WriteLine("No products to update.");
                return;
            }

            Console.Write("Enter Product ID to update: ");
            string idInput = Console.ReadLine()?.Trim() ?? "";

            if (!int.TryParse(idInput, out int productId))
            {
                Console.WriteLine("Invalid product ID. Please enter a valid number.");
                return;
            }

            int index = FindProductIndex(productId);

            if (index < 0)
            {
                Console.WriteLine($"No product found with ID {productId}.");
                return;
            }

            Product product = products[index];

            Console.WriteLine($"Updating: {product.Name} (ID: {product.ProductId})");
            Console.WriteLine("(Press Enter to keep the current value)");

            string updatedName = product.Name;
            string updatedCategory = product.Category;
            decimal updatedPrice = product.Price;
            int updatedStock = product.Stock;

            Console.Write($"Name [{product.Name}]: ");
            string nameInput = Console.ReadLine()?.Trim() ?? "";
            if (!string.IsNullOrEmpty(nameInput))
            {
                updatedName = nameInput;
            }

            Console.Write($"Category [{product.Category}]: ");
            string categoryInput = Console.ReadLine()?.Trim() ?? "";
            if (!string.IsNullOrEmpty(categoryInput))
            {
                updatedCategory = categoryInput;
            }

            Console.Write($"Price [{product.Price:C}]: ");
            string priceInput = Console.ReadLine()?.Trim() ?? "";
            if (!string.IsNullOrEmpty(priceInput))
            {
                decimal priceCheck;

                if (!decimal.TryParse(priceInput, out priceCheck) || priceCheck <= 0)
                {
                    Console.WriteLine("Invalid price. Update cancelled.");
                    return;
                }

                updatedPrice = priceCheck;
            }

            Console.Write($"Stock [{product.Stock}]: ");
            string stockInput = Console.ReadLine()?.Trim() ?? "";
            if (!string.IsNullOrEmpty(stockInput))
            {
                int stockCheck;

                if (!int.TryParse(stockInput, out stockCheck) || stockCheck < 0)
                {
                    Console.WriteLine("Invalid stock. Update cancelled.");
                    return;
                }

                updatedStock = stockCheck;
            }

            product.UpdateProductDetails(updatedName, updatedCategory, updatedPrice, updatedStock);

            Console.WriteLine($"Product ID {product.ProductId} updated successfully.");
        }//end of UpdateProduct method

        static void RemoveProduct()
        {
            Console.Clear();
            Console.WriteLine("======== Remove Product ========");

            if (products.Count == 0)
            {
                Console.WriteLine("No products to remove.");
                return;
            }

            Console.Write("Enter Product ID to remove: ");
            string idInput = Console.ReadLine()?.Trim() ?? "";

            if (!int.TryParse(idInput, out int productId))
            {
                Console.WriteLine("Invalid product ID. Please enter a valid number.");
                return;
            }

            int index = FindProductIndex(productId);

            if (index < 0)
            {
                Console.WriteLine($"No product found with ID {productId}.");
                return;
            }

            string removedName = products[index].Name;
            products.RemoveAt(index);

            Console.WriteLine($"Product \"{removedName}\" (ID: {productId}) removed successfully.");
        }//end of RemoveProduct method

        static void SearchProduct()
        {
            Console.Clear();
            Console.WriteLine("======== Search Product ========");

            if (products.Count == 0)
            {
                Console.WriteLine("No products to search.");
                return;
            }

            Console.Write("Enter search term (name or category): ");
            string searchTerm = Console.ReadLine()?.Trim() ?? "";

            if (string.IsNullOrEmpty(searchTerm))
            {
                Console.WriteLine("Search term cannot be blank.");
                return;
            }

            bool foundAny = false;

            string searchTermLower = searchTerm.ToLower();

            Console.WriteLine();
            Console.WriteLine($"Results for \"{searchTerm}\":");

            for (int i = 0; i < products.Count; i++)
            {
                Product p = products[i];

                if (p.Name.ToLower().Contains(searchTermLower) ||
                    p.Category.ToLower().Contains(searchTermLower))
                {
                    p.DisplayProductDetails();
                    foundAny = true;
                }
            }

            if (!foundAny)
            {
                Console.WriteLine("No products matched your search.");
            }
        }//end of SearchProduct method

    }//end of program class

}//end of system/namespace
