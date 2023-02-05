using HealthSystemManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemManager.Domain.DTO
{
    public class PersonDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string identityDocument { get; set; }
        public DateTime birthDate { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string city { get; set; }

        public PersonDTO mapToDTO(Person person)
        {
            return new PersonDTO
            {
                id = person.Id,
                name = person.Name,
                identityDocument = person.IdentityDocument,
                birthDate = person.BirthDate,
                phone = person.Phone,
                address = person.Address,
                city = person.City,
            };
        }

        public Person mapToEntity()
        {
            return new Person
            {
                Id = id,
                Name = name,
                IdentityDocument = identityDocument,
                BirthDate= birthDate,
                Phone = phone,
                Address = address,
                City = city,
            };
        }
    }
}
