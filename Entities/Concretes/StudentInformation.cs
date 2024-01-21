using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class StudentInformation : Entity<Guid>
    {
        //Öğrenciye özel bilgileri bu tabloda tutacağız
        public Guid StudentId { get; set; }
        public Guid DistrictId { get; set; }

        public DateTime BirthDate { get; set; }
        public string NationalityId { get; set; }
        public int PhoneNumber { get; set; }
        public string About { get; set; }
        public string Country { get; set; }
        public string AddressDescription { get; set; }

        public District? District { get; set; }
        public Student? Student { get; set; }
    }
    
}
