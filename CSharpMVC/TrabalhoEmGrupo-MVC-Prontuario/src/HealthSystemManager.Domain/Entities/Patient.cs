using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemManager.Domain.Entities
{
    public class Patient : Person
    {
        public int Id { get; set; }
        public string HealthInsurance { get; set; }
        public virtual ICollection<MedicalRecord>? MedicalRecords { get; set; } = new List<MedicalRecord>();           
    }
}
