# ASP.Net Core Web API with Docker Compose, PostgreSQL and EF Core.
A simple ASP.NET Core sample web application using .Net Web Api Core and PostgreSQL with Docker support.
Both the Web Applicaiton and the Postgres DB runs in container. 
Added Swagger support to interact with API’s resources.

## Prerequisites
1. [Docker](https://www.docker.com/)
2. [.NET Core SDK 2.2](https://dotnet.microsoft.com/download/dotnet-core/2.2)

## Steps
1.  clone repository

2. `cd docker-aspnetcore-postgresql`

3. `docker-compose build`

4. `docker-compose up`

5.  Navigate to http://localhost:8000/swagger


## During development
After updating schema use the following commands to force recreation of the postgresql volume:
```shell
> docker volume rm docker-aspnetcore-postgresql_db_volume
> docker-compose up --force-recreate --build
```

After updating code use the following commands to force recreation of the container:
```shell
> docker-compose up --force-recreate --build
```
