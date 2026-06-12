# ShoppingApp_Final

A C# console shopping app with customer accounts, admin login, product management, carts, and checkout.

## How to Run

From the project folder, run:

```bash
dotnet run
```

Admin login details:
- Username: `admin`
- Password: `admin`

## What I did | Zach

- Created the `UserLogin()` method so registered users can sign in before using customer features.
- Made `UserLogin()` return `true` or `false` so the program only opens the customer menu after a successful login.
- Added a check for when no customer accounts have been registered yet.
- Added username and password input for customer login.
- Used `Trim()` and null handling on login and menu inputs so blank input and extra spaces are handled better.
- Added `FindRegisteredUser()` to find matching customer accounts.
- Added `loggedInUserIndex` to track which customer is currently logged in.
- Added login success and failure messages.
- Added `IsUsernameTaken()` so duplicate usernames cannot be registered.
- Added registration validation so full name, username, and password cannot be blank.
- Changed customer storage to use a `List<Customer>` instead of fixed arrays.
- Added main menu input validation with `int.TryParse()`.
- Added admin username and password variables.
- Created the `AdminLogin()` method.
- Protected the admin menu so it only opens after the correct admin login.
- Created the `Customer.cs` class for registered customer accounts.
- Added customer properties for full name, username, password, and cart items.
- Updated registration so it creates a new `Customer` object.
- Created the customer menu with options to display products, search products, add to cart, view cart, and logout.
- Added customer menu validation.
- Created `AddProductToCart()` so customers can add products and quantities to their own cart.
- Added add-to-cart validation for invalid IDs, missing products, no stock, invalid quantities, and quantities higher than stock.
- Made the cart update the quantity when the same product is added more than once.

## What I Did | Ethan

- Worked with Zach on the main landing menu and navigation.
- Created the main menu structure using a do-while loop.
- Created the `RegisterScreen()` method.
- Helped set up registration and return-to-menu flow.
- Helped test and troubleshoot registration during development.
- Created the structure for `AdminMenu()`.
- Added admin menu validation and navigation.
- Added clear console messages so the app is easier to follow.
- Created the `Product.cs` class.
- Added product properties for ID, name, category, price, and stock.
- Added product methods to display and update product information.
- Created the starting clothing product catalogue.
- Implemented admin product management:
  - Display products
  - Add product
  - Update product
  - Remove product
  - Search product
- Added product stock tracking.
- Created the `Cart.cs` class.
- Added cart properties for product ID, product name, product price, and quantity.
- Added cart total calculation with `GetTotalPrice()`.
- Added `DisplayCartItem()` to show cart item details.
- Connected customer cart items to the logged-in `Customer`.
- Connected the View Cart menu option to `ViewCart()`.
- Created `ViewCart()` so customers can see cart items, item totals, and the full cart total.
- Added a checkout prompt from inside View Cart.
- Created `Checkout()` to process the customer's order.
- Added checkout validation for login state, empty carts, missing products, and not enough stock.
- Reduced product stock after a successful checkout.
- Cleared the customer's cart after checkout.
- Added an order confirmation message and order total.

## Current Progress

- Main menu completed
- Registration system completed
- Customer login completed
- Customer class completed
- Customer menu completed
- Admin login completed
- Admin menu completed
- Product class completed
- Product catalogue completed
- Product management completed
- Product display completed
- Add product completed
- Update product completed
- Remove product completed
- Search product completed
- Product stock tracking completed
- Cart class completed
- Cart integration with customer accounts completed
- Add to cart completed
- View cart completed
- Checkout completed
- Stock reduction after checkout completed
- Order confirmation completed
- Input validation and error handling completed for the main flows

## Testing Evidence

The testing table/document `Final_ErrorAndFlow_Table.docx` covers the final error handling and flow testing. It includes tests for the main menu, registration, login, admin login, customer menu, product management, add to cart, view cart, checkout, stock reduction, and logout.

The table also records pass/fail results and notes for final fixes or improvements.

## Features Still To Add

- Final bug fixes from the testing table
- Final usability improvements, like making some retry flows smoother
- Final screenshots for evidence
- Final documentation and testing records
- Final project submission
