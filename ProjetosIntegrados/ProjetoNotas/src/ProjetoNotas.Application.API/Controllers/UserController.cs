using Microsoft.AspNetCore.Mvc;
using ProjetoNotas.Domain.DTO;
using ProjetoNotas.Domain.Interfaces.IService;

namespace ProjetoNotas.Application.API.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        // Get users
        [Route("GetUsers")]
        [HttpGet]
        public List<UserDTO> GetUsers()
        {
            return _service.FindAll();
        }

        // Get by id
        [HttpGet("/{id}")]
        public Task<UserDTO> GetById(int id)
        {
            return _service.FindById(id);
        }

        /*[HttpGet]        
        public JsonResult ListJson()
        {
            return Json(_service.FindAll());
        }*/
    }
}
