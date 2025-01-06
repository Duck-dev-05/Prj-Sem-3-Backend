using Microsoft.AspNetCore.Authentication.JwtBearer;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // JWT Bearer Authentication Setup
        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(static options =>
            {
                // Set the Authority URL (the URL that issues the JWT tokens)
                options.Authority = "https://your-identity-server-url.com"; // Use HTTPS for production
                options.Audience = "your-api-audience";  // Your API's audience value

                // Allow HTTP for development environments (disable RequireHttpsMetadata)
                options.RequireHttpsMetadata = !Environment.IsDevelopment();
            });

        // Add MVC or controllers, etc.
        services.AddControllers();
        services.AddAuthorization();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        // Use Authentication and Authorization middleware
        app.UseAuthentication();
        app.UseAuthorization();

        // Map the controllers
        app.UseEndpoints(static endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
