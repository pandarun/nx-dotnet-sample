FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine AS build-env
WORKDIR /app

COPY ./NxDotnetWorkspace.WeatherApi2.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -r linux-musl-x64 -o out

FROM mcr.microsoft.com/dotnet/runtime-deps:6.0-alpine

# Configure web servers to bind to port 80 when present
ENV ASPNETCORE_URLS=http://+:8081 \
    # Enable detection of running in a container
    DOTNET_RUNNING_IN_CONTAINER=true \
    # Set the invariant mode since icu_libs isn't included (see https://github.com/dotnet/announcements/issues/20)
    DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=true


WORKDIR /app
COPY --from=build-env /app/out .

ENTRYPOINT ["./NxDotnetWorkspace.WeatherApi2"]
