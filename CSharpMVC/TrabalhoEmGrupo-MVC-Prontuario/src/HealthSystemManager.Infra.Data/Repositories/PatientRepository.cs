using HealthSystemManager.Domain.DTO;
using HealthSystemManager.Domain.Entities;
using HealthSystemManager.Domain.IRepositories;
using HealthSystemManager.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemManager.Infra.Data.Repositories
{
    public class PatientRepository : BaseRepository<Patient>, IPatientRepository
    {
        private readonly SQLServerContext _serverContext;

        public PatientRepository(SQLServerContext context, SQLServerContext serverContext) : base(context)
        {
            _serverContext = serverContext;
        }

    }
}
