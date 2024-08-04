## In order to run an test these projects, follow the steps described bellow.

## Prerequisites
Install .NET SDK: Ensure you have the .NET SDK installed on your machine.
Git: Ensure you have Git installed to clone the repository.
Install SQL Server: Ensure you have SQL Server installed and running on your machine. You can use SQL Server Express for a free version.

## Clone the Repository
git clone <repository_url>
cd <repository_directory>

## Set Up the Database Connection
Update appsettings.json in the Authorization Server
Update the appsettings.json file to include your SQL Server connection string:

## Apply migrations:
cd AuthorizationServer
dotnet ef migrations add InitialCreate
dotnet ef database update

## Navigate to the Authorization Server Directory
cd AuthorizationServer

## Restore Dependencies and Build the Project
dotnet restore
dotnet build

## Run the Authorization Server
dotnet run
By default, this will start the Authorization Server on https://localhost:5001. or you can change it by appsettings

## Open a New Terminal and Navigate to the Resource Server Directory
Open a new terminal window or tab and navigate to the Resource Server directory:
cd ../ResourceServer

## Restore Dependencies and Build the Project
dotnet restore
dotnet build

## Run the Resource Server
dotnet run
By default, this will start the Resource Server on https://localhost:5002.

## Open Another New Terminal and Navigate to the Client Application Directory
Open another new terminal window or tab and navigate to the Client Application directory:
cd ../ClientApp

## Restore Dependencies and Build the Project
dotnet restore
dotnet build

## Run the Client Application
dotnet run

