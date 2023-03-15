using JobSeek.Api.Data;
using JobSeek.Api.Models.Entities;
using JobSeek.Api.Repository;
using JobSeek.Api.Repository.Contracts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContextFactory<DataContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IJobCategoryRepository, JobCategoryRepository>();


var app = builder.Build();

var dbContext = app.Services.GetRequiredService<IDbContextFactory<DataContext>>();
DataInitializer.Initialize(dbContext.CreateDbContext());

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
