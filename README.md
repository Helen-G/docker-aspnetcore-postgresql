# ASP.Net Core Web API with Docker Compose, PostgreSQL and EF Core.
A simple ASP.NET Core sample web application using .Net Web Api Core and PostgreSQL with Docker support.
Both the Web Applicaiton and the Postgres DB runs in container. 
Added Swagger support to interact with API’s resources.

## Prerequisites
1. [Docker](https://www.docker.com/)
2. [.NET Core SDK 2.2](https://dotnet.microsoft.com/download/dotnet-core/2.2)

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

## Steps to run an application
1.  clone repository

2. `cd docker-aspnetcore-postgresql`

3. `docker-compose build`

4. `docker-compose up`

5.  Navigate to http://localhost:8000/swagger (you should see the API methods in a user-friendly UI)

6. `docker run --network host --rm --name curl pstauffer/curl:latest curl http://localhost:8000/api/todo` (GET request to display the list of todo items available in the db)

7. `docker run --network host --rm --name curl pstauffer/curl:latest curl -X POST  -H "Content-Type: application/json" http://localhost:8000/api/todo -d "{\"title\":\"Do some coding !!!\", \"StartDate\":\"2019-04-20\", \"EndDate\":\"2019-04-20\", \"Priority\":\"High\"}"` 
  (POST request to save a new todo item in the db)

9. `docker run --network host --rm --name curl pstauffer/curl:latest curl http://localhost:8000/api/todo/1` (GET request to display the details of a todo item with id=1)