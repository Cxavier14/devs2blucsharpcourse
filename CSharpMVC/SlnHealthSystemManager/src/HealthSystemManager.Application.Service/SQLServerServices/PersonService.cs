using HealthSystemManager.Domain.DTO;
using HealthSystemManager.Domain.Entities;
using HealthSystemManager.Domain.IRepositories;
using HealthSystemManager.Domain.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemManager.Application.Service.SQLServerServices
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _repository;

        public PersonService(IPersonRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Delete(int id)
        {
            var dto = await _repository.FindById(id);
            return await _repository.Delete(dto);
        }

        public List<PersonDTO> FindAll()
        {
            return _repository.FindAll()
                .Select(person => new PersonDTO()
                {
                    id = person.Id,
                    name = person.Name,
                    identityDocument = person.IdentityDocument,
                    birthDate = person.BirthDate,
                    phone = person.Phone,
                    address = person.Address,
                    city = person.City,
                }).ToList();
        }

        public async Task<PersonDTO> FindById(int id)
        {
            var dto = new PersonDTO();
            return dto.mapToDTO(await _repository.FindById(id));
        }

        public Task<int> Save(PersonDTO entity)
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
