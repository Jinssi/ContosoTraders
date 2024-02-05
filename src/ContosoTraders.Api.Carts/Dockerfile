FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["GravyTraders.Api.Carts/GravyTraders.Api.Carts.csproj", "GravyTraders.Api.Carts/"]
COPY ["GravyTraders.Api.Core/GravyTraders.Api.Core.csproj", "GravyTraders.Api.Core/"]
RUN dotnet restore "GravyTraders.Api.Carts/GravyTraders.Api.Carts.csproj"
COPY . .
WORKDIR "/src/GravyTraders.Api.Carts"
RUN dotnet build "GravyTraders.Api.Carts.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GravyTraders.Api.Carts.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GravyTraders.Api.Carts.dll"]