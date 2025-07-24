# ContainRs - ASP.NET Core MVC Study Project

## About The Project

This project was developed as a hands-on study to deepen understanding of the ASP.NET Core MVC architecture. The main goal is to explore and apply concepts from **Clean Architecture** and **Domain-Driven Design (DDD)** in a practical .NET 8 application.

The project structure, featuring distinct layers for services and data access, reflects an effort to create a decoupled, maintainable, and testable solution.

### Built With

* .NET 8
* ASP.NET Core MVC
* Entity Framework Core 8
* SQL Server
* [Refit](https://github.com/reactiveui/refit): For typesafe REST API consumption (integrating with ViaCEP).

## Learning Goals

This project serves as a portfolio piece to demonstrate and acquire deeper knowledge in:

* **Mastering the MVC Pattern**: Solidifying the fundamentals of Model-View-Controller in ASP.NET Core.
* **Clean Architecture**: Implementing principles to create a decoupled, independent, and testable application.
* **Domain-Driven Design (DDD)**: Applying tactical DDD patterns to model the business domain effectively.
* **Entity Framework Core**: Using an ORM for data persistence with a code-first approach.
* **Dependency Injection**: Configuring services and their lifetimes using the built-in DI container in .NET.
* **External API Integration**: Consuming third-party REST APIs efficiently using libraries like Refit.

## Getting Started

Follow these steps to get a local copy up and running.

### Prerequisites

* .NET 8 SDK
* SQL Server (Express, Developer, or LocalDB)

### Installation and Setup

1.  **Clone the repository:**
    ```sh
    git clone [https://your-repository-link.com](https://your-repository-link.com)
    ```

2.  **Configure the Database Connection:**
    * Navigate to the `ContainRs.WebApp` folder.
    * Open the `appsettings.json` file.
    * Locate the `ConnectionStrings` section and update the `ContainRsDB` value with your SQL Server connection string.
    ```json
    "ConnectionStrings": {
      "ContainRsDB": "Server=your_server_name;Database=ContainRsDB;Trusted_Connection=True;TrustServerCertificate=True;"
    }
    ```

3.  **Create the Database:**
    * Open a terminal and navigate to the root folder of the project.
    * Run the following Entity Framework command to apply the migrations and create the database schema.
    ```sh
    dotnet ef database update --project .\\ContainRs.WebApp\\ContainRs.WebApp.csproj --startup-project .\\ContainRs.WebApp\\ContainRs.WebApp.csproj
    ```

4.  **Run the Application:**
    * You can run the project using your favorite IDE (like Visual Studio or VS Code) or through the command line:
    ```sh
    dotnet run --project .\\ContainRs.WebApp\\ContainRs.WebApp.csproj
    ```
    The application should now be running and accessible at `https://localhost:port` or `http://localhost:port` as specified in your `launchSettings.json` file.