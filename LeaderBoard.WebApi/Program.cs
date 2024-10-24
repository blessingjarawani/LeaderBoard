using LeaderBoard.DAL.DataAccess;
using LeaderBoard.DAL.DataAccess.Interfaces;
using LeaderBoard.Infrastructure.Commands.CommandHandlers;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<ITeamRepository, TeamRepository>();
// Fix for CS1503
builder.Services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(IncrementCounterCommandHandler).Assembly));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
