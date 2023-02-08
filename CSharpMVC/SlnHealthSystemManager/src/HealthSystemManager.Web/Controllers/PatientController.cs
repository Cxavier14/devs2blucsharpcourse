using HealthSystemManager.Domain.DTO;
using HealthSystemManager.Domain.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthSystemManager.Web.Controllers
{
    public class PatientController : Controller
    {
        private readonly IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        // GET: PatientController
        public ActionResult Index()
        {
            var result = _patientService.FindAll();
            return View(result);
        }

        // GET: PatientController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var result = await _patientService.FindById(id);
            return View(result);
        }

        // GET: PatientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PatientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind("id,healthInsurance,name,identityDocument,birthDate,phone,address,city")] PatientDTO patient)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (await _patientService.Save(patient) > 0)
                    {
                        return RedirectToAction("Index");
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        // GET: PatientController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var result = await _patientService.FindById(id);
            return View(result);
        }

        // POST: PatientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, [Bind("id,healthInsurance,name,identityDocument,birthDate,phone,address,city")] PatientDTO patient)
        {
            try
            {
                if (id != patient.id)
                    return NotFound();

                if (ModelState.IsValid)
                {
                    if (await _patientService.Save(patient) > 0)
                        return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
            return View(patient);
        }

        // GET: PatientController/Delete/5
        public ActionResult Delete(int id)
        {
            var result = _patientService.FindById(id);
            return View(result);
        }

        // POST: PatientController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult<int>> Delete(int id, [Bind("id,healthInsurance,name,identityDocument,birthDate,phone,address,city")] PatientDTO patient)
        {
            try
            {
                if (id != patient.id)
                    return NotFound();

                if (ModelState.IsValid)
                {
                    return new ActionResult<int>(await _patientService.Delete(patient));
                }
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
            return View(patient);
        }
    }
}
