using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using revisao.data.AppData;
using revisao.data.Repository;
using RevisaoAula1.Application.Interfaces;
using RevisaoAula1.Application.Services;
using RevisaoAula1.Domain.Interfaces;

namespace revisao.IoC;

public class Bootstrap
{
    public static void Start(IServiceCollection service, IConfiguration configuration) 
    {
        service.AddDbContext<ApplicationContext>(options =>
        {
            var connectionString = configuration.GetConnectionString("MySql");
            var serverVersion = ServerVersion.AutoDetect(connectionString);
            options.UseMySql(connectionString, serverVersion);
        });

        service.AddTransient<IClientRepository, ClientRepository>();
        service.AddScoped<IClientService, ClientService>();
    }
}
