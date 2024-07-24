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
# Copy the ModelShared project
COPY ["../ModelShared/ModelShared.csproj", "ModelShared/"]

COPY ["WebApp/WebApp.csproj", "WebApp/"]
COPY ./nuget.config .
RUN dotnet restore "WebApp/WebApp.csproj"

COPY . .
WORKDIR "/src/WebApp"
RUN dotnet build "WebApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApp.dll"]