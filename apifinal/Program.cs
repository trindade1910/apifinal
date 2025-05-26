using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using apifinal.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<apifinalContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("apifinalContext") ?? throw new InvalidOperationException("Connection string 'apifinalContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
