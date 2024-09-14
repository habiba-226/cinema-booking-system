# Cinema Booking System

## Functional Requirements

1. **User login and signup** (using SQL database).
2. **Browse movies** and view movie details.
3. **Book tickets**, specify the type, age, date, and manage the list of booked tickets.
4. **View and manage ticket details**.
5. **Select seats** for a movie.
6. **Exit the application**.

## Database: Microsoft SQL Server

To use Microsoft SQL in Visual Studio, download `Microsoft.Data.SqlClient` by right-clicking on the WinFormApp, selecting "Manage NuGet Packages," and installing it. You can then add the `Microsoft.Data.SqlClient` using directive in the login and signup forms to implement the database.

The database, `loginapp`, was created in **Microsoft SQL Server Management Studio** and is used for both the `Login.cs` and `Signup.cs` forms. 

### Connecting to SQL Server in Visual Studio

- Open **Server Explorer** from the View menu.
- Connect the device's SQL server in the **Data Connection** section.

## Application Forms Overview

### 1. Login Page

The **Login Page** allows users to enter their credentials. If the username and password do not match what’s in the database, a "Login Failed!" message is shown.

#### Steps:

1. **Validation**: Ensures username and password textboxes are not empty. If they are, a message box appears: "Fill the blank spaces".
2. **Database Connection**: Connects to the `loginapp` SQL database.
3. **Login Query**: Executes an SQL query to validate the username and password.
   - If no match, "Login Failed!" is displayed.
   - If a match is found, the login page hides, and the homepage (`homepage.cs`) opens.
4. **Error Handling**: Displays an error message in case of exceptions.

There is also a **Create Account** button, which redirects to the **Signup Page**.

### 2. Signup Page

The **Signup Page** allows new users to create accounts by providing a username and password.

#### Steps:

1. **Validation**: Ensures none of the fields (Username, Password, Confirm Password) are empty.
2. **Password Matching**: If the Password and Confirm Password fields do not match, a message box says, "Passwords don’t match."
3. **Database Insertion**: Inserts the new user record into the `loginapp` database.
   - If `ExecuteNonQuery()` returns 0, it indicates failure; otherwise, the signup is successful.
4. **Back to Login**: A button allows users to go back to the login page.

### 3. Home Page

The **Home Page** displays movie panels with the following attributes:

- Movie Title
- Time
- Directors
- Writers
- Stars
- Poster Image

Users can navigate to the **Booking Page** to select and book a movie.

### 4. Booking Movie

The **Booking Movie Page** allows users to book movie tickets, manage their booked tickets, and navigate to other forms for ticket details and seat selection.

#### Features:

- Users can specify ticket details (e.g., age, type, and date).
- Buttons to **Add**, **Remove**, and **Clear** the list of booked tickets.
- A **Ticket Counter** keeps track of the number of tickets.
- **Exit** button to leave the application.

### 5. Ticket Details

The **Ticket Details Page** displays detailed information about a specific ticket, such as:

- Ticket ID
- Movie Title
- Ticket Type
- Age
- Date
- Seat Number

It also generates a random ticket ID using the `Ticket` class and its child `TypeofTicket` class.

### 6. Booking Seats

The **Booking Seats Page** allows users to select seats for a movie, with options for **standard** and **VIP** seats.

#### Features:

- 4 instance variables, including lists of front and back seats.
- 8 buttons for different seat arrangements.
- Methods to retrieve seat information (number, type) and book the seat.

## Class Overview

### MoviePanel

| Variable       | Type    |
|----------------|---------|
| _title         | string  |
| _time          | string  |
| _directors     | string  |
| _writers       | string  |
| _stars         | string  |
| _poster        | Image   |

#### Properties:

- MovieTitle
- Time
- Directors
- Writers
- Stars
- Poster

### TypeofTicket

| Variable        | Type       |
|-----------------|------------|
| Age             | int        |
| Type            | string     |
| Date            | DateTime   |
| SeatNumber      | int        |

### Ticket

| Variable  | Type   |
|-----------|--------|
| Title     | string |
| ID        | string |

#### Methods:

- `GenerateID()`: Generates a unique ID for each ticket.

### Seat

| Variable     | Type   |
|--------------|--------|
| SeatNumber   | int    |
| IsAvailable  | bool   |

#### Methods:

- `GetSeatType()`: Returns the type of seat (Standard/VIP).
- `BookSeat()`: Books the seat based on user selection.

### StandardSeat and VIPSeat

| Variable       | Type   |
|----------------|--------|
| SeatNumber     | int    |

#### Methods:

- `GetSeatType()`: Returns whether the seat is standard or VIP.

## System Workflow

1. The user logs in or signs up.
2. They navigate to the **Home Page**.
3. The user selects a movie and books a ticket.
4. They can view and manage ticket details.
5. The user can remove or clear tickets from the list.
6. The user selects seats for a movie.
7. Detailed seat information is displayed.
8. The user exits the application.

---

**Contributors:**
- Habiba Ahmed (ID: 221002359, Class 9)
- Seifeldin Walid (ID: 221000519)
