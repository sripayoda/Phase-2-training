using JwtAuth.Models;
using JwtAuth.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<PayodaStudentContext>(
    optionsAction : options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("SqlConnection")
        )
    );

builder.Services.AddScoped<IStudent, StudentServices>();
builder.Services.AddScoped<IUser, UserService>();
builder.Services.AddScoped<IToken, TokenService> ();

// In ConfigureServices method
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = false,
            ValidateIssuerSigningKey = true,
            ValidIssuer = "Sriram",    // Set the issuer you used while generating tokens
            //ValidAudience = "your_audience",  // Set the audience you used while generating tokens
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("I love Tommy and biriyani")),
            // Other validation parameters as needed
        };
    });

// In ConfigureServices method
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Your API", Version = "v1" });

    // Configure Swagger to use JWT authorization
    var securityScheme = new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "JWT Authorization header using the Bearer scheme.",
    };
    /*c.AddSecurityDefinition("Bearer", securityScheme);
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        { securityScheme, new[] { "Bearer" } },
    });*/
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication (); //always authentication must come before authorization

app.UseAuthorization();

app.MapControllers();

app.Run();
