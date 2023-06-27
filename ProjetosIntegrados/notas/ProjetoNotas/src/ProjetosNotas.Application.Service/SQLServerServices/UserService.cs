using ProjetoNotas.Domain.DTO;
using ProjetoNotas.Domain.Entities;
using ProjetoNotas.Domain.Interfaces.IRepository;
using ProjetoNotas.Domain.Interfaces.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosNotas.Application.Service.SQLServerServices
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Delete(int id)
        {
            var result = await _repository.FindById(id);

            if (result != null) 
                return await _repository.Delete(result);
            return 0;
        }

        public List<UserDTO> FindAll()
        {
            return _repository.FindAll()
                .Select(u => new UserDTO
                {
                    id = u.Id,
                    name = u.Name,
                    login = u.Login,
                    password = u.Password,
                    notes = (ICollection<NoteDTO>)u.Notes
                }).ToList();
        }

        public async Task<UserDTO> FindById(int id)
        {
            var dto = new UserDTO();
            return dto.mapToDTO(await _repository.FindById(id));
        }

        public async Task<int> Save(UserDTO dto)
        {
            var result = await _repository.FindById(dto.id);

            if (result != null)
                return await _repository.Update(dto.mapToEntity());
            else
                return await _repository.Save(dto.mapToEntity());

        }
    }
}
