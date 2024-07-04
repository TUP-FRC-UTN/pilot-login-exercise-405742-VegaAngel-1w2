using AltaPiloto.Models;
using AltaPiloto.Repository.Imp;
using AltaPiloto.Repository.Interfaz;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IPilotoRepository,PilotoRepository>();
builder.Services.AddScoped<NacionalidadRepository,NacionalidadRepository>();
builder.Services.AddScoped<LoginRepository,LoginRepository>();


builder.Services.AddDbContext<PilotoContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("CadenaConexion"));
});

builder.Services.AddFluentValidation((options) =>
options.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly())
);


var app = builder.Build();


app.UseCors(options =>
{
    options.AllowAnyHeader();
    options.AllowAnyOrigin();
    options.AllowAnyMethod();
});

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
