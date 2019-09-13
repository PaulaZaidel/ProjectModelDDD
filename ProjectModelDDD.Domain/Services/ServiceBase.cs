
using System.Collections.Generic;
using ProjectModelDDD.Domain.Entities;
using ProjectModelDDD.Domain.Interfaces.Repositories;
using ProjectModelDDD.Domain.Interfaces.Services;

namespace ProjectModelDDD.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : EntityBase
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public void Add(TEntity entity)
        {
            _repository.Add(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public TEntity GetById(int id)
        {
           return _repository.GetById(id);
        }

        public void Remove(TEntity entity)
        {
            _repository.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            _repository.Update(entity);
        }
    }
}
