
using System.Collections.Generic;
using ProjectModelDDD.Application.Interface;
using ProjectModelDDD.Domain.Entities;
using ProjectModelDDD.Domain.Interfaces.Services;

namespace ProjectModelDDD.Application
{
    public class AppServiceBase<TEntity> : IAppServiceBase<TEntity> where TEntity : EntityBase
    {
        private readonly IServiceBase<TEntity> _service;

        public AppServiceBase(IServiceBase<TEntity> service)
        {
            _service = service;
        }

        public void Add(TEntity entity)
        {
            _service.Add(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _service.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _service.GetById(id);
        }

        public void Remove(TEntity entity)
        {
            _service.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            _service.Update(entity);
        }
    }
}
