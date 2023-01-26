using RevisaoProjetoNoticias.Domain.DTO;
using RevisaoProjetoNoticias.Domain.Entities;
using RevisaoProjetoNoticias.Domain.IRepositories;
using RevisaoProjetoNoticias.Domain.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoProjetoNoticia.Application.Sevice.SQLServerServices
{
    public class NewsService : INewsService
    {
        private readonly INewsRepository _repository;

        public NewsService(INewsRepository repository)
        {
            _repository = repository;
        }

        public Task<int> Delete(NewsDTO entity)
        {
            throw new NotImplementedException();
        }

        public List<NewsDTO> FindAll()
        {
            return _repository.FindAll()
                .Select(n => new NewsDTO()
                {
                    id = n.Id,
                    title = n.Title,
                    description = n.Description,
                    createdOn = n.CreatedOn,
                    published = n.Published,
                    categoryId = n.CategoryId,
                    category = new CategoryDTO()
                    {
                        id = n.Category.Id,
                        name = n.Category.Name
                    }
                }).ToList();
        }

        public async Task<NewsDTO> FindById(int id)
        {
            var dto = new NewsDTO();
            return dto.mapToDTO(await _repository.FindById(id));
        }

        public Task<int> Save(NewsDTO entity)
        {
            if (entity.id > 0)
            {
                return _repository.Update(entity.mapToEntity());
            }
            else
            {
                return _repository.Save(entity.mapToEntity());
            }
        }
    }
}
