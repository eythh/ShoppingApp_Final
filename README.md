# ShoppingApp_Final

A C# console shopping app project with a main menu, account registration, and registered-user login.

What I did | Zach:
- Created a static bool UserLogin method so that registered users can log in.
- Used Console.Clear so each time the menu shows, the screen is cleared.
- Added helper methods to find registered users and check whether usernames are already taken.
- Added a csproj file so the program can be built and run with `dotnet`.
- Added menu input validation so blank inputs, letters, and invalid numbers do not crash the program.
- Added clear Console.WriteLine messages so users know what happened when they enter the wrong menu value.
- Changed registration storage from fixed arrays to growable lists so signups are no longer limited to 10 accounts.
- Removed the registration full message because new accounts can keep being added.

What I did | Ethan:
- Helped with creation of the landing/home page in collaboration with Zach.
- Created the do-while loop for the main menu navigation.
- Created the RegisterScreen() method.
- Added user registration using arrays for:
  - Full Name
  - Username
  - Password
- Added registration success messages and menu return functionality.
- Helped test and debug the registration system during development.
- Created the AdminMenu() method structure.
- Added placeholders for admin menu for:
  - Display Products
  - Add Product
  - Update Product
  - Remove Product
  - Search Product
  - Logout
- Added admin menu validation structure and navigation flow.
- Helped plan the future admin authentication flow.
- Added clear Console.WriteLine() messages to improve navigation and user understanding.
- Worked on documenting development stages, testing, and planning decisions for the project documentation.


## Current Progress
- Main menu completed
- Registration system completed
- Basic login system completed
- Navigation structure completed
- Customer login validation completed
- Main menu input validation completed
- Registration storage updated to allow more than 10 accounts
- Admin menu structure completed
- Registration validation and error handling started
- Admin menu navigation and placeholder functionality completed
- Admin product display completed
- Admin add product completed
- Admin update product completed
- Admin remove product completed
- Admin search product completed


## Features Still To Add
- Admin login verification
- Shopping cart
- Checkout system
- File storage / database storage
- Customer menu
