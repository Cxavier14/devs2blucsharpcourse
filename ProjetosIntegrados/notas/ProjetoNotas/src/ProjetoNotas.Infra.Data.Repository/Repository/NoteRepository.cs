using ProjetoNotas.Domain.Entities;
using ProjetoNotas.Domain.Interfaces.IRepository;
using ProjetoNotas.Infra.Data.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNotas.Infra.Data.Repository.Repository
{
    public class NoteRepository : BaseRepository<Note>, INoteRepository
    {
        public NoteRepository(SQLServerContext context) : base(context)
        {
        }
    }
}
