using LeaderBoard.DAL.DataAccess;
using LeaderBoard.DAL.DataAccess.Interfaces;
using LeaderBoard.Infrastructure.Commands.CommandHandlers;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<ITeamRepository, TeamRepository>();
// Fix for CS1503
builder.Services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(IncrementCounterCommandHandler).Assembly));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Steps Leaderboard API",
        Version = "v1",
        Description = "API for managing teams and step counters in a company-wide leaderboard"
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
