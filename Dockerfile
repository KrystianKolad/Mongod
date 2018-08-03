FROM microsoft/aspnetcore:2.0.0

COPY .artifacts/. app/

ENV ASPNETCORE_URLS="http://+:5000"
ENV ASPNETCORE_ENVIRONMENT production

WORKDIR app

ENTRYPOINT dotnet Mongod.dll
