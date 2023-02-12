using Auto_Shop.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Auto_Shop.Domain.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : BaseModel
    {
        Task<TEntity> CreateAsync(TEntity entity);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(string id);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(string id);
        Task<int> SaveChangesAsync();
    }
}
