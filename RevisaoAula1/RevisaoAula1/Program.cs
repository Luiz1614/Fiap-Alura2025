using Microsoft.EntityFrameworkCore;
using revisao.data.AppData;
using revisao.data.Repository;
using RevisaoAula1.Application.Interfaces;
using RevisaoAula1.Application.Services;
using RevisaoAula1.Domain.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Configurar o ApplicationContext
builder.Services.AddDbContext<ApplicationContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("MySql");
    var serverVersion = ServerVersion.AutoDetect(connectionString);
    options.UseMySql(connectionString, serverVersion);
});

builder.Services.AddTransient<IClientRepository, ClientRepository>();
builder.Services.AddScoped<IClientService, ClientService>();

// Configurar controllers e Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configurar o pipeline de requisições HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();