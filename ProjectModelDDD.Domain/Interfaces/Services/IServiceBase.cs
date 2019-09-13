
using ProjectModelDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjectModelDDD.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : EntityBase
    {
        void Add(TEntity entity);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity entity);
        void Remove(TEntity entity);
    }
}
