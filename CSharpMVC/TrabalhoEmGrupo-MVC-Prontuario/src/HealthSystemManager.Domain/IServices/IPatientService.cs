using HealthSystemManager.Domain.DTO;
using HealthSystemManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemManager.Domain.IServices
{
    public interface IPatientService : IBaseService<PatientDTO>
    {
        Task<List<PatientDTO>> GetByName(string name);
    }
}
