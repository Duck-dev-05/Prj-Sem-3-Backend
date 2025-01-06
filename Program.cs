using Microsoft.AspNetCore.Authentication.JwtBearer;

var builder = WebApplication.CreateBuilder(args);

// Configure services
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        // Set the Authority URL (the URL that issues the JWT tokens)
        options.Authority = "https://your-identity-server-url.com"; // Use HTTPS for production
        options.Audience = "your-api-audience";  // Your API's audience value

        // Allow HTTP for development environments (disable RequireHttpsMetadata)
        options.RequireHttpsMetadata = !builder.Environment.IsDevelopment();
    });

// Add other services such as controllers, authorization, etc.
builder.Services.AddControllers();
builder.Services.AddAuthorization();

var app = builder.Build();

// Middleware configuration
app.UseAuthentication();  // Use JWT Authentication
app.UseAuthorization();   // Use Authorization

// Map endpoints for controllers
app.MapControllers();

app.Run();
