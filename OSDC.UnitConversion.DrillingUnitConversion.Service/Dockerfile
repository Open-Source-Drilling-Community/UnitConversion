FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /src
COPY ["OSDC.UnitConversion.DrillingUnitConversion.Model/OSDC.UnitConversion.DrillingUnitConversion.Model.csproj", "OSDC.UnitConversion.DrillingUnitConversion.Model/"]
COPY ["OSDC.UnitConversion.DrillingUnitConversion.Service/OSDC.UnitConversion.DrillingUnitConversion.Service.csproj", "OSDC.UnitConversion.DrillingUnitConversion.Service/"]

RUN dotnet restore "OSDC.UnitConversion.DrillingUnitConversion.Service/OSDC.UnitConversion.DrillingUnitConversion.Service.csproj"

COPY . .
WORKDIR "/src/OSDC.UnitConversion.DrillingUnitConversion.Service"
RUN dotnet build "OSDC.UnitConversion.DrillingUnitConversion.Service.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "OSDC.UnitConversion.DrillingUnitConversion.Service.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
VOLUME /home
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "OSDC.UnitConversion.DrillingUnitConversion.Service.dll"]