#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 2000

FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine as build
WORKDIR /src
COPY ["Npf.Process.Selections.Api/Npf.Process.Selections.Api.csproj", "Npf.Process.Selections.Api/"]
COPY . .
WORKDIR "/src/Npf.Process.Selections.Api"
RUN dotnet build "Npf.Process.Selections.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Npf.Process.Selections.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Npf.Process.Selections.Api.dll"]