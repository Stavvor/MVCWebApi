using MVCWebApi.DataAccessLayer;
using MVCWebApi.Models;
using MVCWebApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApi.Services
{
    public class Service<T> : IService<T>
        where T : EntityModel
    {
        private readonly IRepository<T> _repository;

        public Service(IRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task<List<T>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task Create(T entity)
        {
            await _repository.Create(entity);
        }

        public async Task<T> Read(int? id)
        {
            if (CheckID(id))
            {
                return await _repository.Read(id);
            }
            return null;
        }

        public async Task Update(T entity)
        {
            await _repository.Update(entity);
        }

        public async Task Delete(int? id)
        {
            if (CheckID(id))
            {
                await _repository.Delete(id);
            }
        }

        public bool CheckID(int? id)
        {
            if (id == null) return false;
            else return true;
        }
    }
}
