using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RevisaoProjetoNoticias.Domain.DTO;
using RevisaoProjetoNoticias.Domain.IServices;

namespace RevisaoProjetoNoticia.Web.Controllers
{
    public class NewsController : Controller
    {
        private readonly INewsService _service;
        private readonly ICategoryService _categoryService;

        public NewsController(INewsService service, ICategoryService categoryService)
        {
            _service = service;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            return View(_service.FindAll());
        }

        public JsonResult ListJson()
        {
            return Json(_service.FindAll());
        }

        public IActionResult Create()
        {
            ViewData["categoryId"] = new SelectList(_categoryService.FindAll(), "id", "name", "Select...");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("id, title, description, createdOn, published, categoryId")] NewsDTO news)
        {
            if (ModelState.IsValid)
            {
                if (await _service.Save(news) > 0)
                    return RedirectToAction("Index");
            }
            ViewData["categoryId"] = new SelectList(_categoryService.FindAll(), "id", "name", "Select...");
            return View(news);
        }

        public async Task<IActionResult> Edit(int id)
        {
            ViewData["categoryId"] = new SelectList(_categoryService.FindAll(), "id", "name", "Select...");
            var news = await _service.FindById(id);
            
            return View(news);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int? id, [Bind("id, title, description, createdOn, published, categoryId")] NewsDTO news)
        {
            if (id != news.id) return NotFound();

            if (ModelState.IsValid)
            {
                if (await _service.Save(news) > 0)
                    return RedirectToAction(nameof(Index));
            }

            return View(news);
        }

        public async Task<ActionResult> Delete(int id)
        {
            var news = await _service.FindById(id);

            if (news == null) return NotFound();

            return View(news);
        }

        [HttpPost]
        public async Task<ActionResult<int>> Delete([Bind("id, title, description, createdOn, published, categoryId")] NewsDTO news)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (await _service.Delete(news.id) > 0)
                        return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
