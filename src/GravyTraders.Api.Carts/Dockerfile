FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["gravyTraders.Api.Carts/gravyTraders.Api.Carts.csproj", "gravyTraders.Api.Carts/"]
COPY ["gravyTraders.Api.Core/gravyTraders.Api.Core.csproj", "gravyTraders.Api.Core/"]
RUN dotnet restore "gravyTraders.Api.Carts/gravyTraders.Api.Carts.csproj"
COPY . .
WORKDIR "/src/gravyTraders.Api.Carts"
RUN dotnet build "gravyTraders.Api.Carts.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "gravyTraders.Api.Carts.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "gravyTraders.Api.Carts.dll"]