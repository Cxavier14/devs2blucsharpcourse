using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RevisaoProjetoNoticias.Domain.IServices;

namespace RevisaoProjetoNoticia.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly ICategoryService _service;

        public CategoryController(ILogger<CategoryController> logger, ICategoryService service)
        {
            _logger = logger;
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            // to list all categories
            // get of CategoryRepository through Dependency Injection (ICategoryService)
            return View(_service.FindAll());
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}
