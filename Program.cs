using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

var builder = WebApplication.CreateBuilder(args);


//Add services to the container 
builder.Services.AddControllers();

//Configure Auth
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
       .AddJwtBearer(options =>
       {
        options.Authority = "#";
        options.Audience = "#";
       });

//Add Authorization
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminOnly",policy =>
    policy.RequireRole("Admin"));
});

var app = builder.Build();

//Configure the HTTP request 
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();

//Middleware
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();