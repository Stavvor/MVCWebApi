using MVCWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApi
{
    public interface ICRUD<T>
        where T : EntityModel
    {
        Task<List<T>> GetAll();

        Task<List<T>> GetPage(int pageIndex, int pageSize);

        Task Create(T entity);

        Task<T> Read(int? id);

        Task Update(T entity);

        Task Delete(int? id);
    }
}
