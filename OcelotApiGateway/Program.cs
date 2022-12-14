using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using OcelotApiGateway;
using OcelotApiGateway.Middleware;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("ocelot.json");

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddLogging(logging => logging.AddConsole());

// adding ocelot
builder.Services.AddOcelot()
    .AddDelegatingHandler<RemoveEncodingDelegatingHandler>(true)
    .AddSingletonDefinedAggregator<ObservationsProgressNotesAggregator>();

builder.Services.AddApiToken(builder.Configuration);

var app = builder.Build();

app.UseApiKeyMiddleware();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseOcelot().Wait();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
