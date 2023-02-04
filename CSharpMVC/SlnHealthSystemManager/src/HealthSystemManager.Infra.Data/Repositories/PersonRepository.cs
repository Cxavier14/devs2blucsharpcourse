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
    public class PersonRepository : BaseRepository<Person>, IPersonRepository
    {
        public PersonRepository(SQLServerContext context) : base(context)
        {
        }
    }
}
