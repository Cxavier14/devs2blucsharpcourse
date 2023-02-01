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
    public class NewsRepository : BaseRepository<News> , INewsRepository
    {
        private readonly SQLServerContext _context;
        public NewsRepository(SQLServerContext context) : base(context)
        {
        }
    }
}
