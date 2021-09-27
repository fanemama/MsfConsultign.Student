#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MsfConsultign.Student.Api/MsfConsultign.Student.Api.csproj", "MsfConsultign.Student.Api/"]
RUN dotnet restore "MsfConsultign.Student.Api/MsfConsultign.Student.Api.csproj"
COPY . .
WORKDIR "/src/MsfConsultign.Student.Api"
RUN dotnet build "MsfConsultign.Student.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MsfConsultign.Student.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MsfConsultign.Student.Api.dll"]