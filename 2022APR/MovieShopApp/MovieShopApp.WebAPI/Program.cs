using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using MovieShopApp.Core.Contracts.Repositories;
using MovieShopApp.Core.Contracts.Services;
using MovieShopApp.Core.Entities;
using MovieShopApp.Infrastructure.Datas;
using MovieShopApp.Infrastructure.Repositories;
using MovieShopApp.Infrastructure.Services;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();




// Add CORS of MoiveShop
builder.Services.AddCors(option =>
{
    option.AddDefaultPolicy(x =>
    {
        //x.WithExposedHeaders("http://localhost:4200").AllowAnyHeader().AllowAnyMethod();
        x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

// Add context of MovieShop which configured in appsettings.json
builder.Services.AddSqlServer<MovieDbContext>(builder.Configuration.GetConnectionString("MovieShop"));

// Add Service of MovieUser's Identity
// Add Identity, we don't need special Role class, just use the system default IdentityRole to create role table
// If we don't need FirstName and LastName, we can just use the system default IdentityUser
builder.Services.AddIdentity<MovieUser, IdentityRole>().AddEntityFrameworkStores<MovieDbContext>().AddDefaultTokenProviders();


// Add Authentication of MovieUsers
builder.Services.AddAuthentication(option =>
{
    option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    option.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(option =>
{
    option.SaveToken = true;
    option.RequireHttpsMetadata = false;
    option.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidIssuer = builder.Configuration["JWT:ValidIssuer"],
        ValidAudience = builder.Configuration["JWT:ValidAudience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:SecurityKey"]))
    };
    });



// Add Repository of MovieShop
builder.Services.AddScoped<IMovieRepositoryAsync, MovieRepositoryAsync>();
builder.Services.AddScoped<ICastRepositoryAsync, CastRepositoryAsync>();
builder.Services.AddScoped<IGenreRepositoryAsync, GenreRepositoryAsync>();
builder.Services.AddScoped<IMovieCastRepositoryAsync, MovieCastRepositoryAsync>();
builder.Services.AddScoped<IAccountRepositoryAsync, AccountRepositoryAsync>();


// Add Service of MovieShop
builder.Services.AddScoped<IMovieServiceAsync, MovieServiceAsync>();
builder.Services.AddScoped<ICastServiceAsync, CastServiceAsync>();
builder.Services.AddScoped<IGenreServiceAsync, GenreServiceAsync>();
builder.Services.AddScoped<IMovieCastServiceAync, MovieCastServiceAsync>();
builder.Services.AddScoped<IAccountServiceAsync, AccountServiceAsync>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Use Cors by MovieShop
app.UseCors();

app.UseHttpsRedirection();

app.UseAuthentication();        // MovieShop Authentication, must before Authorization

app.UseAuthorization();



app.MapControllers();

app.Run();
