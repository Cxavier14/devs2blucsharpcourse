using Microsoft.AspNetCore.Mvc;
using ProjetoNotas.Domain.DTO;
using ProjetoNotas.Domain.Interfaces.IService;

namespace ProjetoNotas.Application.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        // Get Users
        [HttpGet]
        public List<UserDTO> GetUsers()
        {
            try
            {
                var result = _service.FindAll();
                return result;
            }
            catch (Exception e)
            {
                throw new Exception($"Ocorreu um erro ao tentar buscar os usuários! Erro:{e.Message}");
            }

        }

        // Get By Id
        [HttpGet("{id}")]
        public Task<UserDTO> GetById(int id)
        {
            try
            {
                var result = _service.FindById(id);
                return result;
            }
            catch (Exception e)
            {
                throw new Exception($"Ocorreu um erro ao tentar buscar o usuário! Erro:{e.Message}");
            }
        }

        // Save / Update
        [HttpPost]
        public async Task<IActionResult> SaveUser(UserDTO dto)
        {
            try
            {
                var result = await _service.Save(dto);
                return result > 0 ? Ok(result) : NoContent();      
            }
            catch (Exception e)
            {
                throw new Exception($"Ocorreu um erro inesperado! Erro:{e.Message}");
            }
        }

        // Delete
        [HttpDelete]
        public async Task<IActionResult> DeleteUser(int id)
        {
            try
            {
                var result = await _service.FindById(id);

                if (result == null) return NoContent();

                if (await _service.Delete(id) > 0) 
                    return Ok("Deletado com sucesso");
                else
                    return NoContent();
            }
            catch (Exception e)
            {
                throw new Exception($"Ocorreu um erro ao tentar apagar o registro! Erro:{e.Message}");
            }
        }
    }
}
