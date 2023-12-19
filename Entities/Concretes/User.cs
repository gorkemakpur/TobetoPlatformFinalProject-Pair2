using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class User : Entity<Guid>
    {
        public Guid RoleId { get; set; }
        public Guid CityId { get; set; }
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
        public string AddressDescription { get; set; }

        public List<AnnouncementUser>? AnnouncementUsers { get; set; }
        public List<Instructor>? Instructors { get; set; }
        public List<Student>? Students { get; set; }

        public Role? Role { get; set; }
        public District? District { get; set; }
    }
}
