using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCWebApi.Repositories;
using MVCWebApi.Models;
using MVCWebApi.DataAccessLayer;

namespace MVCWebApi.Services
{
    public class Service<T>
        where T : EntityModel
    {
        private readonly Repository<T> _repository;

        public Service(LibraryContext Context)
        {
            _repository = new Repository<T>(Context);
        }

        public async Task<List<T>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task Create(T entity)
        {
            await _repository.Create(entity);
        }

        public async Task<T> Read(int id)
        {
            return await _repository.Read(id);
        }

        public async Task Update(int id, T entity)
        {
            var toRemove = await _repository.Read(id);
            await _repository.RemoveByValue(toRemove);
            await _repository.Create(entity);
        }

        public async Task Delete(int id)
        {
            await _repository.Delete(id);
        }
    }
}
