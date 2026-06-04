# ShoppingApp_Final

A C# console shopping app project with a main menu, account registration, and registered-user login.

What I did | Zach:
- Created the UserLogin() method so registered users can sign in before using customer account features.
- Made UserLogin() return a bool so the program can clearly tell whether a login attempt passed or failed.
- Added a check inside UserLogin() for when no customer accounts have been registered yet.
- Added user login input fields for:
  - Username
  - Password
- Used Trim() and null handling on login inputs so extra spaces or empty console input are handled more safely.
- Added FindRegisteredUser() to search through the registered account lists and match usernames with passwords.
- Made FindRegisteredUser() return the matching user index when the login details are correct.
- Made FindRegisteredUser() return -1 when no registered account matches the entered login details.
- Added loggedInUserIndex to track which registered customer is currently logged in.
- Updated successful customer login so it stores the matched user index and displays the customer's full name and username.
- Updated failed customer login so loggedInUserIndex is reset to -1 and the user is told the username or password was invalid.
- Added IsUsernameTaken() to check the username list before a new account is saved.
- Added duplicate username validation so two accounts cannot register with the same username.
- Added registration field validation so full name, username, and password cannot be left blank.
- Changed registration storage from fixed arrays to growable Lists so signups are no longer limited to 10 accounts.
- Kept userCount updated when a new account is registered so the login search only checks real saved accounts.
- Removed the old registration full message because new accounts can keep being added with Lists.
- Added main menu input validation using int.TryParse() so blank inputs, letters, and invalid menu values do not crash the program.
- Added main menu error handling for:
  - Non-number inputs
  - Numbers outside the available options
  - Returning to the main menu after an invalid choice
- Used Console.Clear() so the main menu, login screens, registration screen, admin login screen, and admin menu display cleanly instead of stacking on top of old console text.
- Added clear Console.WriteLine() feedback for login success, login failure, registration errors, duplicate usernames, invalid menu choices, and returning to menus.
- Added a ShoppingApp_Final.csproj file so the project can be built and run with the dotnet command line tools.
- Set the project file up as a console executable using:
  - Microsoft.NET.Sdk
  - OutputType Exe
  - TargetFramework net8.0
  - RootNamespace ShoppingApp_Final
- Added the adminUsername and adminPassword variables for the admin login credentials.
- Set the current admin credentials so the username must be `admin` and the password must also be `admin`.
- Added the AdminLogin() method that runs before the admin menu is shown.
- Added admin login input fields for:
  - Username
  - Password
- Made AdminLogin() return true only when both admin credentials are correct.
- Made AdminLogin() return false when the username or password is wrong.
- Updated main menu option 2 so it calls AdminLogin() first and only opens AdminMenu() after a successful admin login.
- Added a successful admin login message so the admin knows they are being taken into the admin menu.
- Added an invalid admin login message that sends the user back to the main menu instead of letting them access the admin tools.
- Protected the admin product management options behind the admin login instead of allowing direct access from the main menu.

What I did | Ethan:
- Helped with creation of the landing/home page in collaboration with Zach.
- Created the do-while loop for the main menu navigation.
- Created the RegisterScreen() method.
- Added user registration using Lists for:
  - Full Name
  - Username
  - Password
- Added registration success messages and menu return functionality.
- Helped test and debug the registration system during development.
- Created the AdminMenu() method structure.
- Added admin menu validation structure and navigation flow.
- Helped plan the future admin authentication flow.
- Added clear Console.WriteLine() messages to improve navigation and user understanding.
- Created the Cart.cs class.
- Added Cart class properties for:
  - ProductID
  - ProductName
  - ProductPrice
  - Quantity
- Added a Cart constructor to store selected product details.
- Added GetTotalPrice() method to calculate item total.
- Added DisplayCartItem() method to display cart item details.
- Created the Product.cs class.
- Added Product class properties for:
  - ProductID
  - Name
  - Category
  - Price
  - Stock
- Added Product constructor.
- Added DisplayProductDetails() method.
- Added UpdateProductDetails() method.
- Added an initial clothing product catalogue containing:
  - Beanie
  - Hoodie
  - Shirt
  - Long Sleeve
  - Pants
  - Shorts
  - Socks
  - Hat
  - Dress
  - Sweatpants/Joggers
- Implemented product management functionality:
  - Display Products
  - Add Product
  - Update Product
  - Remove Product
  - Search Product
- Added product stock tracking functionality.
- Worked on documenting development stages, testing, and planning decisions for the project documentation.


## Current Progress

- Main menu completed
- Registration system completed
- Basic login system completed
- Navigation structure completed
- Customer login validation completed
- Main menu input validation completed
- Registration storage updated to allow more than 10 accounts using Lists
- Admin menu completed
- Registration validation and error handling completed
- Product class completed
- Product catalogue created
- Product display completed
- Add product completed
- Update product completed
- Remove product completed
- Search product completed
- Product stock tracking completed
- Cart class completed
- Cart item total calculation completed
- Cart item display method completed
- Admin login verification completed


## Features Still To Add

- Customer menu
- Add to cart functionality
- View cart functionality
- Checkout system
- Cart integration with customer menu
- Stock reduction when products are purchased
- Order confirmation process
- User class
- Admin class
- Customer class
- Full shopping workflow testing
- File storage / database storage (if required)
