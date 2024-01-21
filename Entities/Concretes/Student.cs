using Core.Entities;
using Core.Entities.Concrete;
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
        public Guid UserId { get; set; }
        

        public User? User{ get; set; }
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
