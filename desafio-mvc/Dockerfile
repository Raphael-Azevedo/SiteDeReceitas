FROM mcr.microsoft.com/dotnet/aspnet:5.0
LABEL version="1.0.3" description="Aplicacao ASP .NET Core MVC"
COPY dist /app
WORKDIR /app
EXPOSE 80/tcp
ENTRYPOINT [ "dotnet","desafio-mvc.dll" ]