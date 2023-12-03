# Use a imagem de construção
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app

# Copie o arquivo de solução e execute a restauração de pacotes
COPY SmartSchool.sln ./
RUN dotnet restore

# Copie o restante dos arquivos do projeto
COPY . .

# Publique o aplicativo
RUN dotnet publish -c release -o /app

# Imagem final
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "SmartSchool.dll"]
