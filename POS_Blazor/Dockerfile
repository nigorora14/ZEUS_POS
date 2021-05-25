#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["POS_Blazor/POS_Blazor.csproj", "POS_Blazor/"]
RUN dotnet restore "POS_Blazor/POS_Blazor.csproj"
COPY . .
WORKDIR "/src/POS_Blazor"
RUN dotnet build "POS_Blazor.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "POS_Blazor.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "POS_Blazor.dll"]