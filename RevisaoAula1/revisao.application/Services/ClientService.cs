using RevisaoAula1.Application.Interfaces;
using RevisaoAula1.Domain.Entities;
using RevisaoAula1.Domain.Interfaces;

namespace RevisaoAula1.Application.Services;

public class ClientService : IClientService
{
    private readonly IClientRepository _clientRepository;

    public ClientService(IClientRepository clientRepository)
    {
        _clientRepository=clientRepository;
    }

    public IEnumerable<ClientEntity> GetAllClientes()
    {
        return _clientRepository.GetAll();
    }
}
