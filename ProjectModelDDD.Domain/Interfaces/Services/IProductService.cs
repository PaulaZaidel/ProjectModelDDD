using ProjectModelDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjectModelDDD.Domain.Interfaces.Services
{
    public interface IProductService : IServiceBase<Product>
    {
        IEnumerable<Product> FindByame(string name);
    }
}
