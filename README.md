Cinema Booking System
Functional Requirements:
User Login and Signup: Implements authentication using a SQL database.
Browse Movies: Users can view available movies and detailed information.
Book Tickets: Users can specify ticket type, age, date, and manage their booked tickets.
Ticket Management: View and manage the details of each booked ticket.
Select Seats: Users can select seats for a movie (standard or VIP).
Exit the Application: Gracefully exit the system when done.
Database Integration (Microsoft SQL Server)
Database Setup: Uses Microsoft SQL Server for handling the database. To connect SQL to Visual Studio, download the Microsoft.Data.SqlClient package via NuGet by right-clicking on the WinFormApp and selecting Manage NuGet Packages.
SQL Connection: A connection is established to the loginapp database, where users' login information (username and password) is stored. This database is accessed in both Login.cs and Signup.cs forms.
Connecting Visual Studio with SQL Server:
In Visual Studio, open Server Explorer from the View menu and connect your local SQL server to establish a connection with the database.
Forms Overview
Form 1: Login Page
Functionality: Allows existing users to log in by providing valid credentials (username and password).
Error Handling: If credentials don’t match, a “Login Failed” message is displayed. It also checks that the input fields are not empty.
SQL Query: Executes a query to check if the credentials exist in the database. Upon successful login, redirects to the homepage (homepage.cs).
Create Account: If the user does not have an account, they can navigate to the signup page (Signup.cs).
Form 2: Signup Page
Functionality: Users can create a new account by entering and confirming their password.
Validation: Checks if the username and password fields are filled, and ensures the password matches the confirmation field.
SQL Query: Inserts new user credentials into the database and notifies the user of success or failure.
Back to Login: Users can return to the login page after creating an account.
Form 3: Home Page
Overview: Displays a list of available movies and navigation buttons.
MoviePanel: A reusable component used to display movie details like title, time, directors, and stars. The “Booking” button leads to the movie booking form.
MoviePanel Attributes:

Title, Time, Directors, Writers, Stars, Poster (Image).
Form 4: Booking Movie
Overview: Allows users to book movie tickets by specifying details such as ticket type, age, and date.
Ticket Management: Users can add, remove, or clear the list of booked tickets.
Exit: The form provides an exit button to leave the application.
Navigation: The form includes buttons for navigating to ticket details and seat selection forms.
Form 5: Ticket Details
Overview: Displays detailed information about a specific ticket, including movie title, type, age, date, and seat number.
Random ID Generation: Generates a unique ID for each ticket.
Classes: Uses classes Ticket and TypeofTicket to store and display ticket data.
Form 6: Booking Seats
Overview: Allows users to choose seats for a movie, either standard or VIP.
Seat Selection: Users can book seats by clicking on buttons representing seat arrangements (front and back seats). The form updates ticket details with the chosen seat.
Seat Attributes:

SeatNumber, IsAvailable (whether the seat is booked or not).
Overall System Workflow
User logs in or signs up to the system.
User navigates to the Home Page where they can browse movies.
User selects a movie and books tickets.
User manages ticket details, including viewing, adding, or removing tickets.
User selects seats for a movie (either standard or VIP).
User exits the application when done.
Contributors:
Habiba Ahmed 
Seifeldin Walid 
