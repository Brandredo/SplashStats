FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SplashStats.API.csproj", "./"]
RUN dotnet restore "SplashStats.API.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "SplashStats.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SplashStats.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SplashStats.API.dll"]
