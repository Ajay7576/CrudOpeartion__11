using login_register_Encryption_Hashing__Verification_11.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


string connectionString = builder.Configuration.GetConnectionString("defaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>
   (option => option.UseSqlServer(connectionString));

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "Authentication",
        builder =>
        {
            builder.WithOrigins("http://localhost:3000/")
            .AllowAnyOrigin()
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


app.UseCors("Authentication");


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
