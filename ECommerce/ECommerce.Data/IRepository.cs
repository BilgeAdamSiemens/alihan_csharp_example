using System;
using System.Collections.Generic;
using System.Text;
using ECommerce.Entity;

namespace ECommerce.Data
{
    public interface IRepository<TEntity, TID>
    {
        List<TEntity> FindAll(Pageable pageable); 
        List<TEntity> FindAll();
        TEntity FindById(TID id);
        TEntity Save(TEntity entity);
        void DeleteById(TID id);
        void Delete(TEntity entity);

    }
}
