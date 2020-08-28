# Contoso University tutorial
Contoso University tutorial based on Web API, React and Dapper, rather than MVC and EF Core. The same structure of the tutorial is followed but with a change in the technical landscape.

This is a different take on the Contoso University tutorial from Microsoft. The original tutorial can be found [here](https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/creating-an-entity-framework-data-model-for-an-asp-net-mvc-application)

This implementation is a playground for testing out [vertical slice architecture](https://jimmybogard.com/vertical-slice-architecture/) from Jimmy Bogard on a Web API rather than Razor Pages.

## Things demonstrated
 - CQRS and Mediator patterns
 - Automapper
 - Fluent Validations
 - Vertical Slice Architecture
 - Dapper
 - Fluent migration
 - NSwag API explorer

 ## Migration of the database
 TODO

 ## Getting started
 TODO

 1. Start docker container for database. This will deploy a MySQL 8 database container.
```shell
$ cd docker
$ docker-compose up -d
```


TODO notes:
- API versioning

