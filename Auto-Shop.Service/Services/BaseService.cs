﻿using Auto_Shop.Domain.Interfaces;
using Auto_Shop.Domain.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Auto_Shop.Service.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : BaseModel
    {
        private readonly IBaseRepository<TEntity> _repository;

        public BaseService(IBaseRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public virtual async Task<TEntity> CreateAsync<TValidator>(TEntity entity) where TValidator : AbstractValidator<TEntity>
        {
            Validate(entity, Activator.CreateInstance<TValidator>());

            return await _repository.CreateAsync(entity);
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public virtual async Task<TEntity> GetByIdAsync(string id)
        {
            var entity = await _repository.GetByIdAsync(id);

            if (entity == null)
                throw new Exception($"{typeof(TEntity).Name} not found.");

            return entity;
        }

        public virtual async Task UpdateAsync<TValidator>(TEntity entity) where TValidator : AbstractValidator<TEntity>
        {
            var entityExists = await GetByIdAsync(entity.Id);

            if (entityExists == null)
                throw new Exception($"{typeof(TEntity).Name} not found.");

            Validate(entity, Activator.CreateInstance<TValidator>());

            await _repository.UpdateAsync(entity);
        }

        public virtual async Task DeleteAsync(string id)
        {
            var entityExists = await GetByIdAsync(id);

            if (entityExists == null)
                 throw new Exception($"{typeof(TEntity).Name} not found.");

            await _repository.DeleteAsync(id);
        }

        protected void Validate(TEntity entity, AbstractValidator<TEntity> validator)
        {
            if (entity == null)
                throw new Exception($"{typeof(TEntity).Name} not found.");

            validator.ValidateAndThrow(entity);
        }
    }
}
