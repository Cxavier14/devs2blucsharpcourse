using Devs2Blu.ProjetosAula.MVCSQLServerApp2.Web.Models;
using Devs2Blu.ProjetosAula.MVCSQLServerApp2.Web.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.ProjetosAula.MVCSQLServerApp2.Web.Repository
{
    public class CategoriaRepository
    {
        private readonly ContextoDatabase _contexto;

        public CategoriaRepository(ContextoDatabase contexto)
        {
            _contexto = contexto;
        }

        public async Task<IEnumerable<Categoria>> GetAll()
        {
            return await _contexto.Categoria.ToListAsync();
        }

        public async Task<int> SalvaNoBanco(Categoria categoria)
        {
            _contexto.Add(categoria);
            return await _contexto.SaveChangesAsync();
        }
    }
}
