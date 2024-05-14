# BookStoreNetCore

## Description
This is a E-commerce Project for selling books

## Contributors
  + [Thuan Tran](https://github.com/tdthuan0112)

## Techs:
  + Front-end:
    + Nextjs v14.2.3 (SSR) combine with React (CSR)
      + Nextjx App Router
      + Styling: CSS Modules
  + Back-end: Dotnet core 8.0 (C#) 
  + Database: Sql
  + Figma: UI Design [Link](https://www.figma.com/design/ccWc9G7tfY7p65BmHLdFxZ/BookStore---Present?node-id=0-1&t=XKQYWf6Ga5RNvBpI-0)
  + Lucid chart: Database Design [Link](https://lucid.app/lucidchart/d662c2aa-d7b5-4dc4-8d20-71e0da26fcb8/edit?invitationId=inv_3de3346c-9131-427c-bd5e-8738412f4f61&page=0_0#)

## Tools:
  + Visual Studio 2022
  + Visual Studio Code
  + Miscrosoft SQL Server Management Studio

## How to install and run the Project
  + Clone the project to local directory
  + Open Visual Studio 2022
  + Select "Open a project or solution" => Select and open the BookStoreNetCore.sln
### Set start up project
  + Set "BookStoreEcommerce.Server" as Start up Project
### Config appsettings.json and generate DB
  + Open appsettings.json and appsettings.Development.json in /Frontend/bookstoreecommerce.client
  + Replace "DefaultConnection" into your local DB Connection String
    + ex: "bookStoreConnectionString" -> "Server=`your-local-server-name`;Database=`your-custom-db-name`;Trusted_Connection=true;TrustServerCertificate=true"
  + In Visual Studio, select Tools > NuGet Package Manager > Package Manager Console
  + Change the default project to BookStore.Migrations Project
  + Add commands:
    + add-mirgration
    + update-database
  
