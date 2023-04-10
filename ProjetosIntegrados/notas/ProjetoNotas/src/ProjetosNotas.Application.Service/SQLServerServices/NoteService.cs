using ProjetoNotas.Domain.DTO;
using ProjetoNotas.Domain.Interfaces.IRepository;
using ProjetoNotas.Domain.Interfaces.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosNotas.Application.Service.SQLServerServices
{
    public class NoteService : INoteService
    {
        private readonly INoteRepository _repository;
        public NoteService(INoteRepository repository)
        {
            _repository = repository;
        }

        public Task<int> Delete(NoteDTO entity)
        {
            throw new NotImplementedException();
        }

        public List<NoteDTO> FindAll()
        {
            return _repository.FindAll()
                .Select(n => new NoteDTO
                {
                    id = n.Id,
                    userId = n.UserId,
                    title = n.Title,
                    description = n.Description,
                    category = n.Category,
                    pinned = n.Pinned,
                    timeNote = n.TimeNote
                }).ToList();
        }

        public Task<NoteDTO> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save(NoteDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(NoteDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
