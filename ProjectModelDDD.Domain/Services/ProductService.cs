
using System.Collections.Generic;
using ProjectModelDDD.Domain.Entities;
using ProjectModelDDD.Domain.Interfaces.Repositories;
using ProjectModelDDD.Domain.Interfaces.Services;

namespace ProjectModelDDD.Domain.Services
{
    public class ProductService : ServiceBase<Product>, IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public IEnumerable<Product> FindByame(string name)
        {
            return _repository.FindByName(name);
        }
    }
}
