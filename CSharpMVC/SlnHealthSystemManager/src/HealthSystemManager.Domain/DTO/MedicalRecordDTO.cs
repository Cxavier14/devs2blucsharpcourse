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
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]        
        public DateTime medicalAppointment { get; set; }

        [Display(Name = "Medication")]
        public string medication { get; set; }
        
        [Display(Name = "Exam")]
        public string exam { get; set; }

        [Display(Name ="Patient")]
        public int patientId { get; set; }
        public Patient? patient { get; set; }

        public MedicalRecordDTO mapToDTO(MedicalRecord medicalRecord)
        {
            return new MedicalRecordDTO
            {
                id = medicalRecord.Id,
                diagnostic = medicalRecord.Diagnostic,
                medicalAppointment = medicalRecord.MedicalAppointment,
                medication = medicalRecord.Medication,
                exam = medicalRecord.Exam,
                patientId = medicalRecord.PatientId,
                patient = medicalRecord.Patient
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
                PatientId = patientId,
                Patient = patient,
            };
        }
    }
}
