using HealthSystemManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemManager.Infra.Data.Context
{
    public class SQLServerContext : DbContext
    {
        public SQLServerContext(DbContextOptions<SQLServerContext> options) :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        #region DbSet's

        public DbSet<Patient> Patient { get; set; }
        public DbSet<MedicalRecord> MedicalRecord { get; set; }

        #endregion
    }
}
