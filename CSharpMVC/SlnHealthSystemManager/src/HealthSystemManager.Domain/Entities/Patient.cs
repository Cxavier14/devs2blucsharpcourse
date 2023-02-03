using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemManager.Domain.Entities
{
    public class Patient
    {
        public int Id { get; set; }
        public virtual ICollection<MedicalRecord>? MedicalRecords { get; set; }
        
        public int PersonId { get; set; }
        public virtual Person? Person { get; set; }
    }
}
