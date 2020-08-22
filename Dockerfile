FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["SLB-Clock/SLB-Clock.csproj", "SLB-Clock/"]
RUN dotnet restore "SLB-Clock/SLB-Clock.csproj"
COPY . .
WORKDIR "/src/SLB-Clock"
RUN dotnet build "SLB-Clock.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "SLB-Clock.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "SLB-Clock.dll"]