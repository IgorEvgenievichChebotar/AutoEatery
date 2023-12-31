using AutoEatery.Data;
using AutoEatery.GraphQL.Schemas;
using EasyNetQ;
using GraphQL;
using GraphQL.Types;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<ISchema, EaterySchema>();
builder.Services.AddGraphQL(graphQlBuilder => graphQlBuilder.AddSystemTextJson());

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddDbContext<EateryDbContext>(opt =>
    opt.UseSqlite(builder.Configuration.GetConnectionString("Sqlite")));

var bus = RabbitHutch.CreateBus(builder.Configuration.GetConnectionString("AutoRabbitMQ"));
builder.Services.AddSingleton(bus);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    // Configure the HTTP request pipeline.
    app.UseSwagger();
    app.UseSwaggerUI();

    app.UseGraphQLPlayground();
}

app.UseGraphQL<ISchema>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();