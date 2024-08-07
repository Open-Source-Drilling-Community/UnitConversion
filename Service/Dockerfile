FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Declaring environment variables for private NuGet feed authentication
ARG NORCE_NUGET_USER
ARG NORCE_NUGET_APIKEY
# Passing root CA to allow for https connection behind firewall
ADD ./NORCE_CA.cer /usr/local/share/ca-certificates/foo.crt
RUN chmod 644 /usr/local/share/ca-certificates/foo.crt && update-ca-certificates

WORKDIR /src
COPY ["Service/Service.csproj", "Service/"]
COPY ./nuget.config .
RUN dotnet restore "Service/Service.csproj"

COPY . .
WORKDIR "/src/Service"
RUN dotnet build "Service.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Service.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
VOLUME /home
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Service.dll"]
