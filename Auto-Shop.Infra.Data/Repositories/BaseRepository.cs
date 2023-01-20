using Auto_Shop.Domain.Interfaces;
using Auto_Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Shop.Infra.Data.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseModel
    {
        public virtual Task<TEntity> CreateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task<IEnumerable<TEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public virtual Task<TEntity> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public virtual Task UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
