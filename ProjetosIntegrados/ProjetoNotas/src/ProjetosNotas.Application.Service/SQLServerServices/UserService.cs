using ProjetoNotas.Domain.DTO;
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

        public Task<int> Delete(UserDTO entity)
        {
            throw new NotImplementedException();
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
                }).ToList();
        }

        public async Task<UserDTO> FindById(int id)
        {
            var dto = new UserDTO();
            return dto.mapToDTO(await _repository.FindById(id));
        }

        public Task<int> Save(UserDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(UserDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
