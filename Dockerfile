FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
# ENV VSS_NUGET_EXTERNAL_FEED_ENDPOINTS="{`"endpointCredentials`": [{`"endpoint`":`"https://pkgs.dev.azure.com/caiomaiavms-fiap/tech-challenge-3/_packaging/tech3/nuget/v3/index.json`", `"username`":`"docker`", `"password`":`"${FEED_ACCESSTOKEN}`"}]}"
# RUN echo $VSS_NUGET_EXTERNAL_FEED_ENDPOINTS

WORKDIR /App

COPY ./GetContact/. ./

RUN dotnet restore  ./GetContact.Api/GetContact.Api.csproj
RUN dotnet build ./GetContact.Api/GetContact.Api.csproj
RUN dotnet publish  ./GetContact.Api/GetContact.Api.csproj -c Release --output Out --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

WORKDIR /App
COPY --from=build /App/Out/ ./

ENTRYPOINT ["dotnet", "GetContact.Api.dll"]


