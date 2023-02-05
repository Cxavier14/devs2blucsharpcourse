using HealthSystemManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemManager.Domain.DTO
{
    public class MedicalRecordDTO
    {
        public int id { get; set; }
        public string diagnostic { get; set; }
        public DateTime medicalAppointment { get; set; }
        public string medication { get; set; }
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
