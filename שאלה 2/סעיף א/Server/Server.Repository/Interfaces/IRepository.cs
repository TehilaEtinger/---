using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IRepository<T>
    {
        Task<ICollection<T>> GetAllAsync();
        Task<T>GetByIdNumberAsync(int idNumber);
        Task<T> AddAsync(T model);
    }
}
