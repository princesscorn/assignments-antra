using MovieShopApp.Core.Contracts.Repositories;
using MovieShopApp.Core.Contracts.Services;
using MovieShopApp.Infrastructure.Datas;
using MovieShopApp.Infrastructure.Repositories;
using MovieShopApp.Infrastructure.Services;

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


// Add Repository of MovieShop
builder.Services.AddScoped<IMovieRepositoryAsync, MovieRepositoryAsync>();
builder.Services.AddScoped<ICastRepositoryAsync, CastRepositoryAsync>();
builder.Services.AddScoped<IMovieCastRepositoryAsync, MovieCastRepositoryAsync>();

// Add Service of MovieShop
builder.Services.AddScoped<IMovieServiceAsync, MovieServiceAsync>();
builder.Services.AddScoped<ICastServiceAsync, CastServiceAsync>();
builder.Services.AddScoped<IMovieCastServiceAync, MovieCastServiceAsync>();






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

app.UseAuthorization();

app.MapControllers();

app.Run();
