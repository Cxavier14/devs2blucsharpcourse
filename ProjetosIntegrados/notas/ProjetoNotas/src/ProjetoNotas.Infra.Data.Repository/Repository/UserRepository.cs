using Microsoft.EntityFrameworkCore;
using ProjetoNotas.Domain.Entities;
using ProjetoNotas.Domain.Interfaces.IRepository;
using ProjetoNotas.Infra.Data.Repository.Context;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNotas.Infra.Data.Repository.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly SQLServerContext _context;

        public UserRepository(SQLServerContext context) : base(context) { }
        
        public async Task<List<User>> FindUserWithNotes()
        {
            var query = _context.Users.Include(u => u.Notes);

            return await query.ToListAsync();
        }
    }
}
