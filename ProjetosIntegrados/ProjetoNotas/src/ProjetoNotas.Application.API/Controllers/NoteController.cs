using Microsoft.AspNetCore.Mvc;
using ProjetoNotas.Domain.Interfaces.IService;

namespace ProjetoNotas.Application.API.Controllers
{
    public class NoteController : Controller
    {
        private readonly INoteService _service;

        public NoteController(INoteService service)
        {
            _service = service;
        }

        public JsonResult Index()
        {
            var list = _service.FindAll();
            return Json(list);
        }
    }
}
