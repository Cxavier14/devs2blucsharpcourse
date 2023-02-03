using HealthSystemManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemManager.Domain.DTO
{
    public class MedicalRecordsDTO
    {
        public int id { get; set; }
        public DateTime medicalAppointment { get; set; }
        public string[] medications { get; set; }
        public string[] exams { get; set; }

        public int patientId { get; set; }
        public virtual Patient? Patient { get; set; }

        public MedicalRecordsDTO mapToDTO(MedicalRecord medicalRecord)
        {
            return new MedicalRecordsDTO
            {
                id = medicalRecord.Id,
                medicalAppointment = medicalRecord.MedicalAppointment,
                medications = medicalRecord.Medications,
                exams = medicalRecord.Exams,
                patientId = medicalRecord.PatientId
            };
        }

        public MedicalRecord mapToEntity()
        {
            return new MedicalRecord
            {
                Id = id,
                MedicalAppointment = medicalAppointment,
                Medications = medications,
                Exams = exams,
                PatientId = patientId
            };
        }
    }
}
