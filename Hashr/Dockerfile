FROM microsoft/dotnet:latest

WORKDIR /app

ADD project.json project.json

RUN ["dotnet", "restore"]

ADD . .

RUN ["dotnet", "build", "-c", "Release"]

EXPOSE 80/tcp

CMD ["dotnet", "run", "-c", "Release", "--server.urls", "http://*:80"]
