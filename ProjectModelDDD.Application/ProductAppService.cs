using System.Collections.Generic;
using ProjectModelDDD.Application.Interface;
using ProjectModelDDD.Domain.Entities;
using ProjectModelDDD.Domain.Interfaces.Services;

namespace ProjectModelDDD.Application
{
    public class ProductAppService : AppServiceBase<Product>, IProductAppService
    {
        private readonly IProductService _service;

        public ProductAppService(IProductService service) : base(service)
        {
            _service = service;
        }

        public IEnumerable<Product> FindByame(string name)
        {
            return _service.FindByame(name);
        }
    }
}
