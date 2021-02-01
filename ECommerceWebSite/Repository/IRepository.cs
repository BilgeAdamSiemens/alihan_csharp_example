using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Repository
{
    public interface IRepository<TEntity, TID>
    {
        List<TEntity> FindAll();
        TEntity FindById(TID id);
        void DeleteById(TID id);
        void Delete(TEntity entity);
        TEntity Save(TEntity entity);

    }
}
