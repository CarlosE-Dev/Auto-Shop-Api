using Auto_Shop.Domain.Models;
using FluentValidation;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Auto_Shop.Domain.Interfaces
{
    public interface IBaseService<TEntity> where TEntity : BaseModel
    {
        Task<TEntity> CreateAsync<TValidator>(TEntity entity) where TValidator : AbstractValidator<TEntity>;
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(string id);
        Task UpdateAsync<TValidator>(TEntity entity) where TValidator : AbstractValidator<TEntity>;
        Task DeleteAsync(string id);
    }
}
