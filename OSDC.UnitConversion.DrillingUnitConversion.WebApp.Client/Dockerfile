FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build

ARG NORCE_NUGET_USER 
ARG NORCE_NUGET_APIKEY 
ADD ./NORCE_CA.cer /usr/local/share/ca-certificates/foo.crt
RUN chmod 644 /usr/local/share/ca-certificates/foo.crt && update-ca-certificates

WORKDIR /src

COPY ["OSDC.UnitConversion.DrillingUnitConversion.ModelClientShared/OSDC.UnitConversion.DrillingUnitConversion.ModelClientShared.csproj", "OSDC.UnitConversion.DrillingUnitConversion.ModelClientShared/"]
COPY ["OSDC.UnitConversion.DrillingUnitConversion.WebApp.Client/OSDC.UnitConversion.DrillingUnitConversion.WebApp.Client.csproj", "OSDC.UnitConversion.DrillingUnitConversion.WebApp.Client/"]
COPY ./nuget.config .
RUN dotnet restore "OSDC.UnitConversion.DrillingUnitConversion.WebApp.Client/OSDC.UnitConversion.DrillingUnitConversion.WebApp.Client.csproj"

COPY . .
WORKDIR "/src/OSDC.UnitConversion.DrillingUnitConversion.WebApp.Client"
RUN dotnet build "OSDC.UnitConversion.DrillingUnitConversion.WebApp.Client.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OSDC.UnitConversion.DrillingUnitConversion.WebApp.Client.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OSDC.UnitConversion.DrillingUnitConversion.WebApp.Client.dll"]