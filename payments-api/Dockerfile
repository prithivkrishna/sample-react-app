# Stage 1: Build the application
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY . .

RUN dotnet publish -c Release -o out

# Stage 2: Run the application
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime

WORKDIR /app

COPY --from=build /app/out ./

EXPOSE 80

ENTRYPOINT ["dotnet", "payments-api.dll"]
