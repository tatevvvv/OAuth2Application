# In order to run an test these projects, you need to follow the steps described bellow.

# Prerequisites
Install .NET SDK: Ensure you have the .NET SDK installed on your machine.
Git: Ensure you have Git installed to clone the repository.

# 1. Clone the Repository
git clone <repository_url>
cd <repository_directory>

# 2. Navigate to the Authorization Server Directory
cd AuthorizationServer

# 3. Restore Dependencies and Build the Project
dotnet restore
dotnet build

# 4. Run the Authorization Server
dotnet run
By default, this will start the Authorization Server on https://localhost:5001. or you can change it by appsettings

# 5. Open a New Terminal and Navigate to the Resource Server Directory
Open a new terminal window or tab and navigate to the Resource Server directory:
cd ../ResourceServer

# 6. Restore Dependencies and Build the Project
dotnet restore
dotnet build

# 7. Run the Resource Server
dotnet run
By default, this will start the Resource Server on https://localhost:5002.

# 8. Open Another New Terminal and Navigate to the Client Application Directory
Open another new terminal window or tab and navigate to the Client Application directory:
cd ../ClientApp

# 9. Restore Dependencies and Build the Project
dotnet restore
dotnet build

# 10. Run the Client Application
dotnet run

