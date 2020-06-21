FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["Chatterer-server/Chatterer-server.csproj", "Chatterer-server/"]
RUN dotnet restore "Chatterer-server/Chatterer-server.csproj"
COPY . .
WORKDIR "/src/Chatterer-server"
RUN dotnet build "Chatterer-server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Chatterer-server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Chatterer-server.dll"]
