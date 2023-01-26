using RevisaoProjetoNoticias.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoProjetoNoticias.Domain.DTO
{
    public class NewsDTO
    {
        [Display(Name = "Code")]
        public int id { get; set; }

        [Display(Name = "Title")]
        [Required(ErrorMessage = "Please, set a title")]
        [MinLength(3, ErrorMessage = "Title should bigger than 3 charactere")]
        public string title { get; set; }

        [Display(Name = "Description")]
        public string description { get; set; }

        [Display(Name = "Created on")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString ="{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime? createdOn { get; set; }

        [Display(Name = "Published")]
        public bool published { get; set; }

        public int categoryId { get; set; }
        public virtual CategoryDTO? category { get; set; }

        public News mapToEntity()
        {
            return new News()
            {
                Id = id,
                Title = title,
                Description = description,
                CreatedOn = createdOn,
                Published = published,
                CategoryId = categoryId
            };
        }

        public NewsDTO mapToDTO(News news)
        {
            return new NewsDTO()
            {
                id = news.Id,
                title = news.Title,
                description = news.Description,
                createdOn = news.CreatedOn,
                published = news.Published,
                categoryId = news.CategoryId,
                //category = new CategoryDTO()
                //{
                //    id = news.Category.Id,
                //    name = news.Category.Name
                //}
            };
        }
    }
}
