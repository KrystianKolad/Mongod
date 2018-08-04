FROM microsoft/dotnet:2.0-sdk as builder

COPY . /source/

WORKDIR /source/src/Mongod

RUN dotnet publish -o ../../artifacts

FROM microsoft/aspnetcore:2.0.0

COPY --from=builder /source/artifacts/. app/

ENV ASPNETCORE_URLS="http://+:5000"
ENV ASPNETCORE_ENVIRONMENT production

WORKDIR app

ENTRYPOINT dotnet Mongod.dll
