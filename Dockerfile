FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /app

COPY *.csproj ./
RUN dotnet restore dockerapi.csproj

COPY . ./
RUN dotnet publish dockerapi.csproj -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS runtime

WORKDIR /app

COPY --from=build /app/out .

ENTRYPOINT ["dotnet", "dockerapi.dll"]
ENV ASPNETCORE_URLS=http://+:8000