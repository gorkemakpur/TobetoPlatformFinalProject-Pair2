using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Student : Entity<Guid>
    {
        public Guid DepartmentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public DateTime BirthDate { get; set; }
        public string NationalityId { get; set; }
        public int PhoneNumber { get; set; }
        public string About { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string AddressDescription { get; set; }

        public Department? Department { get; set; }
        public List<Application>? Applications { get; set; }
        public List<Language>? Languages { get; set; }
        public List<Certificate>? Certificates { get; set; }
        public List<Experience>? Experiences { get; set; }
        public List<Competence>? Competences { get; set; }
        public List<Education>? Educations { get; set; }
        public List<SocialMedia>? SocialMedias { get; set; }
    }
}
