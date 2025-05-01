FROM mcr.microsoft.com/dotnet/aspnet:9.0

COPY result /app

ENTRYPOINT [ "dotnet", "/app/CSProject.dll" ]

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

#b
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["WeatherApi/WeatherApi.csproj", "WeatherApi/"]
RUN dotnet restore "WeatherApi/WeatherApi.csproj"
COPY . .
WORKDIR "/src/WeatherApi"
RUN dotnet build "WeatherApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WeatherApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WeatherApi.dll"]


# c
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["UserApi/UserApi.csproj", "UserApi/"]
RUN dotnet restore "UserApi/UserApi.csproj"
COPY . .
WORKDIR "/src/UserApi"
RUN dotnet build "UserApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "UserApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "UserApi.dll"]
