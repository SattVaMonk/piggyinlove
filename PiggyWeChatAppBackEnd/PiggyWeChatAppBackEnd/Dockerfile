FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["PiggyWeChatAppBackEnd/PiggyWeChatAppBackEnd.csproj", "PiggyWeChatAppBackEnd/"]
RUN dotnet restore "PiggyWeChatAppBackEnd/PiggyWeChatAppBackEnd.csproj"
COPY . .
WORKDIR "/src/PiggyWeChatAppBackEnd"
RUN dotnet build "PiggyWeChatAppBackEnd.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "PiggyWeChatAppBackEnd.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "PiggyWeChatAppBackEnd.dll"]