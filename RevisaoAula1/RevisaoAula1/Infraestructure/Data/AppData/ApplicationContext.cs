using Microsoft.EntityFrameworkCore;
using RevisaoAula1.Domain.Entities;

namespace RevisaoAula1.Infraestructure.Data.AppData;

public class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {
        
    }

    public DbSet<ClientEntity> Cliente { get; set; }
}
