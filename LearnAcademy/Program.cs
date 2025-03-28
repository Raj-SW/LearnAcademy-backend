using LearnAcademy.BusinessLayer;
using LearnAcademy.Controllers;
using LearnAcademy.DAL;
using LearnAcademyBL.Interfaces;
using LearnAcademyDAL.Interfaces;
using System.ComponentModel;
using Unity;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IAuthenticationDAL, AuthenticationDAL>();
builder.Services.AddScoped<IAuthenticationBL, AuthenticationBL>();

// Add services to the container.
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder =>
        {
            builder.WithOrigins("http://localhost:5173")
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Enable CORS before Authorization and other middleware
app.UseCors("AllowSpecificOrigin");

app.UseAuthorization();

app.MapControllers();

app.Run();
