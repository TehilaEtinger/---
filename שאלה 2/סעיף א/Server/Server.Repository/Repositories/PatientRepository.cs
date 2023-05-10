using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Repository.Entities;
using Server.Repository;
using Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Repository.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        IDataSource dataSource;
        public PatientRepository(IDataSource ds)
        {
            dataSource = ds;
        }
        public async Task<ICollection<Patient>> GetAllAsync ()
        {
            return await dataSource.Patients.ToListAsync();
        }
        public  async Task<Patient> GetByIdNumberAsync(int idNumber)
        {
            return await dataSource.Patients.FirstOrDefaultAsync(user => user.PatientId == idNumber);
        }
        public async Task<Patient> AddAsync(Patient model)
        {
            EntityEntry<Patient> userToReturn = dataSource.Patients.Add(model);
            await dataSource.SaveChangesAsync();
            return userToReturn.Entity;
        }
    }
}

