#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MsfConsulting.Student.Api/MsfConsulting.Student.Api.csproj", "MsfConsulting.Student.Api/"]
RUN dotnet restore "MsfConsulting.Student.Api/MsfConsulting.Student.Api.csproj"
COPY . .
WORKDIR "/src/MsfConsulting.Student.Api"
RUN dotnet build "MsfConsulting.Student.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MsfConsulting.Student.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MsfConsulting.Student.Api.dll"]