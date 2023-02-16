using HealthSystemManager.Domain.DTO;

namespace HealthSystemManager.Web.Models
{
    public class MedicalRecodsViewModel
    {
        public PatientDTO oPatient { get; set; }
        public MedicalRecordDTO oMedicalRecord { get; set; }
        public List<MedicalRecordDTO> ListMedicalRec { get; set; }
    }
}
