using HealthSystemManager.Domain.Entities;
using HealthSystemManager.Domain.IRepositories;
using HealthSystemManager.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemManager.Infra.Data.Repositories
{
    public class MedicalRecordRepository : BaseRepository<MedicalRecord>, IMedicalRecordsRepository
    {
        public MedicalRecordRepository(SQLServerContext context) : base(context)
        {
        }
    }
}
