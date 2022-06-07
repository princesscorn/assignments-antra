using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using MovieStoreApp.Core.Contract.Repository;
using MovieStoreApp.Core.Contract.Service;
using MovieStoreApp.Core.Entity;
using MovieStoreApp.Infrastructure.Data;
using MovieStoreApp.Infrastructure.Repository;
using MovieStoreApp.Infrastructure.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(option =>
{
    option.AddDefaultPolicy(x => 
        {
            //x.WithExposedHeaders("http://localhost:4200").AllowAnyHeader().AllowAnyMethod();
            x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
        });
});

//Add context of MovieStore
builder.Services.AddSqlServer<MovieContext>(builder.Configuration.GetConnectionString("MovieStore"));

// Add Identity, we don't need special Role class, just use the system default IdentityRole to create role table
// If we don't need FirstName and LastName, we can just use the system default IdentityUser
builder.Services.AddIdentity<MovieUser, IdentityRole>()
    .AddEntityFrameworkStores<MovieContext>().AddDefaultTokenProviders();

//repository of Cast
builder.Services.AddScoped<ICastRepositoryAsync, CastRepositoryAsync>();
//repository of Genre
builder.Services.AddScoped<IGenreRepositoryAsync, GenreRepositoryAsync>();
//repository of Account
builder.Services.AddScoped<IAccountRepositoryAsync, AccountRepositoryAsync>();



//services of Cast
builder.Services.AddScoped<ICastServiceAsync, CastServiceAsync>();
//services of Genre
builder.Services.AddScoped<IGenreServiceAsync, GenreServiceAsync>();
//services of Account
builder.Services.AddScoped<IAccountServiceAsync, AccountServiceAsync>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();       // controller/action method

app.Run();
