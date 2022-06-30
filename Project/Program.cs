using Microsoft.EntityFrameworkCore;
using Project.DataAccessLayer;
using Project.DataAccessLayer.Interface;
using Project.Services;
using Project.Services.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<Context>(options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
    });
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository,UserRepository>();

builder.Services.AddSwaggerGen();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
