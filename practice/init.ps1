dotnet new sln --name Practice
dotnet new classlib --name Practice.Implementation --output Practice.Implementation
dotnet sln Practice.sln add .\Practice.Implementation\Practice.Implementation.csproj
dotnet new xunit --name Practice.Tests --output Practice.Tests
dotnet sln Practice.sln add .\Practice.Tests\Practice.Tests.csproj
dotnet add .\Practice.Tests\Practice.Tests.csproj reference .\Practice.Implementation\Practice.Implementation.csproj
dotnet restore
dotnet build