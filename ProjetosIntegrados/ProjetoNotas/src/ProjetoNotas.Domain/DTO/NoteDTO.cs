﻿using ProjetoNotas.Domain.Entities;
using ProjetoNotas.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNotas.Domain.DTO
{
    public class NoteDTO
    {
        public int id { get; set; }
        public int userId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public CategoryEnum category { get; set; }
        public bool pinned { get; set; }
        public DateTime timeNote { get; set; }
        public virtual UserDTO? user { get; set; }

        public NoteDTO mapToDTO(Note note)
        {
            return new NoteDTO()
            {
                id = note.Id,
                userId = note.UserId,
                title = note.Title,
                description = note.Description,
                category = note.Category,
                pinned = note.Pinned,
                timeNote = note.TimeNote,
            };
        }

        public Note mapToEntity()
        {
            return new Note()
            {
                Id = id,
                UserId = userId,
                Title = title,
                Description = description,
                Category = category,
                Pinned = pinned,
                TimeNote = timeNote,
            };
        }
    }
}
