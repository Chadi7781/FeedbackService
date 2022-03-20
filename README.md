 <img align="left" width="116" height="116" src="https://raw.githubusercontent.com/JasonGT/CleanArchitecture/master/.github/icon.png" />
 
 # Clean Architecture Solution Template
[![Clean.Architecture.Solution.Template NuGet Package](https://img.shields.io/badge/nuget-1.0.5-blue)](https://www.nuget.org/packages/Clean.Architecture.Solution.Template)
[![Twitter Follow](https://img.shields.io/twitter/follow/jasongtau.svg?style=social&label=Follow)](https://twitter.com/jasongtau)

<br/>

This is a solution template for creating a Single Page App (SPA) with Angular 8 and ASP.NET Core 3 following the principles of Clean Architecture. Create a new project based on this template by clicking the above **Use this template** button or by installing and running the associated NuGet package (see Getting Started for full details). 


## Technologies
* .NET Core 6
* ASP .NET Core 6
* Entity Framework Core 6
* React Js (comming soon)

## Getting Started

The easiest way to get started is to install the [NuGet package](https://www.nuget.org/packages/Clean.Architecture.Solution.Template) and run `dotnet new ca-sln`:

1. Install the latest [.NET Core SDK](https://dotnet.microsoft.com/download)
2. Run `dotnet new --install Clean.Architecture.Solution.Template` to install the project template
3. Run `dotnet new ca-sln` to create a new project
4. Navigate to `src/WebUI` and run `dotnet run` to launch the project

## Overview

### Domain

This will contain all entities, enums, exceptions, interfaces, types and logic specific to the domain layer.


### Application

This layer contains all application logic. It is dependent on the domain layer, but has no dependencies on any other layer or project. This layer defines interfaces that are implemented by outside layers. For example, if the application need to access a notification service, a new interface would be added to application and an implementation would be created within infrastructure.


### Infrastructure

This layer contains classes for accessing external resources such as file systems, web services, smtp, and so on. These classes should be based on interfaces defined within the application layer.

### WebUI

This layer is a single page application based on Angular 8 and ASP.NET Core 3. This layer depends on both the Application and Infrastructure layers, however, the dependency on Infrastructure is only to support dependency injection. Therefore only *Startup.cs* should reference Infrastructure.

## Support

If you are having problems, please let us know by [raising a new issue](https://github.com/JasonGT/CleanArchitecture/issues/new/choose).

## License

This project is licensed with the [MIT license](LICENSE).






 # My Feedback Project 




Dans cet Projet, nous accomplirons les tâches suivantes :
Create src & test folders

Create ASP.NET Core Web API C# version FeedbackService.Api

Create .NET Core class library for Core FeedbackService.Core

Create .NET Core class library for Infrastructure FeedbackService.Infrastructure

Create .Xunit project for API FeedbackService.Api.Tests

Create .Xunit project for Core FeedbackService.Core.Tests

Create .Xunit project for Infrastructure FeedbackService.Infrastructure.Tests

Create .gitignore file

Create .gitattribute file

Push the code into Git

Pull the code from Git

Commit changes into remote Git

Create new feature branch called feature-branches for next set of changes

Create folder structure & files for API

ApiConstants.cs
AppSettings.cs
DependencyInjection.cs
FeedbackService.Api.xml
KeyVaultCache.cs
ServiceDescription.md
ServiceExtensions.cs
SwaggerConfiguration.cs
Middlewares
HttpCodeAndLogMiddleware.cs
Helper
MapperProfile.cs
HealthCheck
MemoryHealthCheck.cs
HealthCheck
RemoteHealthCheck.cs
SwaggerExamples
Requests
FeedbackRequestExample.cs
Response
FeedbackResponseExample.cs
V1
Controllers
FeedbackController.cs
V2
Controllers
FeedbackController.cs
Create folder structure & files for Core

Constants
ContentTypes.cs
Exception
Interfaces
Models
Services
Exception
ApiException.cs
DomainException.cs
NotFoundException.cs
ValidationException.cs
Interfaces
Repositories
IFeedbackRepository.cs
Interfaces
Services
IFeedbackService.cs
Models
Feedback.cs
Services -FeedbackService.cs
Create folder structure & files for Infrastructure

Context
FeedbackDbContext.cs
Entities
Feedback.cs
Repositories
FeedbackRepository.cs
Add project references (Internal references)

Add dependencies in src
API
Core
Infrastructure
Swashbuckle.AspNetCore
Core
Newtonsoft.Json
If any shared nuget packages comes here
Infrastructure
Core
Install-Package AutoMapper.Extensions.Microsoft.DependencyInjection -Version 8.1.1
Install-Package Microsoft.EntityFrameworkCore -Version 6.0.9
Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 6.0.9
Install-Package Microsoft.EntityFrameworkCore.Design -Version 6.0.9
Uninstall-Package Microsoft.EntityFrameworkCore.Design -Version 6.0.9
Add dependencies in test
FeedbackService.Api.Tests
FeedbackService.Api
FeedbackService.Core.Tests
FeedbackService.Core
FeedbackService.Infrastructure.Tests
FeedbackService.Infrastructure
Add model in infra called Feedback.cs

Create DbContext classes & register in startup

Create model in Core - Feedback.cs

Create interface in Core - IFeedbackRepository.cs

Create interface’s implementation in Infra - FeedbackRepository.cs

Configure dependencies for repos

Create Service interface & classes – IFeedbackService & FeedbackService

Create Service classes - FeedbackService

Create controller classes – FeedbackController

## Auto Mapper
What is AutoMapper?
AutoMapper is a simple library that helps us to transform one object type to another. It is a convention-based object-to-object mapper that requires very little configuration. 

The object-to-object mapping works by transforming an input object of one type into an output object of a different type.

One Use Case
AutoMapper was built to solve a complex problem that most developers face in their day-to-day life – writing code that maps one object type to another. This type of code is rather tedious and boring to write, so why not leave that job to this little tool?

What makes AutoMapper interesting is that it provides some easy to use conventions to take the dirty work out of figuring out how to map Type A to Type B. As long as Type B follows AutoMapper’s established conventions, almost no configuration is needed to map two types.

Here’s one common scenario. We’ve created an application and we want to keep the separation between our domain models and our view models. 

In order to accomplish this, we need to write the code to adapt our domain model to our view model. Then, as we add more views and domain models, we end up writing more adapters. Later on, we’ll have to write even more adapters to map our data transfer objects from the database layer into our domain objects. 

This is mundane and repetitive. And this is where AutoMapper comes in.

How to Use AutoMapper in Our Application
Let’s have a look at how to add Automapper into our .NET Core application.

Installation
The first step is to install the corresponding NuGet package:

Install-Package AutoMapper.Extensions.Microsoft.DependencyInjection
