#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["EPC.API/EPC.API.csproj", "EPC.API/"]
COPY ["EPC.Model/EPC.Model.csproj", "EPC.Model/"]
RUN dotnet restore "EPC.API/EPC.API.csproj"
COPY . .
WORKDIR "/src/EPC.API"
RUN dotnet build "EPC.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EPC.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EPC.API.dll"]