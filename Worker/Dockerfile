FROM microsoft/dotnet:1.1.0-sdk-projectjson

WORKDIR /dotnetapp

# copy project.json and restore as distinct layers
COPY project.json .
RUN dotnet restore

# copy and build everything else
COPY . .
RUN dotnet build -C Release
ENTRYPOINT ["dotnet", "run", "-C", "Release"]