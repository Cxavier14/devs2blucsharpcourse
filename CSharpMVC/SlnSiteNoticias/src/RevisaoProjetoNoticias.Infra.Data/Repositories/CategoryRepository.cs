using RevisaoProjetoNoticias.Domain.Entities;
using RevisaoProjetoNoticias.Domain.IRepositories;
using RevisaoProjetoNoticias.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoProjetoNoticias.Infra.Data.Repositories
{
    public class CategoryRepository : BaseRepository<Category> , ICategoryRepository
    {
        private readonly SQLServerContext _context;
        public CategoryRepository(SQLServerContext context) : base(context)
        {
        }
    }
}
