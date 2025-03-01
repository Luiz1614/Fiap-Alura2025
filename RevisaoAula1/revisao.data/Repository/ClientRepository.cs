using revisao.data.AppData;
using RevisaoAula1.Domain.Entities;
using RevisaoAula1.Domain.Interfaces;

namespace revisao.data.Repository;

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
