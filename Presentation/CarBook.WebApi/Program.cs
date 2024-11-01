using CarBook.Application.Services;
using CarBook.WebApi.Hubs;
using CarBook.WebApi.Services;
using CarBook.WebUI.Token;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// HTTP Client
builder.Services.AddHttpClient();

// CORS Policy
builder.Services.AddCorsPolicy();

// SignalR
builder.Services.AddSignalR();

// JWT Authentication
builder.Services.AddJwtAuthentication(builder.Configuration);

// Fluent Validation
builder.Services.AddFluentValidationServices();

// Add services to the container
builder.Services.AddServices();
builder.Services.AddApplicationService(builder.Configuration);

// Add controllers and configure Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors("CorsPolicy");
app.UseHttpsRedirection();
app.UseMiddleware<TokenBlacklistMiddleware>(); // Blacklist kontrolü için middleware
app.UseAuthentication();
app.UseAuthorization();

// Map controllers and hubs
app.MapControllers();
app.MapHub<CarHub>("/carhub");

app.Run();
