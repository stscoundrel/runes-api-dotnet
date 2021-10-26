# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /source

# copy csproj and restore as distinct layers
COPY *.sln .
COPY src/*.csproj ./src/
COPY tests/*.csproj ./tests/
RUN dotnet restore --verbosity detailed ./src/RunesAPI.csproj
RUN dotnet restore --verbosity detailed ./tests/RunesAPITests.csproj

# copy everything else and build app
COPY src/. ./src/
COPY tests/. ./tests/
WORKDIR /source/src
RUN dotnet publish -c release -o /app

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "RunesAPI.dll"]