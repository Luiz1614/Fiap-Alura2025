using RevisaoAula1.Domain.Entities;
using RevisaoAula1.Domain.Interfaces;
using RevisaoAula1.Infraestructure.Data.AppData;

namespace RevisaoAula1.Infraestructure.Data.Repository;

public class ClientRepository : IClientRepository
{
    private readonly ApplicationContext _context;

    public ClientRepository(ApplicationContext context)
    {
        _context=context;
    }

    public IEnumerable<ClientEntity> GetAll()
    {
        var clients = _context.Cliente.ToList();
        return clients;
    }
}
