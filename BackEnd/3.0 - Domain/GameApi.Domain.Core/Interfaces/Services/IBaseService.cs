using System.Collections.Generic;

namespace GameApi.Domain.Core.Interfaces.Services
{
   public interface IBaseService<TEntity> where TEntity : class
    {
        void Add(TEntity Obj);

        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

        void Update(TEntity obj);

        void Remove(TEntity obj);

        void Dispose();
    }
}