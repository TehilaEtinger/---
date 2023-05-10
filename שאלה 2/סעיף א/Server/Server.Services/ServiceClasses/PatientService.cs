using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Interfaces;
using Services.Models;
using Repository.Interfaces;
using Server.Repository.Entities;

namespace Services.ServiceClasses
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository repository;
        private readonly IMapper mapper;
        public PatientService(IPatientRepository _rep, IMapper _mapper)
        {
            repository = _rep;
            mapper = _mapper;
        }
        public async Task<PatientModel> AddAsync(PatientModel model)
        {
            Patient patientToAdd = mapper.Map<Patient>(model);
            return mapper.Map<PatientModel>(await repository.AddAsync(patientToAdd));
        }
        public async Task<PatientModel> GetByIdNumberAsync(int idNumber)
        {
            return mapper.Map<PatientModel>(await repository.GetByIdNumberAsync(idNumber));
        }

        public async Task<ICollection<PatientModel>> GetAllAsync()
        {
            ICollection<Patient> list = await repository.GetAllAsync();
            ICollection<PatientModel> listToReturn = new List<PatientModel>();
            foreach (var item in list)
            {
                listToReturn.Add(mapper.Map<PatientModel>(item));
            }
            return listToReturn;
        }
    }
}

