using Respawn.API.Endpoints.Products;
using Respawn.API.Endpoints.Users;
using Respawn.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterServices();

var app = builder.Build();

app.RegisterApps();

// Users
app.MapGetUsers();

// Products
app.MapGetProducts();


app.Run();
