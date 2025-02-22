using RevisaoAula1.Domain.Entities;

namespace RevisaoAula1.Application.Interfaces;

public interface IClientService
{
    IEnumerable<ClientEntity> GetAllClientes();
}
