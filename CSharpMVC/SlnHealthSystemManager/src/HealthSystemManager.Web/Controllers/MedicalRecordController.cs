using HealthSystemManager.Domain.IServices;
using Microsoft.AspNetCore.Mvc;

namespace HealthSystemManager.Web.Controllers
{
    public class MedicalRecordController : Controller
    {
        private readonly IMedicalRecordsService _service;

        public MedicalRecordController(IMedicalRecordsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Create(int id)
        {
            var list = await _service.FindById(id);
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            return View();
        }

        public IActionResult Delete(int id)
        {
            return View();
        }
    }
}
