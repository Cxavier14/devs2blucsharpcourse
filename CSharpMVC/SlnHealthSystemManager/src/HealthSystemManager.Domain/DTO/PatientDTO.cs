using HealthSystemManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemManager.Domain.DTO
{
    public class PatientDTO
    {
        public int id { get; set; }
        public virtual ICollection<MedicalRecord>? MedicalRecords { get; set; }

        public int personId { get; set; }
        public virtual Person? person { get; set; }

        public PatientDTO mapToDTO(Patient patient)
        {
            return new PatientDTO
            {
                id = patient.Id,
                personId = patient.PersonId
            };
        }

        public Patient mapToEntity()
        {
            return new Patient
            {
                Id = id,
                PersonId = personId,
            };
        }
    }
}
