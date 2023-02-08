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
    public class MedicalRecordDTO
    {
        [Display(Name = "MedicalRecord Code")]
        public int id { get; set; }
        
        [Display(Name = "Diagnostic")]
        public string diagnostic { get; set; }
        
        [Display(Name = "Appointment")]
        public DateTime medicalAppointment { get; set; }

        [Display(Name = "Medication")]
        public string medication { get; set; }
        
        [Display(Name = "Exam")]
        public string exam { get; set; }

        public int patientId { get; set; }
        public virtual Patient? Patient { get; set; }

        public MedicalRecordDTO mapToDTO(MedicalRecord medicalRecord)
        {
            return new MedicalRecordDTO
            {
                id = medicalRecord.Id,
                diagnostic = medicalRecord.Diagnostic,
                medicalAppointment = medicalRecord.MedicalAppointment,
                medication = medicalRecord.Medication,
                exam = medicalRecord.Exam,
                patientId = medicalRecord.PatientId
            };
        }

        public MedicalRecord mapToEntity()
        {
            return new MedicalRecord
            {
                Id = id,
                Diagnostic = diagnostic,
                MedicalAppointment = medicalAppointment,
                Medication = medication,
                Exam = exam,
                PatientId = patientId
            };
        }
    }
}
