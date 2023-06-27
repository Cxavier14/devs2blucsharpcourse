﻿using ProjetoNotas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNotas.Domain.Interfaces.IRepository
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<List<User>> FindUserWithNotes();
    }
}
