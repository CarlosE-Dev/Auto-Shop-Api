using Auto_Shop.Domain.Interfaces;
using Auto_Shop.Domain.Models;
using Auto_Shop.Infra.Data.Context;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Auto_Shop.Infra.Data.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseModel
    {
        protected readonly AutoShopContext _context;
        protected readonly IMapper _mapper;

        public BaseRepository(AutoShopContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async virtual Task<TEntity> CreateAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await SaveChangesAsync();
            return await GetByIdAsync(entity.Id);
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        public virtual async Task<TEntity> GetByIdAsync(string id)
        {
            return await _context.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }

        public virtual async Task UpdateAsync(TEntity entity)
        {
        }

        public async virtual Task DeleteAsync(string id)
        {
            _context.Set<TEntity>().Remove(await GetByIdAsync(id));
            await SaveChangesAsync();
        }

        public async virtual Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
