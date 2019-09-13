
using System.Collections.Generic;
using System.Linq;
using ProjectModelDDD.Domain.Entities;
using ProjectModelDDD.Domain.Interfaces.Repositories;
using ProjectModelDDD.Infra.Data.Context;

namespace ProjectModelDDD.Infra.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(ProjectModelContext context) : base(context)
        {
        }

        public IEnumerable<Product> FindByName(string name)
        {
            return _context.Products.Where(p => p.Name == name);
        }
    }
}
