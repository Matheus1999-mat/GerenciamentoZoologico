using GerenciamentoZoologico.Data;
using GerenciamentoZoologico.Repositories;
using GerenciamentoZoologico.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddScoped<IAnimaisRepository, AnimaisRepository>();
builder.Services.AddScoped<ICuidadosRepository, CuidadosRepository>();

var connectionString = builder.Configuration.GetConnectionString("Main");
builder.Services.AddDbContext<GerenciamentoZoologicoDBContext>(
    options => options.UseSqlServer(connectionString));



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
