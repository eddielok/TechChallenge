# TechChallenge
TechChallenge

# Repository


This repository is home to the following [.NET Foundation](https://dotnetfoundation.org/) projects. These projects are maintained by [Microsoft](https://github.com/microsoft) and licensed under the [Apache License, Version 2.0](LICENSE.txt).


## Entity Framework Core

[![latest version](https://img.shields.io/nuget/v/Microsoft.EntityFrameworkCore)](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore) [![preview version](https://img.shields.io/nuget/vpre/Microsoft.EntityFrameworkCore)](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/absoluteLatest) [![downloads](https://img.shields.io/nuget/dt/Microsoft.EntityFrameworkCore)](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore)

EF Core is a modern object-database mapper for .NET. It supports LINQ queries, change tracking, updates, and schema migrations. EF Core works with SQL Server, Azure SQL Database, SQLite, Azure Cosmos DB, MySQL, PostgreSQL, and other databases through a provider plugin API.

### Installation

EF Core is available on [NuGet](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore). Install the provider package corresponding to your target database. See the [list of providers](https://docs.microsoft.com/ef/core/providers/) in the docs for additional databases.

```sh
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Cosmos
```

Use the `--version` option to specify a [preview version](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/absoluteLatest) to install.


### Basic Setup
Prerequisite: Visual Studio 2019, MSSQL, SSMS and .NET framework 5.0 is installed on PC
Update-database in Package Manage Console
For details, Please refer to the Detail guideline.pdf


### Structure
It is developed in .NET Core 5, EF Core 5.0.4 (PS. EF Core 5.0.7 have bug which you cannot using code first)
API, Swagger, Migration and Service layer solution where located  in ..\TechChallenge\TechChallenge.sln
Console test solution were located in ..\TechChallenge\ConsoleTest\ConsoleTest\ConsoleTest.sln 
For the TechChallenge, please refer to https://github.com/WhiteOrg/backend-tech-test



