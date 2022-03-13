#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/SendIt.API/SendIt.API.csproj", "src/SendIt.API/"]
RUN dotnet restore "src/SendIt.API/SendIt.API.csproj"
COPY . .
WORKDIR "/src/src/SendIt.API"
RUN dotnet build "SendIt.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SendIt.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SendIt.API.dll"]