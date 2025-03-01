using RevisaoAula1.Domain.Entities;

namespace RevisaoAula1.Domain.Interfaces;

public interface IClientRepository
{
    IEnumerable<ClientEntity> GetAll();
}
