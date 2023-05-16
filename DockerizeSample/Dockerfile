# All lines that begin with # are considered as comment

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY . .
RUN dotnet restore "./DockerizeSample.csproj"
RUN dotnet build "./DockerizeSample.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DockerizeSample.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .
RUN ln -snf /usr/share/zoneinfo/Asia/Tehran /etc/localtime

EXPOSE 80

ENTRYPOINT ["dotnet", "DockerizeSample.dll"]