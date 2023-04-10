using Microsoft.AspNetCore.Mvc;
using ProjetoNotas.Domain.DTO;
using ProjetoNotas.Domain.Interfaces.IService;

namespace ProjetoNotas.Application.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        // Get Users
        [Route("GetUsers")]
        [HttpGet]
        public JsonResult GetUsers()
        {
            var list = _service.FindAll();
            return Json(list);
        }

        // Get By Id
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _service.FindById(id);
            
            return Json(result);
        }

        /*public List<UserDTO> GetUsers()
        {
            return _service.FindAll();
        }*/

        /*public Task<UserDTO> GetById(int id)
        {
            return _service.FindById(id);
        }*/

        /*[HttpGet]        
        public JsonResult ListJson()
        {
            return Json(_service.FindAll());
        }*/
    }
}
