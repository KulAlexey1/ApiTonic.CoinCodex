using ApiTonic.API.Queries;
using ApiTonic.CoinCodex.ClientLibrary.Models;
using ApiTonic.CoinCodex.API.Models;
using StackExchange.Redis;
using ApiTonic.CoinCodex.API.Extensions;
using ApiTonic.CoinCodex.ClientLibrary.Extensions;

var builder = WebApplication.CreateBuilder(args);

var graphQLSettings = builder.Configuration.GetSection("ApiTonic:GraphQL").Get<GraphQLSettings>();

var services = builder.Services;

services.Configure<ApiSettings>(
    builder.Configuration.GetSection("ApiTonic:CoinCodexAPI"));
services.AddCors();

services
    .AddSingleton(ConnectionMultiplexer.Connect(graphQLSettings.RedisAddress))
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .InitializeOnStartup()
    .PublishSchemaDefinitionToRedis(graphQLSettings);

services.AddClientLibraryServices();

var app = builder.Build();

app.MapGraphQL();

app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .AllowCredentials()
    .SetIsOriginAllowed(origin => true)
);

app.Run();
