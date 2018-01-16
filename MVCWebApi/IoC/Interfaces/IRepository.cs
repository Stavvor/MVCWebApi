using System.Collections.Generic;
using System.Threading.Tasks;
using MVCWebApi.Models;

namespace MVCWebApi
{
    public interface IRepository<T>
        where T : EntityModel
    {
        Task<List<T>> GetAll();

        Task Create(T entity);

        Task Update(T entity);

        Task<T> Read(int? id);
        
        Task Delete(int? id);

        Task RemoveByValue(T entity);

        Task<T> GetById(int? id);
    }
}
