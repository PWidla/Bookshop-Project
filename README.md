# Theme of the project: Bookstore app
## Visually
**Login window**
- Input fields (username & password)
- Login button
- Message about incorrect data / message about successful login
- Button to go to the registration window

**Registration window**
- Input fields (username & password)
- Registration button
- Message about incorrect data / message about successful registration
- Button to go to the login window

**Available books window**
- A table listing available books
- Button for booking the selected item
- Logout button
- Button to go to the window with messages (posts)

**Available books window (administrator)**
- A table listing available books
- Button for booking the selected item
- Logout button
- Button to go to the window with messages (posts)
- Button to go to the booking history window

**News/Post Window**
- Table containing added posts
- Button to return to the book list window
- Logout button

**Message/Post Window (Admin)**
- Table containing added posts
- Fields for entering new post data
- A button that adds a new post containing the data entered by the administrator
- Button to delete the selected post
- Button to return to the book list window
- Logout button

**Booking history window (administrator)**
- Table with booking history
- Button to return to the book list window
- Logout button


## Technically
**Database**
- "users" table
- "books" table
- "wishlist" table
- "posts" table

**ORM + database operations**
- Adding records to the database
- Deleting records from the database
- Downloading data from the database
