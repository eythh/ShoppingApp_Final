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


## Current Progress
- Main menu completed
- Registration system completed
- Basic login system completed
- Navigation structure completed
- Customer login validation completed
- Main menu input validation completed
- Registration storage updated to allow more than 10 accounts

## Features Still To Add
- Admin login
- Product management
- Shopping cart
- Search functionality
- Checkout system
- File storage / database storage
- Admin product controls
