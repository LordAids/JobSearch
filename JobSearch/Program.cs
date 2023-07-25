using JobSearch.Data;
using JobSearch.MainService.Interfaces;
using JobSearch.MainService.Services;
using Microsoft.EntityFrameworkCore;
using SuperJob.API.Interfaces;
using SuperJob.API.Services;
using System.ComponentModel.Design;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationDbContext>(opt =>
                opt.UseNpgsql(connectionString, b => b.MigrationsAssembly("JobSearch")));


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ISearchService, SearchService>();


//SuperJob Services
builder.Services.AddScoped<SuperJob.API.Interfaces.IDictionaryService, DictionaryService>();

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
