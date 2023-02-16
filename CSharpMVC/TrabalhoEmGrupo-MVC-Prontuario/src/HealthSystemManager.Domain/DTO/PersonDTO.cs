using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemManager.Domain.DTO
{
    public class PersonDTO
    {
        [Display(Name ="Code")]
        public int id { get; set; }
        
        [Display(Name ="Name")]
        public string name { get; set; }

        public string identityDocument { get; set; }

        [Display(Name = "Birth Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime birthDate { get; set; }

        public string phone { get; set; }
        public string address { get; set; }
        public string city { get; set; }


    }
}
