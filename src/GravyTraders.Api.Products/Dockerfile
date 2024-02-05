FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["gravyTraders.Api.Products/gravyTraders.Api.Products.csproj", "gravyTraders.Api.Products/"]
COPY ["gravyTraders.Api.Core/gravyTraders.Api.Core.csproj", "gravyTraders.Api.Core/"]
RUN dotnet restore "gravyTraders.Api.Products/gravyTraders.Api.Products.csproj"
COPY . .
WORKDIR "/src/gravyTraders.Api.Products"
RUN dotnet build "gravyTraders.Api.Products.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "gravyTraders.Api.Products.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "gravyTraders.Api.Products.dll"]