dotnet new sln --name Triumph
dotnet new classlib --name Triumph.Implementation --output Triumph.Implementation
dotnet sln Triumph.sln add .\Triumph.Implementation\Triumph.Implementation.csproj
dotnet new xunit --name Triumph.Tests --output Triumph.Tests
dotnet sln Triumph.sln add .\Triumph.Tests\Triumph.Tests.csproj
dotnet add .\Triumph.Tests\Triumph.Tests.csproj reference .\Triumph.Implementation\Triumph.Implementation.csproj
dotnet restore
dotnet build