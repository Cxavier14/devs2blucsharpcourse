using HealthSystemManager.Domain.DTO;
using HealthSystemManager.Domain.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HealthSystemManager.Web.Controllers
{
    public class MedicalRecordController : Controller
    {
        private readonly IPatientService _patientService;
        private readonly IMedicalRecordsService _service;

        public MedicalRecordController(IMedicalRecordsService service, IPatientService patientService)
        {
            _service = service;
            _patientService = patientService;
        }

        public async Task<IActionResult> Index (int id)
        {            
            if (await _service.FindById(id) == null)
                return RedirectToAction($"NoRecords({id})");

            var result = _service.FindAllRecords(id);

            return View(result);
        }

        public async Task<IActionResult> NoRecords(int id)
        {
            return View(await _patientService.FindById(id));
        }

        public IActionResult Create()
        {
            ViewData["patientId"] = new SelectList(_patientService.FindAll(), "id", "name", "Select...");            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int id, [Bind("id,diagnostic,medicalAppointment,medication,exam,patientId")] MedicalRecordDTO medicalRecord)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (await _service.Save(medicalRecord) > 0)
                        return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return View(medicalRecord);
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
