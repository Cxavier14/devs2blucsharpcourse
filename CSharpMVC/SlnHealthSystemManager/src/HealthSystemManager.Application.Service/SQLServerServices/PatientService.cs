using HealthSystemManager.Domain.DTO;
using HealthSystemManager.Domain.IRepositories;
using HealthSystemManager.Domain.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemManager.Application.Service.SQLServerServices
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _repository;

        public PatientService(IPatientRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Delete(int id)
        {
            var entity = await _repository.FindById(id);
            return await _repository.Delete(entity);
        }

        public List<PatientDTO> FindAll()
        {
            return _repository.FindAll()
                .Select(patient => new PatientDTO
                {
                    id = patient.Id,
                    personId = patient.PersonId,
                    person = patient.Person,
                }).ToList();
        }



        public async Task<PatientDTO> FindById(int id)
        {
            var entity = new PatientDTO();
            return entity.mapToDTO(await _repository.FindById(id));
        }

        public Task<int> Save(PatientDTO entity)
        {
            if(entity.id > 0)
            {
                return _repository.Update(entity.mapToEntity());
            }
            else
            {
                return _repository.Save(entity.mapToEntity());
            }
        }
    }
}
