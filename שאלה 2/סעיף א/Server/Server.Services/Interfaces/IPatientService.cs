using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Models;
namespace Services.Interfaces
{
    public interface IPatientService : IService<PatientModel>
    {
        Task<ICollection<PatientModel>> GetAllAsync();
        Task<PatientModel> GetByIdNumberAsync(int idNumber);
        Task<PatientModel> AddAsync(PatientModel model);
    }
}
