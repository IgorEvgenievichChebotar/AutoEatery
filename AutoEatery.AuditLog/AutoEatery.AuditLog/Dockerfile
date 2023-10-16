FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["AutoEatery.AuditLog/AutoEatery.AuditLog.csproj", "AutoEatery.AuditLog/"]
RUN dotnet restore "AutoEatery.AuditLog/AutoEatery.AuditLog.csproj"
COPY . .
WORKDIR "/src/AutoEatery.AuditLog"
RUN dotnet build "AutoEatery.AuditLog.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AutoEatery.AuditLog.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AutoEatery.AuditLog.dll"]
