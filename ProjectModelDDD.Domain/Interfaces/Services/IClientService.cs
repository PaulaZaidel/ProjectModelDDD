
using ProjectModelDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjectModelDDD.Domain.Interfaces.Services
{
    public interface IClientService : IServiceBase<Client>
    {
        IEnumerable<Client> GetEspecialClients(IEnumerable<Client> clients);
    }
}
