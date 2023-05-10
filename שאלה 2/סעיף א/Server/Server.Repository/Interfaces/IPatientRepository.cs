using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Repository.Entities;
namespace Repository.Interfaces
{
    public interface IPatientRepository : IRepository<Patient>
    {
        Task<ICollection<Patient>> GetAllAsync();
        Task<Patient> GetByIdNumberAsync(int id);
        Task<Patient> AddAsync(Patient model);
    }
}
