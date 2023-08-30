# CRUD API for Managing Books

This project is a basic CRUD (Create, Read, Update, Delete) API for managing books. It allows you to perform various operations on a collection of books, such as creating, retrieving, updating, and deleting them.

## Introduction

This project provides a simple API for managing books. It is built using ASP.NET Core and follows RESTful principles to handle CRUD operations. The API supports creating new books, fetching book details by ID, retrieving a list of all books, updating existing books, and deleting books.

## How It Works

The API uses the provided `IBookService` to interact with a mock database (implemented as `IMockDbContext`). The service methods perform the necessary CRUD operations on the book collection.

## Installation and Usage

### Prerequisites

- .NET Core SDK must be installed on your machine.

### Running the Application

1. Clone this repository or download the source code to your local machine.

2. Open a terminal or command prompt and navigate to the project's root directory.

3. Build the project:
   ```shell
   dotnet build
   
4. Run the application:
   ```shell
   dotnet run

The API will be accessible at **http://localhost:{PORT}/api/book**.
## Configuration

No special configuration is required for this project. The mock database and book service are already set up.

## Support, Contact and Author
This "CRUD API" was created by [n1nni](https://github.com/n1nni). If you encounter any issues, have suggestions for improvements, or need help with this project, feel free to reach out to me.

Contact Information:

:email: - Email: [nin.dautashvili@gmail.com](mailto:nin.dautashvili@gmail.com)

:email: - LinkedIn: [Nino Dautashvili](https://www.linkedin.com/in/nino-dautashvili/)

Thank you for checking out this CRUD API project! :rocket:

