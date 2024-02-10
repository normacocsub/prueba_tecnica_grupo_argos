FROM mcr.microsoft.com/dotnet/sdk:8.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Presentation/", "Presentation/"]
COPY ["Domain/", "Domain/"]
COPY ["Infrastructure/", "Infrastructure/"]
COPY ["Application/", "Application/"]

RUN dotnet restore "Presentation/Presentation.csproj" -r linux-arm64
COPY . .
WORKDIR "/src/Presentation"
RUN ls 
RUN dotnet build "Presentation.csproj" -c Release -o /app/build

FROM build AS publish
WORKDIR "/src/Presentation"
RUN dotnet publish "Presentation.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Presentation.dll"]