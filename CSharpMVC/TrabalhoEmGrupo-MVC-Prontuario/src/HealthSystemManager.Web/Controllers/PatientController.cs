using HealthSystemManager.Domain.DTO;
using HealthSystemManager.Domain.IServices;
using HealthSystemManager.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Net;

namespace HealthSystemManager.Web.Controllers
{
    public class PatientController : Controller
    {
        private readonly IPatientService _patientService;
        private readonly IMedicalRecordsService _recordsService;

        public PatientController(IPatientService patientService, IMedicalRecordsService recordsService)
        {
            _patientService = patientService;
            _recordsService = recordsService;
        }

        // GET: PatientController
        public ActionResult Index(IEnumerable<PatientDTO>? result)
        {
            if (result.IsNullOrEmpty())
            {
                result = _patientService.FindAll();
                return View(result);
            }
            return View(result);
        }

        // GET: PatientController/Details/5
        public ActionResult Details(int id)
        {
            MedicalRecodsViewModel viewModel = new MedicalRecodsViewModel();
            List<MedicalRecordDTO> list = _recordsService.FindAllRecords(id);
            PatientDTO patient = _patientService.FindById(id).Result;

            viewModel.oPatient = patient;
            viewModel.ListMedicalRec = list;

            return View(viewModel);
        }

        [HttpPost]
        public async Task<ActionResult> GetPatientName(string name)
        {
            if (name.IsNullOrEmpty()) return RedirectToAction(nameof(Index));

            IEnumerable<PatientDTO> result = await _patientService.GetByName(name);

            if (result.IsNullOrEmpty()) return RedirectToAction(nameof(Index));

            if (result.Count() > 0)
            {
                return View("Index", result);
            }
            else
            {
                return View("Index");
            }
        }
    }
}
