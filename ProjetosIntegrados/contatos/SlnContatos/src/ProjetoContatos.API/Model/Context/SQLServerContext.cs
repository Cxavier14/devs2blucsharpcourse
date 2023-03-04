using Microsoft.EntityFrameworkCore;
using ProjetoContatos.API.Model.Entities;

namespace ProjetoContatos.API.Model.Context
{
    public class SQLServerContext : DbContext
    {
        public SQLServerContext(DbContextOptions<SQLServerContext> options) 
            : base(options) { }


        #region DbSet's
        public DbSet<Contato> Contatos { get; set; }
        #endregion
    }
}
