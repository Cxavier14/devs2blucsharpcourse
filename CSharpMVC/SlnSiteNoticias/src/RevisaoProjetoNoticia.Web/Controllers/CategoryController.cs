using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RevisaoProjetoNoticias.Domain.DTO;
using RevisaoProjetoNoticias.Domain.IServices;

namespace RevisaoProjetoNoticia.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            // to list all categories
            // get of CategoryRepository through Dependency Injection (ICategoryService)
            return View(_service.FindAll());
        }

        public JsonResult ListJson()
        {
            return Json(_service.FindAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("id, name")] CategoryDTO category)
        {
            return View(category);
        }

        public async Task<IActionResult> Edit(int id)
        {
            if (id == null) return NotFound();

            var category = await _service.FindById(id);
            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int? id, [Bind("id, name")] CategoryDTO category)
        {
            if(!(id == category.id)) return NotFound();

            if (ModelState.IsValid)
            {
                if (await _service.Save(category) > 0)
                    return RedirectToAction(nameof(Index));
            }

            return View(category);
        }
    }
}
