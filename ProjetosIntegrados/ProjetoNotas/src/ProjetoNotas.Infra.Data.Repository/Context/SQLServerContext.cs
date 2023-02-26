using Microsoft.EntityFrameworkCore;
using ProjetoNotas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNotas.Infra.Data.Repository.Context
{
    public class SQLServerContext : DbContext
    {
        public SQLServerContext(DbContextOptions<SQLServerContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>()
                .HasOne(u => u.User)
                .WithMany(n => n.Notes)
                .HasForeignKey(u => u.UserId);
            base.OnModelCreating(modelBuilder);
        }

        #region DbSet's

        public DbSet<User> User { get; set; }
        public DbSet<Note> Note { get; set; }

        #endregion
    }
}
