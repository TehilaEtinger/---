using Server.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IService<T>
    {
        //Implements CRUD
        Task<ICollection<T>> GetAllAsync();
        Task<T> GetByIdNumberAsync(int idNumber);
        Task<T> AddAsync(T model);
    }
}
