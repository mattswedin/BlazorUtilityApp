using Microsoft.EntityFrameworkCore; //interact with database using EF Core features
using WebApi.Models;


var builder = WebApplication.CreateBuilder(args); //initializes services, args passed in from the command line when ran

// Add services to the container.

builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))) //sets up DataContext to connect to the Azure SQL Database using connection string in appsettings.json file (DefaultConnection is the Key)

builder.Services.AddControllers(); // allows app to use controller classes

var app = builder.Build(); //finalizes steps above

// Configure the HTTP request pipeline.

app.UseHttpsRedirection(); //ensures HTTP (Hypertext Transfer Protocol) requests are redirected to HTTPS (Hypertext Transfer Protocol Secure)
app.MapControllers(); //maps controller routes, allows app to know which HTTP requests should be handled by the controllers

app.Run(); //starts the web app and begins listening for incoming HTTP requests.
