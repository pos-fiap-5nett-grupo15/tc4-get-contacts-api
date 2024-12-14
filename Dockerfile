FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /App

COPY ./GetContact/.

RUN dotnet restore  ./GetContact.csproj
RUN dotnet build ./GetContact.csproj
RUN dotnet publish  ./GetContact.csproj -c Release --output Out --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

WORKDIR /App
COPY --from=build /App/Out/ ./

ENTRYPOINT ["dotnet", "GetContact.dll"]