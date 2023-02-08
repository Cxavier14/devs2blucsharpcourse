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
        
        [Display(Name = "Identity Document")]
        public string identityDocument { get; set; }
        
        [Display(Name = "Birth Date")]
        public DateTime birthDate { get; set; }
        
        [Display(Name = "Phone")]
        public string phone { get; set; }
        
        [Display(Name = "Address")]
        public string address { get; set; }
       
        [Display(Name = "City")]
        public string city { get; set; }
    }
}
