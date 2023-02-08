using HealthSystemManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HealthSystemManager.Domain.DTO
{
    public class PatientDTO : PersonDTO
    {
        [Display(Name = "Patient Code")]
        public int id { get; set; }
        
        [Display(Name = "Health Insurance")]
        public string healthInsurance { get; set; }

        [Display(Name = "Medical Records")]
        public virtual ICollection<MedicalRecord>? medicalRecords { get; set; }

        public PatientDTO mapToDTO(Patient patient)
        {
            return new PatientDTO
            {
                id = patient.Id,
                healthInsurance = patient.HealthInsurance,
                name = patient.Name,
                identityDocument = patient.IdentityDocument,
                birthDate = patient.BirthDate,
                phone = patient.Phone,
                address = patient.Address,
                city = patient.City,
            };
        }

        public Patient mapToEntity()
        {
            return new Patient
            {
                Id = id,
                HealthInsurance = healthInsurance,
                Name = name,
                IdentityDocument = identityDocument,
                BirthDate = birthDate,
                Phone = phone,
                Address = address,
                City = city,
            };
        }
    }
}
