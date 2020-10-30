FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 5000
RUN mkdir /cores && chmod 0777 /cores

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["netcorecrasher/netcorecrasher.csproj", "netcorecrasher/"]
RUN dotnet restore "netcorecrasher/netcorecrasher.csproj"
COPY . .
WORKDIR "/src/netcorecrasher"
RUN dotnet build "netcorecrasher.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "netcorecrasher.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "netcorecrasher.dll"]