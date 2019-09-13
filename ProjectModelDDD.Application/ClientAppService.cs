
using System.Collections.Generic;
using ProjectModelDDD.Application.Interface;
using ProjectModelDDD.Domain.Entities;
using ProjectModelDDD.Domain.Interfaces.Services;

namespace ProjectModelDDD.Application
{
    public class ClientAppService : AppServiceBase<Client>, IClientAppService
    {
        private readonly IClientService _service;

        public ClientAppService(IClientService service) : base(service)
        {
            _service = service;
        }

        public IEnumerable<Client> GetEspecialClients()
        {
            return _service.GetEspecialClients(_service.GetAll());
        }
    }
}
