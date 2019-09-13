
using ProjectModelDDD.Domain.Entities;
using ProjectModelDDD.Domain.Interfaces.Repositories;
using ProjectModelDDD.Infra.Data.Context;

namespace ProjectModelDDD.Infra.Data.Repositories
{
    public class ClientRepository : RepositoryBase<Client>, IClientRepository
    {
        public ClientRepository(ProjectModelContext context) : base(context)
        {
        }
    }
}
