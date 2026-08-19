using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicktingSystem.Domain.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<T> GetByIdAsync(int id);
        Task<T> Update(T entity);
        Task<bool> DeleteByIdAsync(int id);

        Task<T> Add(T entity);


    }
}
