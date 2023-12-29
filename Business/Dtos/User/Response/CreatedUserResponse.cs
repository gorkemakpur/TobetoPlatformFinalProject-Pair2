using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.User.Response
{
    public class CreatedUserResponse
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
    }
}
