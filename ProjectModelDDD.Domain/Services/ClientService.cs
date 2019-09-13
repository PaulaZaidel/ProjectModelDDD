
using System.Collections.Generic;
using System.Linq;
using ProjectModelDDD.Domain.Entities;
using ProjectModelDDD.Domain.Interfaces.Repositories;
using ProjectModelDDD.Domain.Interfaces.Services;

namespace ProjectModelDDD.Domain.Services
{
    public class ClientService : ServiceBase<Client>, IClientService
    {
        private readonly IClientRepository _repository;

        public ClientService(IClientRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public IEnumerable<Client> GetEspecialClients(IEnumerable<Client> clients)
        {
            return clients.Where(c => c.SpecialClient(c));
        }
    }
}
