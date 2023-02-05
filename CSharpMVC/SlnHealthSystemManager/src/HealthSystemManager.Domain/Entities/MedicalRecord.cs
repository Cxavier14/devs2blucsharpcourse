using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemManager.Domain.Entities
{
    public class MedicalRecord
    {
        public int Id { get; set; }
        public string Diagnostic { get; set; }
        public DateTime MedicalAppointment { get; set; }
        public string Medication { get; set; }
        public string Exam { get; set; }
        
        public int PatientId { get; set; }
        public virtual Patient? Patient { get; set; }
    }
}
