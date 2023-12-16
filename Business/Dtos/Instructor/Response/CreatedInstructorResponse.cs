using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Instructor.Response
{
    public class CreatedInstructorResponse
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }       
        public string About { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
