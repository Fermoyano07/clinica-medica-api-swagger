using ClinicaMedica.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configuracion de la cadena de conexión a la base de datos SQL Server
var connectionString = builder.Configuration.GetConnectionString("ClinicaDB");

// Agregar los servicios al contenedor
builder.Services.AddDbContext<ClinicaContext>(options =>
    options.UseSqlServer(connectionString));


builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Agregar servicios para controladores
var app = builder.Build();

// Configuracion del pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
