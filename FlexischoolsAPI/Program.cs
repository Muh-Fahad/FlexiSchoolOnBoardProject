using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using Repositories.Repository;
using Repositories;
using Services.Interfaces;
using FlexischoolsAPI.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IService, Services.Service.Services>();
builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddDbContextPool<ApplicationDbContext>(builder =>
{
    builder.UseInMemoryDatabase(Guid.NewGuid().ToString());
});
builder.Services.AddScoped<ExceptionHandler>();
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
app.UseMiddleware<ExceptionHandler>();
app.Run();
